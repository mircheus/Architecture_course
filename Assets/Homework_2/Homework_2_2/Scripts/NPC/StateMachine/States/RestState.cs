using UnityEngine;

namespace Homework_2.Homework_2_2
{
    public class RestState : IState
    {
        protected readonly IStateSwitcher StateSwitcher;
        
        private readonly Npc _npc;

        private float _time;

        public RestState(IStateSwitcher stateSwitcher, Npc npc)
        {
            StateSwitcher = stateSwitcher;
            _npc = npc;
        }

        public void Enter()
        {
            _time = 0;
            Debug.Log("Начал отдых");
        }

        public void Exit()
        {
            Debug.Log("Закончил отдых");
        }

        public void Update()
        {
            _time += Time.deltaTime;

            if (_time >= 3)
            {
                StateSwitcher.SwitchState<MoveToWorkState>();
            }
        }
    }
}