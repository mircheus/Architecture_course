namespace Homework_2.Homework_2_2
{
    public class MoveState : MovementState
    {
        private const string Work = "Work";
        private const string Rest = "Rest";

        private MoveStateConfig _config;
        
        public MoveState(IStateSwitcher stateSwitcher, StateMachineData data, Npc npc) : base(stateSwitcher, data, npc)
        {
            _config = npc.NpcConfig.MoveStateConfig;
            TimeToReach = _config.timeToReach;
        }

        protected override void ReachPoint<T>()
        {
            if (Data.Destination == Work)
            {
                StateSwitcher.SwitchState<WorkState>();
            }
            
            if (Data.Destination == Rest)
            {
                StateSwitcher.SwitchState<RestState>();
            }

            if (Data.Destination == "")
            {
                StateSwitcher.SwitchState<RestState>();
            }
        }
    }
}