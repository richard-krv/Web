using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppCore.Models.InventoryViewModels;

namespace WebAppCore.Services
{
    // one instance throughout the entire request
    public interface IInventoryFacadeService
    {
        string GetInventoryFacadeDescriptor();

        TransientDetailsViewModel GetTransientDetailsVM(IInventoryStateService invState);
        ScopedDetailsViewModel GetScopedDetailsVM(IRequestInfoService rInfo);
        SingletonDetailsViewModel GetSingletonDetailsVM();
    }
}
