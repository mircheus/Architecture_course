using OpenCover.Framework.Model;
using UnityEngine;

namespace Homework_3.Homework_3_2
{
    public class Paladin : Enemy
    {
        public Paladin(Race race) : base(race)
        {
            ClassName = EnemyClass.Paladin;
        }

        public override void Attack()
        {
            AttackBySword();
        }

        protected void AttackBySword()
        {
            Debug.Log("Бью мечом");
            Race.ApplySpecialAbility();
        }
    }
}