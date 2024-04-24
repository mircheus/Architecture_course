namespace Homework_2.Homework_2_2
{
    public class MoveToWorkState : MovementState
    {
        public MoveToWorkState(IStateSwitcher stateSwitcher, Npc npc) : base(stateSwitcher, npc)
        {
        }

        protected override void ReachPoint<WorkState>()
        {
            base.ReachPoint<WorkState>();
        }
    }
}