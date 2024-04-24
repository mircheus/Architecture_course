using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Homework_2.Homework_2_2
{
    public abstract class MovementState : IState
    {
        protected readonly IStateSwitcher StateSwitcher;
        protected readonly StateMachineData Data;

        private readonly Npc _npc;
        
        private Coroutine _movingCoroutine;
        private float _timeCounter;
        protected float TimeToReach;
        public MovementState(IStateSwitcher stateSwitcher, StateMachineData data, Npc npc)
        {
            StateSwitcher = stateSwitcher;
            Data = data;
            _npc = npc;
        }
        
        public void Enter()
        {
            Debug.Log("Иду к точке");
            _timeCounter = 0;
        }

        public void Exit()
        {
            Debug.Log("Пришёл в точку");
        }

        public void Update()
        {
            _timeCounter += Time.deltaTime;

            if (_timeCounter >= TimeToReach)
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