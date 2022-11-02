using Dapper;

using Data.Daper.Repositories.Base;
using Data.Entity.Activities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Daper.WorkerRepo
{
    public class ActivityWorkerRepository : BaseRepository, IDataRepository<ActivityWorkerData>
    {
        public void Add(ActivityWorkerData entity)
        {
            throw new NotImplementedException();
        }
        public int AddreturnId(ActivityWorkerData entity)
        {
            string query = @"INSERT INTO [dbo].[ActivityWorkerData]
							   (
                               [WorkerId]				
							   ,[ActivityId]									
							   ,[CreaDate]			
							   )
                           VALUES
                               (                               
                               @WorkerId                                      
                               ,@ActivityId
                               ,@CreaDate                                                                  
                               )
                            SELECT CAST(SCOPE_IDENTITY() as int)";

            var lastId = _connection.ExecuteScalar<int>(query, entity);
            entity.Id = lastId;
            return lastId;
        }
        public void Delete(ActivityWorkerData entity)
        {
            throw new NotImplementedException();
        }

        public ActivityWorkerData Get(decimal id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ActivityWorkerData> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(ActivityWorkerData entity)
        {
            throw new NotImplementedException();
        }
    }
}
