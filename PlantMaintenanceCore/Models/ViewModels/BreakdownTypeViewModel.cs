using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantMaintenanceCore.Models.ViewModels
{
    public class BreakdownTypeViewModel
    {
        public int? Id { get; set; }
        public string BreakdownTypeName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
