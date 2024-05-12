namespace Homework_3.Homework_3_2
{
    public abstract class Enemy : IAttacker
    {
        public EnemyClass ClassName { get; protected set; }
        public readonly Race Race;

        protected Enemy(Race race)
        {
            Race = race;
        }

        public abstract string Attack(); // Возвращает строку с описанием атаки, чтобы было удобнее видеть какой тип объекта произвела фабрика
    }
}