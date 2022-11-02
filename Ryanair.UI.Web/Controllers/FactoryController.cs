using Data.Daper.Repositories.ActivityRepo;
using Data.Daper.WorkerRepo;
using Data.Entity.Activities;
using Data.Entity.Workers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ryanair.UI.Web.Controllers
{
    public class FactoryController : Controller
    {
        public IActionResult Index()
        {
            ActivityRepository activityRepository = new ActivityRepository();    
            IQueryable<ActivityData> activityData = activityRepository.GetAllActiveTask();
            ViewBag.ActivityData = activityData;

            return View();
        }
        public IActionResult AddDepartman()
        {
            return View();
        }

    }
}
