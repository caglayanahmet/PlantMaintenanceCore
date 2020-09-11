using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PlantMaintenanceCore.Models.DataModels;

namespace PlantMaintenanceCore.Models.ViewModels
{
    public class DisplayBreakdownTypeViewModel
    {
        public IEnumerable<BreakdownTypeViewModel> Items { get; set; }
    }
}
