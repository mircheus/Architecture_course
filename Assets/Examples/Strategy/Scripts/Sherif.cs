using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro.EditorUtilities;
using UnityEngine;

namespace StrategyExample
{
    public class Sherif : MonoBehaviour
    {
        private IMover _mover;
        
        [SerializeField] private float _speed;
        [SerializeField] private List<Transform> _patrolPoints;
        
        public float Speed => _speed;
        
        private void Update()
        {
            _mover.Update();
        }
        
        public void SetMover(IMover mover)
        {
            _mover?.StopMove();
            _mover = mover;
            _mover.StartMove();
        }
    }
} 