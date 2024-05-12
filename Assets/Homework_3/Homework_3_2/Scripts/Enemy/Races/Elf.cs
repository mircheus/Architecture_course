using UnityEngine;

namespace Homework_3.Homework_3_2
{
    public class Elf : Race
    {
        private string _specialAbility = "Эльф суперсила!";

        public override string ApplySpecialAbility()
        {
            return _specialAbility;
        }
    }
}