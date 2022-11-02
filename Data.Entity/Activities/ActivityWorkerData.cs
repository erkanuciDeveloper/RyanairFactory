using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity.Activities
{
    public class ActivityWorkerData
    {
        public int Id { get; set; }
        public int WorkerId { get; set; }
        public int ActivityId { get; set; }
        public DateTime CreaDate { get; set; }
    }
}
