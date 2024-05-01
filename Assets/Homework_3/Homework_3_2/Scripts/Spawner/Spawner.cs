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
                Debug.Log("[" + gameObject.name + "]" + " Race: " + randomEnemy.Race + " Class: " + randomEnemy.ClassName);
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                SetFactory(_enemyFactory.FactoryType == RaceType.Elf ? RaceType.Orc : RaceType.Elf);
            }
        }
        
        private void SetFactory(RaceType raceType)
        {
            switch (raceType) 
            {
                case RaceType.Elf:
                    _enemyFactory = new ElfFactory();
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
    }
}