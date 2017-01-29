using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppCore.Models.InventoryViewModels;

namespace WebAppCore.Services
{
    public class InventoryFacadeService : IInventoryFacadeService
    {
        public TransientDetailsViewModel GetTransientDetailsVM(IInventoryStateService invState)
        {
            var detailsVm = new TransientDetailsViewModel();
            detailsVm.TransientDescriptor = invState.GetInventoryStateDescriptor();
            return detailsVm;
        }

        public ScopedDetailsViewModel GetScopedDetailsVM(IRequestInfoService rInfo)
        {
            var scDet = new ScopedDetailsViewModel();
            scDet.ScopedDescriptor = rInfo.GetRequestDescriptor();
            return scDet;
        }

        public SingletonDetailsViewModel GetSingletonDetailsVM()
        {
            var stDet = new SingletonDetailsViewModel();
            stDet.SingletonDescriptor = this.GetInventoryFacadeDescriptor();
            return stDet;
        }

        public string GetInventoryFacadeDescriptor()
        {
            return GetHashCode().ToString();
        }
    }
}
