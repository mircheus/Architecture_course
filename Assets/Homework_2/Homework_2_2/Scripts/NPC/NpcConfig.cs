using UnityEngine;

namespace Homework_2.Homework_2_2
{
    [CreateAssetMenu(fileName = "NpcConfig", menuName = "Configs/NpcConfig")]
    public class NpcConfig : ScriptableObject
    {
        [SerializeField] private WorkStateConfig _workStateConfig;
        [SerializeField] private RestStateConfig _restStateConfig;
        [SerializeField] private MoveStateConfig _moveStateConfig;

        public WorkStateConfig WorkStateConfig => _workStateConfig;
        public RestStateConfig RestStateConfig => _restStateConfig;
        public MoveStateConfig MoveStateConfig => _moveStateConfig;
    }
}