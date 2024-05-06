using UnityEngine;

namespace Homework_3.Homework_3_5
{
    public class Player : MonoBehaviour
    {
        private IStatProvider _statProvider;

        public void Initialize(IStatProvider statProvider) => _statProvider = statProvider;
        
        public void GetStats()
        {
            Debug.Log("Strength: " + _statProvider.GetStrength());
            Debug.Log("Intelligence: " + _statProvider.GetIntelligence());
            Debug.Log("Agility: " + _statProvider.GetAgility());
        }
    }
}