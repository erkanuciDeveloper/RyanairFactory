using Business.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperMigrations.Entities
{
    public class ActivityData
    {
 
        public string ActivityName { get; set; }
        public int ActivityType  { get; set; }
        public DateTime ActivityStarTime { get; set; }
        public DateTime ActivityEndTime { get; set; }
        public DateTime CreaDate { get; set; }
        //public int WorkerId { get; set; }
        public string ActivityDetails { get; set; }
     

    }
}
