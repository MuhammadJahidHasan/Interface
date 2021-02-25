using System.Collections.Generic;

namespace Interface
{
    class Workflow
    {
        private readonly IList<IActivities> _activities;
        public Workflow()
        {
            _activities = new List<IActivities>();

        }

        public void Run(){

            foreach (var activities in _activities)
            {
                activities.Execute();
            }
        }

        public void RegisterActivity(IActivities activity){
            _activities.Add(activity);
        }
    }
}
