using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperMigrations.Extensions
{
    [Migration(202106280001)]
    public class InitialTables_202210310001 : Migration
    {
        public override void Down()
        {

            Delete.Table("ActivityData");
            Delete.Table("Workers");
            Delete.Table("StatusType");
            Delete.Table("ActivityWorkerData");



        }

        public override void Up()
        {

            Create.Table("Workers")
                .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("WorkerName").AsString(100).NotNullable()
                .WithColumn("Status").AsInt32()
                .WithColumn("CreaDate").AsDateTime().NotNullable();

            Create.Table("ActivityData")
                .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("ActivityName").AsString(100).NotNullable()
                .WithColumn("ActivityType").AsBoolean()
                .WithColumn("ActivityStarTime").AsDateTime().NotNullable()
                .WithColumn("ActivityEndTime").AsDateTime().NotNullable()
                .WithColumn("CreaDate").AsDateTime().NotNullable()
                //.WithColumn("WorkerId").AsInt32().NotNullable()
                //.WithColumn("WorkerId").AsInt32().NotNullable().ForeignKey("Workers", "Id")
                .WithColumn("ActivityDetails").AsString(100).NotNullable();



            Create.Table("StatusType")
                .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("StatusName").AsString(100).NotNullable()
                .WithColumn("CreaDate").AsDateTime().NotNullable();


            Create.Table("ActivityWorkerData")
                .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("WorkerId").AsInt32()
                .WithColumn("ActivityId").AsInt32()
                .WithColumn("CreaDate").AsDateTime().NotNullable();


        }
    }
}
