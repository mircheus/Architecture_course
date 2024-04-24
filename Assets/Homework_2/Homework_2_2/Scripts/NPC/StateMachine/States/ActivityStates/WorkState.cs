using UnityEngine;

namespace Homework_2.Homework_2_2
{
    public class WorkState : ActivityState
    {
        private WorkStateConfig _config;
        private readonly string _nextDestination = "Rest";
        
        public WorkState(IStateSwitcher stateSwitcher, StateMachineData data, Npc npc) : base(stateSwitcher, data, npc)
        {
            _config = npc.NpcConfig.WorkStateConfig;
            ActivityTime = _config.activityTime;
        }
        
        public override void Enter()
        {
            Debug.Log("Начал работу");
            base.Enter();
        }

        public override void Exit()
        {
            Debug.Log("Закончил работу");
            base.Exit();
        }

        protected override void SwitchTo<T>()
        {
            Data.SetDestinationByCurrent(this, _nextDestination);
            StateSwitcher.SwitchState<MovementState>();
        }
    }
}