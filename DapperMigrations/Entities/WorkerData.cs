using Business.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperMigrations.Entities
{
    public class WorkerData
    {
       
        public string WorkerName { get; set; }
        public int Status { get; set; }
        public DateTime CreaDate { get; set; }
    }
}
