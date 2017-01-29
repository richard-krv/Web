using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCore.Services
{
    public class InventoryStateService : IInventoryStateService
    {
        public string GetInventoryStateDescriptor()
        {
            return GetHashCode().ToString();
        }
    }
}
