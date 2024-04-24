using System.Collections.Generic;
using System.Linq;

namespace Homework_2.Homework_2_2
{
    public class NpcStateMachine : IStateSwitcher
    {
        private List<IState> _states;
        private IState _currentState;

        public NpcStateMachine(Npc npc)
        {
            StateMachineData data = new StateMachineData();
            
            _states = new List<IState>()
            {
                new WorkState(this, data, npc),
                new MoveState(this, data, npc),
                new RestState(this, data, npc)
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
}

