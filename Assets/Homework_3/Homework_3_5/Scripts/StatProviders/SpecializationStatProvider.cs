using System;

namespace Homework_3.Homework_3_5
{
    public class SpecializationStatProvider : StatProvider
    {
        private Specialization _specialization;

        public SpecializationStatProvider(IStatProvider stats, Specialization specialization) : base(stats)
        {
            _specialization = specialization;
        }

        public override int GetStrength()
        {
            switch (_specialization)
            {
                case Specialization.Barbarian:
                    return Stats.Strength + 10;

                case Specialization.Mage:
                    return Stats.Strength - 10;

                case Specialization.Thief:
                    return Stats.Strength - 2;

                default:
                    throw new ArgumentException(nameof(_specialization));
            }
        }

        public override int GetIntelligence()
        {
            switch (_specialization)
            {
                case Specialization.Barbarian:
                    return Stats.Intelligence - 10;

                case Specialization.Mage:
                    return Stats.Intelligence * 2;

                case Specialization.Thief:
                    return Stats.Intelligence;

                default:
                    throw new ArgumentException(nameof(_specialization));
            }
        }

        public override int GetAgility()
        {
            switch (_specialization)
            {
                case Specialization.Barbarian:
                    return Stats.Agility - 5;

                case Specialization.Mage:
                    return Stats.Agility - 2;

                case Specialization.Thief:
                    return Stats.Agility + 10;

                default:
                    throw new ArgumentException(nameof(_specialization));
            }
        }
    }
}