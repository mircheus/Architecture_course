using UnityEngine;

namespace Homework_3.Homework_3_2
{
    public class Mage : Enemy
    {
        private string _attackType = "Атака фаерболом!";
        
        public Mage(Race race) : base(race)
        {
            ClassName = EnemyClass.Mage;
        }
        
        public override string Attack()
        {
            return CastSpell();
        }


        private string CastSpell()
        {
            string resultAttack = _attackType + " " + Race.ApplySpecialAbility();
            return resultAttack;
        }
    }
}