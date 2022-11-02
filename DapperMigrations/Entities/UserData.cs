using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperMigrations.Entities
{
    public class UserData
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public string Company { get; set; }
        public DateTime CreaDate { get; set; }
        public Guid PhoneBookId { get; set; }
    }
}
