namespace Homework_3.Homework_3_5
{
    public interface IStatProvider
    {
        int Strength { get; }
        int Intelligence { get; }
        int Agility { get; }
        int GetStrength();
        int GetIntelligence();
        int GetAgility();
    }
}