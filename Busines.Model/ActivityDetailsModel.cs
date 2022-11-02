using Business.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busines.Model
{
   public class ActivityDetailsModel
    {
        public int ActivityId { get; set; }
        public string ActivityName { get; set; }
        public string ActivityDetails { get; set; }
        public string ActivityTypeId { get; set; }
        public ActivityType? ActivityType { get; set; }
        public DateTime ActivityStarTime { get; set; }
        public DateTime ActivityEndTime { get; set; }
        public List<WorkersModel> Workers { get; set; }

        public List<string> WorkersId { get; set; }
    }
}
