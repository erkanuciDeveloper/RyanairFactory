using Data.Daper.WorkerRepo;
using Data.Entity.Workers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ryanair.UI.Web.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddEmployee()
        {
            return View();
        }

        public IActionResult ManageEmployee()
        {
            WorkerRepository workerRepository = new WorkerRepository();    
            IQueryable<Workers> workers = workerRepository.GetAllWorkers(); 
            ViewBag.AllWorkers = workers;
            return View();
    
        }
    }
}
