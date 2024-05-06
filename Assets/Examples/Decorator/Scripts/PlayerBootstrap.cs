using System;
using UnityEngine;

namespace Homework_3.Homework_3_5.DecoratorExample
{
    public class PlayerBootstrap : MonoBehaviour
    {
        [SerializeField] private Player _player;

        private int _damage = 6;
        private int _heal = 1;
        
        private void Awake()
        {
            _player.Initialize(new AngelHealth((new ArmorHealth(new Health(50), 3)), 4, 4, this));
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                _player.TakeDamage(_damage);

            if (Input.GetKeyDown(KeyCode.F))
                _player.Heal(_heal);
        }
    }
}