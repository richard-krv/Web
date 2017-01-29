using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCore.Models.InventoryViewModels
{
    public class SingletonDetailsViewModel
    {
        [Display(Name = "Inventory facade descriptor")]
        public string SingletonDescriptor { get; set; }
    }
}
