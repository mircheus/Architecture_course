using System;
using UnityEngine;

namespace Homework_2.Homework_2_2.Scripts.NPC
{
    public class Npc : MonoBehaviour
    {
        private NpcStateMachine _npcStateMachine;

        private void Awake()
        {
            _npcStateMachine = new NpcStateMachine();
        }
    }
}