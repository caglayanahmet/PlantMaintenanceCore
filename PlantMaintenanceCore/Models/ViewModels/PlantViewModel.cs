using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantMaintenanceCore.Models.ViewModels
{
    public class PlantViewModel
    {
        public int? Id { get; set; }
        public string PlantName { get; set; }
        public bool IsActive { get; set; }
    }
}
