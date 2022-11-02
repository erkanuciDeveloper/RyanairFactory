using Busines.Activities;
using Busines.Model;
using Business.Activities;
using Business.Enumeration;
using Business.ServicesModel;
using Business.ServicesModel.HangfireJobs;
using Business.Worker;
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
    public class ActivitiesManagementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ActivitiesRegister()
        {
            WorkerRepository workerRepository = new WorkerRepository();
            ActivityRepository activityRepository = new ActivityRepository();
            IQueryable<Workers> workers = workerRepository.GetAllActiveWorkers();
            IQueryable<ActivityData> activityData = activityRepository.GetAllActiveTask();
            ViewBag.ActivityData = activityData;
            ViewBag.Workers = workers;
            return View();
        }
        [HttpPost]
        public JsonResult ActivitiesRegister([FromBody] ActivityDetailsModel activityDetailsModel)
        {
            ServicesResponse servicesResponse = new ServicesResponse();
            try
            {
                if (ModelState.IsValid)
                {

                    if (Convert.ToInt32(activityDetailsModel.ActivityTypeId) == Convert.ToInt32(ActivityType.BuildComponent))
                    {
                        ActivitiesFacade activitiesFacade = new ActivitiesFacade(new Activity());
                        activitiesFacade.BuildComponentOperation(activityDetailsModel);
                        var timer =activityDetailsModel.ActivityEndTime.Minute - activityDetailsModel.ActivityStarTime.Minute;
                        WorkerFacade workerFacade = new WorkerFacade(new Worker());
                        workerFacade.StartWorkerOperation(activityDetailsModel.Workers);
                        //timer
                        workerFacade.StopWorkerOperatio(activityDetailsModel.Workers);

                    }
                    else
                    {

                        ActivitiesFacade activitiesFacade = new ActivitiesFacade(new Activity());
                        activitiesFacade.BuildMachineOperation(activityDetailsModel);
                        WorkerFacade workerFacade = new WorkerFacade(new Worker());
                        workerFacade.StartWorkerOperation(activityDetailsModel.Workers);
                        //timer
                        workerFacade.StopWorkerOperatio(activityDetailsModel.Workers);
                    }
               
                }

                servicesResponse.IsSuccess = true;
                servicesResponse.Message = "Registration Successful";

            }
            catch (Exception ex)
            {
                servicesResponse.IsSuccess = false;
                servicesResponse.Message = ex.Message;
                throw;
            }
            return Json(servicesResponse);
        }
        public IActionResult ActivitiesModify()
        {
            ActivityRepository activityRepository = new ActivityRepository();
            IQueryable<ActivityData> activityData = activityRepository.GetAllActiveTask();
            ViewBag.ActivityData = activityData;

            return View();
        }
    }
}
