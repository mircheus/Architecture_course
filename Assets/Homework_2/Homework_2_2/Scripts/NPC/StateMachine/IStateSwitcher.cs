namespace Homework_2.Homework_2_2.Scripts.NPC.StateMachine
{
    public interface IStateSwitcher
    {
        void SwitchState<T>() where T : IState;
    }
}