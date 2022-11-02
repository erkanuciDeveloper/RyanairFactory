using Busines.Model;
using Business.Activities.HangfireJobs;
using Business.Enumeration;
using Business.ServicesModel.HangfireJobs;
using Cronos;
using Data.Daper.Repositories.ActivityRepo;
using Data.Daper.WorkerRepo;
using Data.Entity.Activities;
using Data.Entity.Workers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Activities
{
    public class Helpers
    {

        public void InsertData(ActivityDetailsModel activityDetailsModel)
        {

            ActivityRepository activityRepository = new ActivityRepository();
   
            ActivityData activityDetailsCheck = new ActivityData()
            {
                ActivityName = activityDetailsModel.ActivityName,
                ActivityType = Convert.ToInt32(activityDetailsModel.ActivityTypeId),
                ActivityStarTime = activityDetailsModel.ActivityStarTime,
                ActivityEndTime = activityDetailsModel.ActivityEndTime,
                ActivityDetails = activityDetailsModel.ActivityDetails,
                //WorkerId = Convert.ToInt32(item),
                CreaDate = DateTime.Now,
                WorkerStatus = Convert.ToInt32(StatuType.Working),

            };
            var activityId = activityRepository.AddreturnId(activityDetailsCheck);
            foreach (var item in activityDetailsModel.WorkersId)
            {
                ActivityWorkerRepository activityWorkerRepository = new ActivityWorkerRepository();
                ActivityWorkerData activityWorkerData = new ActivityWorkerData()
                {
                    ActivityId = activityId,
                    WorkerId= Convert.ToInt32(item),
                    CreaDate = DateTime.Now,

                };
                activityWorkerRepository.AddreturnId(activityWorkerData);
                //workeri statusunun akticten calisiyora cek

                WorkerRepository workerRepository = new WorkerRepository();
                Workers workersModel = workerRepository.Get(Convert.ToDecimal(item));
                workersModel.Status = Convert.ToInt32(StatuType.Working);
                workerRepository.Update(workersModel);
                JobParameters jobParameters = new JobParameters
                {
                    JobId = activityId,
                    JobName = activityDetailsCheck.ActivityName,
                    AktivityName= activityDetailsCheck.ActivityName,
                    AktivityId = activityId,
                    WorkerId= Convert.ToInt32(item),
                    WorkerStatus = Convert.ToInt32(StatuType.Working),

                };      
                var worktime = (activityDetailsCheck.ActivityEndTime- activityDetailsCheck.ActivityStarTime).TotalHours;
                DelayedJob.DelayedJobrun(jobParameters, worktime);
            }
        }

    }
}
