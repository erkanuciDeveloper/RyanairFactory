using Dapper;
using Data.Daper.Repositories.Base;
using Data.Entity.Workers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Daper.WorkerRepo
{
    public class WorkerRepository : BaseRepository, IDataRepository<Workers>
    {
        public void Add(Workers entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Workers entity)
        {
            throw new NotImplementedException();
        }

        public Workers Get(decimal id)
        {
            using (IDbConnection dbConnection = _connection)
            {
                string query = $"Select *from Workers where Id=@Id";

                return dbConnection.QueryFirstOrDefault<Workers>(query, new
                {
                    @Id = id
                });

            }
        }

        public IEnumerable<Workers> GetAll()
        {
            using (IDbConnection dbConnection = _connection)
            {
                string query = $"SELECT *  FROM [RyanairFactory].[dbo].[Workers]";

                return dbConnection.Query<Workers>(query).AsQueryable();

            }
        }

        public IQueryable<Workers> GetAllActiveWorkers()
        {
            using (IDbConnection dbConnection = _connection)
            {
                string query = $"SELECT *  FROM [RyanairFactory].[dbo].[Workers] where Status = 1";

                return dbConnection.Query<Workers>(query).AsQueryable();

            }

        }
        public IQueryable<Workers> GetAllWorkers()
        {
            using (IDbConnection dbConnection = _connection)
            {
                string query = $"SELECT *  FROM [RyanairFactory].[dbo].[Workers]";

                return dbConnection.Query<Workers>(query).AsQueryable();

            }

        }
        public void Update(Workers entity)
        {
            using (IDbConnection dbConnection = _connection)
            {
                string query = @"UPDATE [dbo].[Workers]
                    SET[WorkerName] = @WorkerName
                      ,[Status] = @Status                                      
                      
                WHERE[Id] = @Id";

                _connection.Execute(query, entity);

            }

        }

    }
}
