using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

namespace Homework_3.Homework_3_2
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] private RaceType _raceType;
        [SerializeField] private float _spawnCooldown;

        private EnemyFactory _enemyFactory;

        private void Start()
        {
            SetFactory(_raceType);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Enemy randomEnemy = SpawnRandomTypeEnemy();
                Debug.Log("\nRace: " + _raceType + " \nClass: " + randomEnemy.ClassName);
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                SetFactory(RaceType.Elf);
            }

            if (Input.GetKeyDown(KeyCode.O))
            {
                SetFactory(RaceType.Orc);
            }
        }
        
        private void SetFactory(RaceType raceType)
        {
            switch (raceType)
            {
                case RaceType.Elf:
                    _enemyFactory= new ElfFactory();
                    break;
                
                case RaceType.Orc:
                    _enemyFactory = new OrcFactory();
                    break;
                    
                default:
                    throw new ArgumentException(nameof(_raceType));
            }
        }

        private Enemy SpawnRandomTypeEnemy()
        {
            int length = Enum.GetValues(typeof(EnemyClass)).Length;
            EnemyClass randomClass = (EnemyClass)Random.Range(0, length);
            Enemy result = _enemyFactory.Get(randomClass);
            return result;
        }
        
        private IEnumerator SpawnEnemyWithCooldown()
        {
            yield return new WaitForSeconds(_spawnCooldown);
            SpawnRandomTypeEnemy();
        }
    }
}