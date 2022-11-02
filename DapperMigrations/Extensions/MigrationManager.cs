using DapperMigrations.Migrations;
using FluentMigrator.Runner;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperMigrations.Extensions
{
	public static class MigrationManager
	{
		public static IHost MigrateDatabase(this IHost host)
		{
			using (var scope = host.Services.CreateScope())
			{
				var databaseService = scope.ServiceProvider.GetRequiredService<Database>();
				var migrationService = scope.ServiceProvider.GetRequiredService<IMigrationRunner>();

				try
				{
					databaseService.CreateDatabase("RyanairFactory");
					databaseService.CreateDatabase("HangfireActivityControl");

					migrationService.ListMigrations();
					migrationService.MigrateDown(20220310001);
					migrationService.MigrateDown(202210310002);
					migrationService.MigrateUp();
					//migrationService.MigrateUp(202210310001);



				}
				catch
				{
					//log errors or ...
					throw;
				}
			}

			return host;
		}
	}
}
