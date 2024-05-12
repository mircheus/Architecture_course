using UnityEngine;

namespace Homework_3.Homework_3_2
{
    public class Orc : Race
    {
        private string _specialAbility = "Орк суперсила!";
        
        public override string ApplySpecialAbility()
        {
            return _specialAbility;
        }
    }
}