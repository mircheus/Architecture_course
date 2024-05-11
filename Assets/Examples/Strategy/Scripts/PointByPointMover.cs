using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyExample 
{
    public class PointByPointMover : IMover
    {
        private const float MinDistanceToTarget = 0.005f;
        
        private Transform _transform;
        private Queue<Vector3> _targets;
        private float _speed;

        private Vector3 _currentTarget;

        private bool _isMoving;

        public PointByPointMover(Transform transform, IEnumerable<Vector3> targets, float speed)
        {
            _transform = transform;
            _targets = new Queue<Vector3>(targets);
            _speed = speed;

            _currentTarget = _targets.Dequeue();
        }

        public void Update()
        {
            if (_isMoving == false)
                return;

            Vector3 direction = _currentTarget - _transform.position;
            _transform.Translate(direction.normalized * _speed * Time.deltaTime);

            if (direction.magnitude <= MinDistanceToTarget)
                SwitchTarget();
        }

        public void StartMove() => _isMoving = true;

        public void StopMove() => _isMoving = false;

        private void SwitchTarget()
        {
            _targets.Enqueue(_currentTarget);
            _currentTarget = _targets.Dequeue();
        }
    }
}

