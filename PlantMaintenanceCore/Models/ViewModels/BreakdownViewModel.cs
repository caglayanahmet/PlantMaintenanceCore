using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantMaintenanceCore.Models.ViewModels
{
    public class BreakdownViewModel
    {
        public int? Id { get; set; }
        public DateTime DeclareTime { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }
        public DateTime DoneTime { get; set; }
        public bool IsActive { get; set; }
        public int Urgency { get; set; }
        public int PersonnelRequestingId { get; set; }
        public int PersonnelMaintenanceId { get; set; }
        public int MachineId { get; set; }
        public int BreakdownTypeId { get; set; }
        public int PlantId { get; set; }
    }
}
