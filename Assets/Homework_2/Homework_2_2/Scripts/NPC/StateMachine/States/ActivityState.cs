using UnityEngine;

namespace Homework_2.Homework_2_2
{
    public abstract class ActivityState : IState
    {
        protected readonly IStateSwitcher StateSwitcher;
        protected StateMachineData Data;
        
        private readonly Npc _npc;

        protected float TimeCounter;
        protected float ActivityTime;
        protected string NextDestination;

        public ActivityState(IStateSwitcher stateSwitcher, StateMachineData data, Npc npc)
        {
            StateSwitcher = stateSwitcher;
            Data = data;
            _npc = npc;
        }
        
        public virtual void Enter()
        {
            TimeCounter = 0;
        }

        public virtual void Exit()
        {
        }

        public void Update()
        {
            DoFor(ActivityTime); 
        }

        protected virtual void SwitchTo<T>() where T : IState
        {
            StateSwitcher.SwitchState<T>();
        }
        
        private void DoFor(float amountOfTime)
        {
            TimeCounter += Time.deltaTime;

            if (TimeCounter >= amountOfTime)
            {
                SwitchTo<IState>();
            }
        }
    }
}