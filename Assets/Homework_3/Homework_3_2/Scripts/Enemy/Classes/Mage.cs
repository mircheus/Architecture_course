using UnityEngine;

namespace Homework_3.Homework_3_2
{
    public class Mage : Enemy
    {
        public Mage(Race race) : base(race)
        {
            ClassName = EnemyClass.Mage;
        }
        
        public override void Attack()
        {
            CastSpell();
        }


        private void CastSpell()
        {
            Debug.Log("Кастую фаерболл");
            Race.ApplySpecialAbility();
        }
    }
}