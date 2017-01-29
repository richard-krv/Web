using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCore.Models.InventoryViewModels
{
    public class TransientDetailsViewModel
    {
        [Display(Name = "Inventory state descriptor")]
        public string TransientDescriptor { get; set; }
    }
}
