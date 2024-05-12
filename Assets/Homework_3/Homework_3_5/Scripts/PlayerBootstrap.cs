using System;
using UnityEngine;

namespace Homework_3.Homework_3_5
{
    public class PlayerBootstrap : MonoBehaviour
    {
        [SerializeField] private Player _player;
        [SerializeField] private int _strength;
        [SerializeField] private int _intelligence;
        [SerializeField] private int _agility;

        private void Awake()
        {
            _player.Initialize(new SpecializationStatProvider(new RaceStatProvider(new CharacterStats(_strength, _intelligence, _agility), Race.Human), Specialization.Barbarian));
            _player.GetStats();
        }
    }
}