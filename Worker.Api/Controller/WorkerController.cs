using Data.Daper.WorkerRepo;
using Data.Entity.Workers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Worker.Api.Controller
{
    public class WorkerController : ControllerBase
    {

        private readonly ILogger<WorkerController> _logger;

        public WorkerController(ILogger<WorkerController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "Successfully reached - Fixity.Product.Api";
        }

        [Route("UpdateWorkerStatus")]
        [HttpGet]
        public void UpdateWorkerStatus(decimal IdWorker, int status)
        {
            WorkerRepository workerRepository = new WorkerRepository();
            Workers workersModel = workerRepository.Get(Convert.ToDecimal(IdWorker));
            workersModel.Status = status;
            workerRepository.Update(workersModel);
         
        }
    }
}
