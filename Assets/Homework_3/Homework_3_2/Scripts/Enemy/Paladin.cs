using UnityEngine;

namespace Homework_3.Homework_3_2
{
    public class Paladin : Enemy
    {
        private const string PaladinClass = "Paladin";

        public Paladin(Race race) : base(race, PaladinClass)
        {
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