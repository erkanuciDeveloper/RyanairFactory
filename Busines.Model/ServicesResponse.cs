using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ServicesModel
{
    [Serializable]
    public class ServicesResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServicesResponse"/> class.
        /// </summary>
        public ServicesResponse()
        {
            IsSuccess = true;
            Message = "";
            DataContent = "";

        }

        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public string DataContent { get; set; }
    }
}
