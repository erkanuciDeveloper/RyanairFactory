using Hangfire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ServicesModel.HangfireJobs
{
    public static class RecurringJobs
    {

        public static void RecurringJobsrun(JobParameters jobs, string timePeriot)
        {
            //Recurring job

            RecurringJob.AddOrUpdate(jobs.JobName, () => ProcessRecurringJob(jobs), timePeriot, TimeZoneInfo.Local);


            //RecurringJob.AddOrUpdate(jobs.JobName, () => Debug.Write("Powerful!"), timePeriot);

        }

        public static void ProcessRecurringJob(JobParameters jobs)
        {
            try
            {

    


            }
            catch (Exception ex)
            {

                throw ex;
            }

            //Console.WriteLine("Job Name" +jobs.JobName +""+ "Job Id" +jobs.JobId);
        }
    }
}
