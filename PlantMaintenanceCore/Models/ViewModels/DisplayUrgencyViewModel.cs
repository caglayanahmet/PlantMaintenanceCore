using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantMaintenanceCore.Models.ViewModels
{
    public class DisplayUrgencyViewModel
    {
        public IEnumerable<UrgencyViewModel> Items { get; set; }
    }
}
