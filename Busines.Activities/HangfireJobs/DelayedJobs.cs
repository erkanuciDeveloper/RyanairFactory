using Business.Enumeration;
using Business.ServicesModel.HangfireJobs;
using Data.Daper.WorkerRepo;
using Data.Entity.Workers;
using Hangfire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Activities.HangfireJobs
{
    public static class DelayedJob
    {

        public static void DelayedJobrun(JobParameters jobs, double timePeriot)
        {
            //Delayed job

            var jobId = BackgroundJob.Schedule(() => ProcessDelayedJob(jobs), TimeSpan.FromHours(timePeriot));
            //var jobId = BackgroundJob.Schedule(() => ProcessDelayedJob(jobs), TimeSpan.FromMinutes(2));


        }

        public static void ProcessDelayedJob(JobParameters jobs)
        {
            var jobId = "";
            if (jobs.WorkerStatus == Convert.ToInt32(StatuType.Active))
            {
                Console.WriteLine("worker statusunu dinlenmeye  ve workere is tipine gore dinlenemye gonder");
                if (jobs.AktivityType == Convert.ToInt32(ActivityType.BuildComponent))
                {
                    //jobId = BackgroundJob.Schedule(() => ProcessDelayedJob(jobs), TimeSpan.FromMinutes(2));
                    jobId = BackgroundJob.Schedule(() => ProcessDelayedJob(jobs), TimeSpan.FromHours(2));
                }
                else
                {
                    //jobId = BackgroundJob.Schedule(() => ProcessDelayedJob(jobs), TimeSpan.FromMinutes(4));
                    jobId = BackgroundJob.Schedule(() => ProcessDelayedJob(jobs), TimeSpan.FromHours(4));
                }

            }
            else if (jobs.WorkerStatus == Convert.ToInt32(StatuType.Working))
            {
                WorkerRepository workerRepository = new WorkerRepository();
                Workers workersModel = workerRepository.Get(Convert.ToDecimal(jobs.WorkerId));
                workersModel.Status = Convert.ToInt32(StatuType.Rest);
                workerRepository.Update(workersModel);
                jobs.WorkerStatus = Convert.ToInt32(StatuType.Rest);

                if (jobs.AktivityType == Convert.ToInt32(ActivityType.BuildComponent))
                {

                    //jobId = BackgroundJob.Schedule(() => ProcessDelayedJob(jobs), TimeSpan.FromMinutes(2));
                   jobId = BackgroundJob.Schedule(() => ProcessDelayedJob(jobs), TimeSpan.FromHours(2));
                }
                else
                {
                    //jobId = BackgroundJob.Schedule(() => ProcessDelayedJob(jobs), TimeSpan.FromMinutes(4));
                    jobId = BackgroundJob.Schedule(() => ProcessDelayedJob(jobs), TimeSpan.FromHours(4));
                }




            }
            else
            {
                WorkerRepository workerRepository = new WorkerRepository();
                Workers workersModel = workerRepository.Get(Convert.ToDecimal(jobs.WorkerId));
                workersModel.Status = Convert.ToInt32(StatuType.Active);
                workerRepository.Update(workersModel);
            }

        }
    }
}
