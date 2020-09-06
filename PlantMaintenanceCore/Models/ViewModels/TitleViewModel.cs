using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PlantMaintenanceCore.Models.DataModels;

namespace PlantMaintenanceCore.Models.ViewModels
{
    public class TitleViewModel
    {
        public int Id { get; set; }
        public string TitleName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Personnel> Personnels { get; set; }
    }
}
