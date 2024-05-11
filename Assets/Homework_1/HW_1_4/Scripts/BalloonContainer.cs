using System;
using System.Collections.Generic;
using UnityEngine;

namespace Homework_1.HW_1_4
{
    public class BalloonContainer : MonoBehaviour
    {
        private IPointsCounter _pointsCounter;

        [SerializeField] private List<Balloon> _ballons = new List<Balloon>();
        
        public IPointsCounter PointsCounter => _pointsCounter;
        public List<Balloon> Ballons => _ballons;
        public int BalloonsCount => _ballons.Count;

        private void OnEnable()
        {
            foreach (var ballon in _ballons)
            {
                ballon.Interacted += OnBalloonInteracted;
            }
        }

        private void OnDisable()
        {
            foreach (var ballon in _ballons)
            {
                ballon.Interacted -= OnBalloonInteracted;
            }
        }
        
        public void SetPointsCounter(IPointsCounter pointsCounter)
        {
            _pointsCounter = pointsCounter;
        }

        private void OnBalloonInteracted(Balloon balloon)
        {
            _pointsCounter.AddPoint(balloon);
        }
    }
}
