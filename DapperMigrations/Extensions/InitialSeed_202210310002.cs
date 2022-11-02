using DapperMigrations.Entities;
using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperMigrations.Extensions
{
    [Migration(202106280002)]
    public class InitialSeed_202210310002 : Migration
    {
        public override void Down()
        {
            Delete.FromTable("ActivityData")
                .Row(new ActivityData
                {

                    ActivityName = "Activity 1",
                    ActivityType = 1,
                    ActivityStarTime = DateTime.Now,
                    ActivityEndTime = DateTime.Now.AddDays(2),
                    CreaDate = DateTime.Now,
                    //WorkerId = 1,
                    ActivityDetails = "Summery",
                });
            Delete.FromTable("Workers")
                .Row(new WorkerData
                {

                    WorkerName = "A worker",
                    Status = 1,
                    CreaDate = DateTime.Now,

                }).Row(new WorkerData
                {

                    WorkerName = "B worker",
                    Status = 1,
                    CreaDate = DateTime.Now,

                }).Row(new WorkerData
                {

                    WorkerName = "C worker",
                    Status = 1,
                    CreaDate = DateTime.Now,

                }).Row(new WorkerData
                {

                    WorkerName = "D worker",
                    Status = 1,
                    CreaDate = DateTime.Now,

                }).Row(new WorkerData
                {

                    WorkerName = "E worker",
                    Status = 1,
                    CreaDate = DateTime.Now,

                });

            Delete.FromTable("StatusType")
             .Row(new StatusType
             {

                 StatusName = "Aktif",
                 CreaDate = DateTime.Now,

             }).Row(new StatusType
             {

                 StatusName = "Working",
                 CreaDate = DateTime.Now,

             }).Row(new StatusType
             {

                 StatusName = "Resting",
                 CreaDate = DateTime.Now,

             });

        }

        public override void Up()
        {
            Insert.IntoTable("Workers")
               .Row(new WorkerData
               {

                   WorkerName = "A worker",
                   Status = 1,
                   CreaDate = DateTime.Now,

               }).Row(new WorkerData
               {

                   WorkerName = "B worker",
                   Status = 1,
                   CreaDate = DateTime.Now,

               }).Row(new WorkerData
               {

                   WorkerName = "C worker",
                   Status = 1,
                   CreaDate = DateTime.Now,

               }).Row(new WorkerData
               {

                   WorkerName = "D worker",
                   Status = 1,
                   CreaDate = DateTime.Now,

               }).Row(new WorkerData
               {

                   WorkerName = "E worker",
                   Status = 1,
                   CreaDate = DateTime.Now,

               });

            Insert.IntoTable("ActivityData")
             .Row(new ActivityData
             {
                 ActivityName = "Activity 1",
                 ActivityType = 1,
                 ActivityStarTime = DateTime.Now,
                 ActivityEndTime = DateTime.Now.AddDays(2),
                 CreaDate = DateTime.Now,
                 //WorkerId = 1,
                 ActivityDetails = "Summery",
             });

            Insert.IntoTable("StatusType")
               .Row(new StatusType
               {

                   StatusName = "Aktif",
                   CreaDate = DateTime.Now,

               }).Row(new StatusType
               {

                   StatusName = "Working",
                   CreaDate = DateTime.Now,

               }).Row(new StatusType
               {

                   StatusName = "Resting",
                   CreaDate = DateTime.Now,

               });

        }
    }
}
