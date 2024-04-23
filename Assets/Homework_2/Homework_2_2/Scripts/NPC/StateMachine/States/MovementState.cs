using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Homework_2.Homework_2_2.Scripts.NPC.StateMachine.States
{
    public abstract class MovementState : IState
    {
        protected readonly IStateSwitcher StateSwitcher;
        protected readonly IState TargetWorkState;

        private readonly Npc _npc;
        
        private Coroutine _movingCoroutine;
        private float _time;
        public MovementState(IStateSwitcher stateSwitcher, Npc npc)
        {
            StateSwitcher = stateSwitcher;
            _npc = npc;
        }
        
        public void Enter()
        {
            Debug.Log("Иду к точке");
            _time = 0;
        }

        public void Exit()
        {
            Debug.Log("Пришёл в точку");
        }

        public void Update()
        {
            _time += Time.deltaTime;

            if (_time >= 3)
            {
                ReachPoint<IState>();
            }
        }

        protected virtual void ReachPoint<T>() where T : IState 
        {
            StateSwitcher.SwitchState<T>();
        } 
    }
}