using UnityEngine;

namespace Homework_3.Homework_3_5.DecoratorExample
{
    public class Player : MonoBehaviour
    {
        private IHealthStat _health;

        public void Initialize(IHealthStat health) => _health = health;

        public void TakeDamage(int damage) => _health.Reduce(damage);
        public void Heal(int value) => _health.Add(value);
    }
}