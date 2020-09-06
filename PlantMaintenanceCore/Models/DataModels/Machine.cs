using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantMaintenanceCore.Models.DataModels
{
    public class Machine
    {
        public int Id { get; set; }
        public int PlantId { get; set; }
        public string MachineName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
