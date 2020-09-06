using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantMaintenanceCore.Models.DataModels
{
    public class Plant
    {
        public int Id { get; set; }
        public string PlantName { get; set; }
        public bool IsActive { get; set; }
    }
}
