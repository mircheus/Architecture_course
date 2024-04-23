namespace Homework_2.Homework_2_2.Scripts.NPC.StateMachine.States.MovementStates
{
    public class MoveToRestState : MovementState
    {
        public MoveToRestState(IStateSwitcher stateSwitcher, Npc npc) : base(stateSwitcher, npc)
        {
        }

        protected override void ReachPoint<RestState>()
        {
            base.ReachPoint<States.RestState>();
        }
    }
}