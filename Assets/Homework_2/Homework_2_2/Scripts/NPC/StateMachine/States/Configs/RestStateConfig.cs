using System;
using UnityEngine;

namespace Homework_2.Homework_2_2
{
    [Serializable]
    public class RestStateConfig
    {
        [field: SerializeField, Range(0, 16)] public float activityTime { get; private set; }
    }
}