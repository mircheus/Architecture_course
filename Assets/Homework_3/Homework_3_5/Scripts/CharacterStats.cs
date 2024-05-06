namespace Homework_3.Homework_3_5
{
    public class CharacterStats : IStatProvider
    {
        private int _strength;
        private int _intelligence;
        private int _agility;

        public int Strength => _strength;
        public int Intelligence => _intelligence;
        public int Agility => _agility;

        public CharacterStats(int strength, int intelligence, int agility)
        {
            _strength = strength;
            _intelligence = intelligence;
            _agility = agility;
        }

        public int GetStrength() => _strength;

        public int GetIntelligence() => _intelligence;

        public int GetAgility() => _agility;
    }
}