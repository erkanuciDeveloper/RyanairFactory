
using Busines.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Worker
{
    public interface IWorker
    {

        void Work(List<WorkersModel> worker);

        void Resting(List<WorkersModel> worker);

    }
}

