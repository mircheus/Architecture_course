using System;

namespace Homework_3.Homework_3_2
{
    public class ElfFactory : EnemyFactory
    {
        public override RaceType FactoryType { get; protected set; }
        
        public ElfFactory()
        {
            FactoryType = RaceType.Elf;
        }

        public override Enemy Get(EnemyClass enemyClass)
        {
            switch (enemyClass)
            {
                case EnemyClass.Mage:
                    return new Mage(new Elf());
                
                case EnemyClass.Paladin:
                    return new Paladin(new Elf());
                
                default:
                    throw new ArgumentException(nameof(enemyClass));
            }
        }
    }
}