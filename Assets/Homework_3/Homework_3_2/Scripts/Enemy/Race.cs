namespace Homework_3.Homework_3_2
{
    public abstract class Race
    {
        public readonly string RaceName;

        protected Race(string raceName)
        {
            RaceName = raceName;
        }

        public virtual void ApplySpecialAbility(){}
    }
}