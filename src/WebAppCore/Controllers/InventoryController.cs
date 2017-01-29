using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppCore.Services;
using WebAppCore.Models.InventoryViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAppCore.Controllers
{
    public class InventoryController : Controller
    {
        IInventoryFacadeService singletonService;
        IRequestInfoService scopedService;
        IRequestInfoService scopedService2;
        IInventoryStateService transientService;
        IInventoryStateService transientService2;
        public InventoryController(IInventoryFacadeService invFc, 
            IRequestInfoService rqInfo, IRequestInfoService rqInfo2,
            IInventoryStateService invSt, IInventoryStateService invSt2)
        {
            singletonService = invFc;
            scopedService = rqInfo;
            scopedService2 = rqInfo2;
            transientService = invSt;
            transientService2 = invSt2;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewData["SingletonServiceData"] = singletonService.GetSingletonDetailsVM();
            ViewData["ScopedServiceData"] = singletonService.GetScopedDetailsVM(scopedService);
            ViewData["ScopedServiceData2"] = singletonService.GetScopedDetailsVM(scopedService2);
            ViewData["TransientServiceData"] = singletonService.GetTransientDetailsVM(transientService);
            ViewData["TransientServiceData2"] = singletonService.GetTransientDetailsVM(transientService2);
            return View();
        }
    }
}
