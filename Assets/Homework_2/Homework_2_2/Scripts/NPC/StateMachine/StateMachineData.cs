namespace Homework_2.Homework_2_2
{
    public class StateMachineData
    {
        private string _destination;
        private float _timeToReach;
        public string Destination => _destination;
        public float TimeToReach => _timeToReach;
        
        public void SetDestinationByCurrent(ActivityState activityState, string destination)
        {
            _destination = destination;
        }
    }
}