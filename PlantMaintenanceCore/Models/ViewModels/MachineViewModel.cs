using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantMaintenanceCore.Models.ViewModels
{
    public class MachineViewModel
    {

        public int? Id { get; set; }
        public int PlantId { get; set; }
        public string MachineName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
