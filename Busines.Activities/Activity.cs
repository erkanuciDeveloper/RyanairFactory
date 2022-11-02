using Busines.Model;
using Business.Activities;
using Business.Worker;
using DapperMigrations.Entities;
using Data.Daper.Repositories.ActivityRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Busines.Activities
{
    public class Activity : IActivity
    {  
        public void BuildComponent(ActivityDetailsModel activityDetailsModel)
        {

            Helpers helpers = new Helpers();
            helpers.InsertData(activityDetailsModel);


        }

        public void BuildMachine(ActivityDetailsModel activityDetailsModel)
        {
            Helpers helpers = new Helpers();
            helpers.InsertData(activityDetailsModel);
        }
    }
}
