﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantMaintenanceCore.Models.DataModels
{
    public class Breakdown
    {
        public int Id { get; set; }
        public DateTime DeclareTime { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }
        public DateTime DoneTime { get; set; }
        public bool IsActive { get; set; }
        public int UrgencyId { get; set; }
        public int PersonnelRequestingId { get; set; }
        public int PersonnelMaintenanceId { get; set; }
        public int MachineId { get; set; }
        public int BreakdownTypeId { get; set; }


        //public Urgency Urgency { get; set; }
        //public Personnel PersonnelRequesting { get; set; }
        //public Personnel PersonnelMaintenance { get; set; }
        //public Machine Machine { get; set; }
        //public BreakdownType BreakdownType { get; set; }
    }
}
