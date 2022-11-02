using Busines.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busines.Activities
{
    public interface IActivity
    {
        void BuildComponent(ActivityDetailsModel activityDetailsModel);
        void BuildMachine(ActivityDetailsModel activityDetailsModel);
    }
}
