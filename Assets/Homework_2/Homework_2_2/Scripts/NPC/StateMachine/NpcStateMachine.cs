using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Homework_2.Homework_2_2.Scripts.NPC;
using Homework_2.Homework_2_2.Scripts.NPC.StateMachine;
using Homework_2.Homework_2_2.Scripts.NPC.StateMachine.States;
using Homework_2.Homework_2_2.Scripts.NPC.StateMachine.States.MovementStates;
using UnityEngine;

public class NpcStateMachine : IStateSwitcher
{
    private List<IState> _states;
    private IState _currentState;

    public NpcStateMachine(Npc npc)
    {
        _states = new List<IState>()
        {
            new MoveToWorkState(this, npc),
            new WorkState(this, npc),
            new MoveToRestState(this, npc),
            new RestState(this, npc)
        };

        _currentState = _states[0];
        _currentState.Enter();
    }

    public void SwitchState<T>() where T : IState
    {
        IState state = _states.FirstOrDefault(state => state is T);
        
        _currentState.Exit();
        _currentState = state;
        if (_currentState != null) _currentState.Enter();
    }

    public void Update() => _currentState.Update();
}
