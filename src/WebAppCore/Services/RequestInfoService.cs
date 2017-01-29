using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCore.Services
{
    public class RequestInfoService : IRequestInfoService
    {
        public string GetRequestDescriptor()
        {
            return GetHashCode().ToString();
        }
    }
}
