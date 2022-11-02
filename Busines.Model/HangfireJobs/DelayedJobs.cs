using Business.Enumeration;
using Hangfire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ServicesModel.HangfireJobs
{
    //public static class DelayedJob2
    //{

    //    public static void DelayedJobrun(JobParameters jobs, double timePeriot)
    //    {
    //        //Delayed job
         
    //       //var jobId = BackgroundJob.Schedule(() => ProcessDelayedJob(jobs), TimeSpan.FromHours(timePeriot));
    //        var jobId = BackgroundJob.Schedule(() => ProcessDelayedJob(jobs), TimeSpan.FromMinutes(2));
       

    //    }

    //    public static void ProcessDelayedJob(JobParameters jobs)
    //    {

    //        if (jobs.WorkerStatus== Convert.ToInt32(StatuType.Active))
    //        {
    //            Console.WriteLine("worker statusunu dinlenmeye  ve workere is tipine gore dinlenemye gonder");
    //            if (jobs.AktivityType== Convert.ToInt32(ActivityType.BuildComponent))
    //            {                   
    //                var jobId = BackgroundJob.Schedule(() => ProcessDelayedJob(jobs), TimeSpan.FromMinutes(2));
    //                //var jobId = BackgroundJob.Schedule(() => ProcessDelayedJob(jobs), TimeSpan.FromHours(2));
    //            }
    //            else
    //            {
    //                var jobId = BackgroundJob.Schedule(() => ProcessDelayedJob(jobs), TimeSpan.FromMinutes(4));
    //                //var jobId = BackgroundJob.Schedule(() => ProcessDelayedJob(jobs), TimeSpan.FromHours(4));
    //            }
             
    //        }       
    //        else if (jobs.WorkerStatus == Convert.ToInt32(StatuType.Working))
    //        {
    //            //WorkerRepository workerRepository = new WorkerRepository();
    //            //Workers workersModel = workerRepository.Get(Convert.ToDecimal(jobs.WorkerId));
    //            //workersModel.Status = 3;
    //            //workerRepository.Update(workersModel);




    //        }
    //        else
    //        {
    //            Console.WriteLine("worker resting...");
    //        }
        
    //    }
    //}
}
