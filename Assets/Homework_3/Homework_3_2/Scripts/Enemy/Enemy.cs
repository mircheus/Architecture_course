namespace Homework_3.Homework_3_2
{
    public abstract class Enemy : IAttacker
    {
        public string ClassName; //  TODO: Сомнительно, но окэй
        protected readonly Race Race;

        protected Enemy(Race race, string className)
        {
            Race = race;
            ClassName = className;
        }

        public abstract void Attack();
    }
}