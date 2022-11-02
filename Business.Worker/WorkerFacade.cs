using Busines.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Worker
{
    public class WorkerFacade
    {
        private readonly IWorker _iworker;
        public WorkerFacade(IWorker iworker)
        {
            this._iworker = iworker;
        }

        public void StartWorkerOperation(List<WorkersModel> workers)
        {
            _iworker.Work(workers);
        }

        public void StopWorkerOperatio(List<WorkersModel> workers)
        {
            _iworker.Resting(workers);
        }
    }
}
