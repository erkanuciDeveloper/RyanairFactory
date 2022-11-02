using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity.Workers
{
    public class Workers
    {
        public int Id { get; set; }
        public string WorkerName { get; set; }
        public int Status { get; set; }
        public decimal Deleted { get; set; }
    }
}
