using UnityEngine;

namespace Homework_3.Homework_3_2
{
    public class Mage : Enemy
    {
        private const string MageClass = "Mage";
        
        public Mage(Race race) : base(race, MageClass)
        {
        }
        
        public override void Attack()
        {
            CastSpell();
        }

        protected void CastSpell()
        {
            Debug.Log("Кастую фаерболл");
            Race.ApplySpecialAbility();
        }
    }
}