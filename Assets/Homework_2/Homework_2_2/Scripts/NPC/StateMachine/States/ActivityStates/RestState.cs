using UnityEngine;

namespace Homework_2.Homework_2_2
{
    public class RestState : ActivityState
    {
        private RestStateConfig _config;
        private readonly string _nextDestination = "Work";
        
        public RestState(IStateSwitcher stateSwitcher, StateMachineData data, Npc npc) : base(stateSwitcher, data, npc)
        {
            _config = npc.NpcConfig.RestStateConfig;
            ActivityTime = _config.activityTime;
        }

        public override void Enter()
        {
            Debug.Log("Начал отдых");
            base.Enter();
        }

        public override void Exit()
        {
            Debug.Log("Закончил отдых");
            base.Exit();
        }

        protected override void SwitchTo<T>()
        {
            Data.SetDestinationByCurrent(this, _nextDestination);
            StateSwitcher.SwitchState<MovementState>();
        }
    }
}