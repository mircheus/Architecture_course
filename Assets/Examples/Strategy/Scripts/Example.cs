using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace StrategyExample
{
    public class Example : MonoBehaviour
    {
        [SerializeField] private Sherif _sherif;
        [SerializeField] private Transform _target;
        [SerializeField] private List<Transform> _patrolPoints;

        private void Awake()
        {
            _sherif.SetMover(new NoMovePattern());
        }

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.Q))
            {
                Debug.Log("No move");
                _sherif.SetMover(new NoMovePattern());
            }
            
            if(Input.GetKeyDown(KeyCode.W))
            {
                Debug.Log("Point by point move");
                _sherif.SetMover(new PointByPointMover(_sherif.transform, _patrolPoints.Select(point => point.position), _sherif.Speed));
            }
            
            if(Input.GetKeyDown(KeyCode.S))
            {
                Debug.Log("Move to target");
                _sherif.SetMover(new MoveToTargetPattern(_sherif.transform, _target, _sherif.Speed));
            }
        }
    }
}