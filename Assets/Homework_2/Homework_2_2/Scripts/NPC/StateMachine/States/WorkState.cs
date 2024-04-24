using UnityEngine;
namespace Homework_2.Homework_2_2
{
    public class WorkState : IState
    {
        protected readonly IStateSwitcher StateSwitcher;
        
        private readonly Npc _npc;

        private float _time;
        
        public WorkState(IStateSwitcher stateSwitcher, Npc npc)
        {
            StateSwitcher = stateSwitcher;
            _npc = npc;
        }
        public void Enter()
        {
            _time = 0;
            Debug.Log("Начал работу");
        }

        public void Exit()
        {
            Debug.Log("Закончил работу");
        }

        public void Update()
        {
            _time += Time.deltaTime;

            if (_time >= 3)
            {
                StateSwitcher.SwitchState<MoveToRestState>();
            }
        }
    }
}