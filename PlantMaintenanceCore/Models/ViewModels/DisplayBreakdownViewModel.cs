using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace PlantMaintenanceCore.Models.ViewModels
{
    public class DisplayBreakdownViewModel:BreakdownViewModel
    {
        public IEnumerable<DisplayBreakdownTypeViewModelItem> Items { get; set; }
    }

    public class DisplayBreakdownTypeViewModelItem
    {
        public int? Id { get; set; }
        public DateTime DeclareTime { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }
        public DateTime DoneTime { get; set; }
        public bool IsActive { get; set; }
        public string Urgency { get; set; }
        public string PersonnelRequesting { get; set; }
        public string PersonnelMaintenance { get; set; }
        public string Machine { get; set; }
        public string Plant { get; set; }
        public string BreakdownType { get; set; }
    }
}
