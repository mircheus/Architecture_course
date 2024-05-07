using System;
using UnityEngine;

namespace Homework_3.Homework_3_5
{
    public class PlayerBootstrap : MonoBehaviour
    {
        [SerializeField] private Player _player;

        private void Awake()
        {
            // _player.Initialize(new SpecializationStatProvider(new RaceStatProvider(new CharacterStats(50, 10, 5), Race.Elf), Specialization.Mage));
            _player.Initialize(new SpecializationStatProvider(new RaceStatProvider(new CharacterStats(100, 100, 100), Race.Elf), Specialization.Thief));
            // _player.Initialize(new SpecializationStatProvider(new CharacterStats(100, 100, 100), Specialization.Mage));
            // Сейчас characterStats не передаются, поэтому при ещё одном обороте декоратора будет неверное поведение, будут использованы нулевые значения
            _player.GetStats();
        }
    }
}