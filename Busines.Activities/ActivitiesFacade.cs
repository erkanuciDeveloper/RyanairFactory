using Busines.Activities;
using Busines.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Activities
{
 
    public class ActivitiesFacade
    {
        private readonly IActivity _activity;
        public ActivitiesFacade(IActivity activity)
        {
            this._activity = activity;
        }

        public void BuildComponentOperation(ActivityDetailsModel activityDetailsModel)
        {
            _activity.BuildComponent(activityDetailsModel);
        }
        public void BuildMachineOperation(ActivityDetailsModel activityDetailsModel)
        {
            _activity.BuildMachine(activityDetailsModel);
        }
    }
}
