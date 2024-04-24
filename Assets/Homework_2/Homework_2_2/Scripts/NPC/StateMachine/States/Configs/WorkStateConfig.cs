using System;
using UnityEngine;

namespace Homework_2.Homework_2_2
{
    [Serializable]
    public class WorkStateConfig
    {
        [field: SerializeField, Range(0, 8)] public float activityTime { get; private set; }
    }
}