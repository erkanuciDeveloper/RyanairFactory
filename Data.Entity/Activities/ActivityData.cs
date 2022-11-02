using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity.Activities
{
   public class ActivityData
    {
        public int Id { get; set; }
        public string ActivityName { get; set; }
        public int ActivityType { get; set; }
        public DateTime ActivityStarTime { get; set; }
        public DateTime ActivityEndTime { get; set; }
        public DateTime CreaDate { get; set; }
        //public int WorkerId { get; set; }
        public string ActivityDetails { get; set; }
        public int WorkerStatus { get; set; }
    }
}
