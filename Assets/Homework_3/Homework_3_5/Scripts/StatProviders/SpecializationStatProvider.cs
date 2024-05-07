using System;

namespace Homework_3.Homework_3_5
{
    public class SpecializationStatProvider : IStatProvider
    {
        private IStatProvider _stats;
        private Specialization _specialization;

        public SpecializationStatProvider(IStatProvider stats, Specialization specialization)
        {
            _stats = stats;
            _specialization = specialization;
        }

        public int GetStrength()
        {
            switch (_specialization)
            {
                case Specialization.Barbarian:
                    return _stats.GetStrength() + 10;

                case Specialization.Mage:
                    return _stats.GetStrength() - 10;

                case Specialization.Thief:
                    return _stats.GetStrength() - 2;

                default:
                    throw new ArgumentException(nameof(_specialization));
            }
        }

        public int GetIntelligence()
        {
            switch (_specialization)
            {
                case Specialization.Barbarian:
                    return _stats.GetIntelligence() - 10;

                case Specialization.Mage:
                    return _stats.GetIntelligence() * 2;

                case Specialization.Thief:
                    return _stats.GetIntelligence();

                default:
                    throw new ArgumentException(nameof(_specialization));
            }
        }

        public int GetAgility()
        {
            switch (_specialization)
            {
                case Specialization.Barbarian:
                    return _stats.GetAgility() - 5;

                case Specialization.Mage:
                    return _stats.GetAgility() - 2;

                case Specialization.Thief:
                    return _stats.GetAgility() + 10;

                default:
                    throw new ArgumentException(nameof(_specialization));
            }
        }
    }
}