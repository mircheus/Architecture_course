using System;

namespace Homework_3.Homework_3_5
{
    public class RaceStatProvider : IStatProvider
    {
        private IStatProvider _stats;
        private Race _race;

        public RaceStatProvider(IStatProvider stats, Race race)
        {
            _stats = stats;
            _race = race;
        }

        public int GetStrength()
        {
            switch (_race)
            {
                case Race.Orc:
                    return _stats.GetStrength() + 5;
                
                case Race.Elf:
                    return _stats.GetStrength() + 2;
                
                case Race.Human:
                    return _stats.GetStrength();
                
                default:
                    throw new ArgumentException(nameof(_race));
            }
        }

        public int GetIntelligence()
        {
            switch (_race)
            {
                case Race.Orc:
                    return _stats.GetIntelligence();
                
                case Race.Elf:
                    return _stats.GetIntelligence() + 5;
                
                case Race.Human:
                    return _stats.GetIntelligence();
                
                default:
                    throw new ArgumentException(nameof(_race));
            }
        }

        public int GetAgility()
        {
            switch (_race)
            {
                case Race.Orc:
                    return _stats.GetAgility() - 1;
                
                case Race.Elf:
                    return _stats.GetAgility() + 2;
                
                case Race.Human:
                    return _stats.GetAgility();
                
                default:
                    throw new ArgumentException(nameof(_race));
            }
        }
    }
}