using System;
using System.Diagnostics;

namespace Homework_3.Homework_3_5
{
    public class RaceStatProvider : StatProvider
    {
        private Race _race;
        
        public RaceStatProvider(IStatProvider stats, Race race) : base(stats)
        {
            _race = race;
        }

        public override int GetStrength()
        {
            switch (_race)
            {
                case Race.Orc:
                    return Stats.Strength + 5;
                
                case Race.Elf:
                    return Stats.Strength + 2;
                
                case Race.Human:
                    return Stats.Strength;
                
                default:
                    throw new ArgumentException(nameof(_race));
            }
        }

        public override int GetIntelligence()
        {
            switch (_race)
            {
                case Race.Orc:
                    return Stats.Intelligence;
                
                case Race.Elf:
                    return Stats.Intelligence + 5;
                
                case Race.Human:
                    return Stats.Intelligence;
                
                default:
                    throw new ArgumentException(nameof(_race));
            }
        }

        public override int GetAgility()
        {
            switch (_race)
            {
                case Race.Orc:
                    return Stats.Agility - 1;
                
                case Race.Elf:
                    return Stats.Agility + 2;
                
                case Race.Human:
                    return Stats.Agility;
                
                default:
                    throw new ArgumentException(nameof(_race));
            }
        }
    }
}