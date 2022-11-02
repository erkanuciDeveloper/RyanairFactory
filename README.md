---Ryanair Factory ---

This project was made for the case study of Ryanair company.

In order for the project to work and for the hanfire service to be up and running, the DapperMigrations project must be run first.
The project of the DapperMigrations Project creates the database and seed data. In addition, it will help the hangfire service stand up service.


When you select one or more workers according to the activity type and save the activity, the activity will be created and the background service will manage the status of the relevant workers by checking the activity duration.

You can see only active workers in the main table. In this way, the conflict of workers will be eliminated.

If any worker is running or at rest, it is not displayed on this page.
The worker can be viewed in this table after the work and rest period is over.

Hangfire service will monitor workers according to Activity duration and Activity type and update their Status.

After a worker job is finished, it will go to rest according to the Activity type and then it will be active again.

The project was written according to solid principles.

It was designed as a layered architecture. Dapper used as framework

MSSQL was used as database. 

Technologies used in the related study:
1. Programming language c#
2. .Netcore 5.0
3. Hangfire background processing
5. MSSQL Database
6. Css
7. Html
8. Jqery
9. Javascirp



MSSQL database is used. In order for this project to work, DB connection must be made in the local environment or over the server.
Specified in ConnectionString as below.
   "ConnectionStrings": {
    "DbConnectionString": "Server=(localdb)\\erkan;Database=RyanairFactory;Integrated Security=SSPI;",
    "HangfireConnection": "Server=(localdb)\\erkan;Database=HangfireActivityControl;Integrated Security=SSPI;"


},

Working Process of the Project:

1. In order for the Migrations and Seed dastas of the project to be created, the DapperMigrations project must be run first.
2. When the Dapper project is running, it will create it in the hangfire database.
3. Ryanair.UI.Webweb project will need to get up and running


Completed Cases;

1. Creating an activity
2. Displaying the activity list
3. Viewing the status of the workers
5. Prevent the clash of workers










