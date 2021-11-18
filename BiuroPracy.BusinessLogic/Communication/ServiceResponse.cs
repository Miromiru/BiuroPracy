using System;
using System.Collections.Generic;
using System.Text;

namespace BiuroPracy.BusinessLogic.Communication
{
    public class ServiceResponse
    {
        public bool Success { get; set; }
        public string Errors { get; set; }

        public ServiceResponse()
        {
            Success = true;
        }
    }
}
