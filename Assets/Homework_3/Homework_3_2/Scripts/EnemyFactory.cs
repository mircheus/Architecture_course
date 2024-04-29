using System;

namespace Homework_3.Homework_3_2
{
    public class EnemyFactory
    {
        public IAttacker Get(AttackerTypes attackerType)
        {
            switch (attackerType)
            {
                // case AttackerTypes.Magician:
                //     return new Mage();
                //
                // case AttackerTypes.Paladin:
                //     return new Paladin();
                
                default:
                    throw new ArgumentException(nameof(attackerType));
            }
        }
    }
}