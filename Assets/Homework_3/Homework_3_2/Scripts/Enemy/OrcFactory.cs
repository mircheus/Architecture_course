using System;

namespace Homework_3.Homework_3_2
{
    public class OrcFactory : EnemyFactory
    {
        public override Enemy Get(EnemyClass enemyClass)
        {
            switch (enemyClass)
            {
                case EnemyClass.Mage:
                    return new Mage(new Orc());
                
                case EnemyClass.Paladin:
                    return new Paladin(new Orc());
                
                default:
                    throw new ArgumentException(nameof(enemyClass));
            }
        }
    }
}