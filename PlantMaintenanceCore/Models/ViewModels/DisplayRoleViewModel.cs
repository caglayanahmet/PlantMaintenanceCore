using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PlantMaintenanceCore.Models.DataModels;

namespace PlantMaintenanceCore.Models.ViewModels
{
    public class DisplayRoleViewModel
    {
        public IEnumerable<RoleViewModel> Items { get; set; }
    }
}
