namespace Homework_3.Homework_3_5.DecoratorExample
{
    public interface IHealthStat
    {
        int MaxHealth { get; }
        int Value { get; }
        void Reduce(int value);
        void Add(int value);
    }
}