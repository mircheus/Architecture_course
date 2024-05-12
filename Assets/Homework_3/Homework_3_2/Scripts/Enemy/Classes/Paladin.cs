using OpenCover.Framework.Model;
using UnityEngine;

namespace Homework_3.Homework_3_2
{
    public class Paladin : Enemy
    {
        private string _attackType = "Атака мечом!";
        
        public Paladin(Race race) : base(race)
        {
            ClassName = EnemyClass.Paladin;
        }

        public override string Attack()
        {
            return AttackBySword();
        }

        protected string AttackBySword()
        {
            string resultAttack = _attackType + " " + Race.ApplySpecialAbility();
            return resultAttack;
        }
    }
}