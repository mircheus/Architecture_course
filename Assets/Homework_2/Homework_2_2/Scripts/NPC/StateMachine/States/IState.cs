using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Homework_2.Homework_2_2
{
    public interface IState
    {
        void Enter();
        void Exit();
        void Update();
    }
}

