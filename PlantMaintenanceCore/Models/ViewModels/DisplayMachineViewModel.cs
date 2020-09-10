using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantMaintenanceCore.Models.ViewModels
{
    public class DisplayMachineViewModel
    {
        public IEnumerable<DisplayMachineViewModelItem> Items { get; set; }
    }

    public class DisplayMachineViewModelItem
    {
        public int? Id { get; set; }
        public string Plant { get; set; }
        public string MachineName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }


    }
}
