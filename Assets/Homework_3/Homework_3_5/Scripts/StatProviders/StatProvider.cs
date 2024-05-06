namespace Homework_3.Homework_3_5
{
    public abstract class StatProvider : IStatProvider
    {
        protected IStatProvider Stats;

        public StatProvider(IStatProvider stats)
        {
            Stats = stats;
        }

        public int Strength { get; }
        public int Intelligence { get; }
        public int Agility { get; }

        public abstract int GetStrength();

        public abstract int GetIntelligence();

        public abstract int GetAgility();
    }
}