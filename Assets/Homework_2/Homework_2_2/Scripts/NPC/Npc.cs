using System;
using System.Collections.Generic;
using UnityEngine;
using Homework_2.Homework_2_2.Scripts;

namespace Homework_2.Homework_2_2.Scripts.NPC
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