using Data.Daper.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using Data.Entity.Activities;

namespace Data.Daper.Repositories.ActivityRepo
{
    public class ActivityRepository : BaseRepository, IDataRepository<ActivityData>
    {

        public void Add(ActivityData entity)
        {
            string query = @"INSERT INTO [dbo].[ActivityData]
							   (
                               [ActivityName]				
							   ,[ActivityType]							
							   ,[ActivityStarTime]							
							   ,[ActivityEndTime]							
							   ,[CreaDate]							
							   ,[ActivityDetails]							
							   )
                           VALUES
                               (
                               
                               @ActivityName                                      
                               ,@ActivityType
                               ,@ActivityStarTime
                               ,@ActivityEndTime
                               ,@CreaDate                                                               
                               ,@ActivityDetails                                                   
                               )
                            SELECT CAST(SCOPE_IDENTITY() as int)";

            var lastId = _connection.ExecuteScalar<int>(query, entity);
        
        }

        public int AddreturnId(ActivityData entity)
        {
            string query = @"INSERT INTO [dbo].[ActivityData]
							   (
                               [ActivityName]				
							   ,[ActivityType]							
							   ,[ActivityStarTime]							
							   ,[ActivityEndTime]							
							   ,[CreaDate]	
							   ,[ActivityDetails]							
							   )
                           VALUES
                               (
                               
                               @ActivityName                                      
                               ,@ActivityType
                               ,@ActivityStarTime
                               ,@ActivityEndTime
                               ,@CreaDate                                                          
                               ,@ActivityDetails                                                   
                               )
                            SELECT CAST(SCOPE_IDENTITY() as int)";

            var lastId = _connection.ExecuteScalar<int>(query, entity);
            entity.Id = lastId;
            return lastId;
        }

        public void Delete(ActivityData entity)
        {
            throw new NotImplementedException();
        }
        public IQueryable<ActivityData> GetAllActiveTask()
        {
            using (IDbConnection dbConnection = _connection)
            {
                string query = $"SELECT * FROM [RyanairFactory].[dbo].[ActivityData] where ActivityType = 1";

                return dbConnection.Query<ActivityData>(query).AsQueryable();

            }

        }
        public ActivityData Get(decimal id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ActivityData> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(ActivityData entity)
        {
            throw new NotImplementedException();
        }
    }
}
