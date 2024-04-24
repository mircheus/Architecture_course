using System;
using System.Collections.Generic;
using UnityEngine;

namespace Homework_2.Homework_2_2
{
    public class Npc : MonoBehaviour
    {
        private NpcStateMachine _npcStateMachine;

        private void Awake()
        {
            _npcStateMachine = new NpcStateMachine(this);
        }

        private void Update()
        {
            _npcStateMachine.Update();
        }
    }
}