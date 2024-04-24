namespace Homework_2.Homework_2_2
{
    public interface IStateSwitcher
    {
        void SwitchState<T>() where T : IState;
    }
}