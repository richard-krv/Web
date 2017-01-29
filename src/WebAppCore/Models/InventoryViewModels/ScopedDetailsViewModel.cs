using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCore.Models.InventoryViewModels
{
    public class ScopedDetailsViewModel
    {
        [Display(Name = "Current request descriptor")]
        public string ScopedDescriptor { get; set; }
    }
}
