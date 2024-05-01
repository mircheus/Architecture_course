using System;

namespace Homework_3.Homework_3_2
{
    public abstract class EnemyFactory
    {
        public RaceType FactoryType { get; protected set; }

        public abstract Enemy Get(EnemyClass enemyClass);
    }
}