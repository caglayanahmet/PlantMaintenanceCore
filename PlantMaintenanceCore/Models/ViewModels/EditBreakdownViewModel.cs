using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc.Rendering;
using PlantMaintenanceCore.Models.DataModels;

namespace PlantMaintenanceCore.Models.ViewModels
{
    public class EditBreakdownViewModel:BreakdownViewModel
    {
        public IEnumerable<SelectListItem> Urgencies { get; set; }
        public IEnumerable<SelectListItem> PersonnelsRequesting { get; set; }
        public IEnumerable<SelectListItem> PersonnelsMaintenance { get; set; }
        public IEnumerable<SelectListItem> Machines { get; set; }
        public IEnumerable<SelectListItem> Plants { get; set; }
        public IEnumerable<SelectListItem> BreakdownTypes { get; set; }

        public EditBreakdownViewModel(BreakdownViewModel model)
        {
            Id = model.Id;
            Urgency = model.Urgency;
            PersonnelMaintenanceId = model.PersonnelMaintenanceId;
            PersonnelRequestingId = model.PersonnelRequestingId;
            MachineId = model.MachineId;
            BreakdownTypeId = model.BreakdownTypeId;
            DeclareTime = model.DeclareTime;
            IsActive = model.IsActive;
            IsDone = model.IsDone;
            DoneTime = model.DoneTime;
            Description = model.Description;
            PlantId = model.PlantId;
        }

        public EditBreakdownViewModel()
        {
        }
    }
}
