using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc.Rendering;
using PlantMaintenanceCore.Models.DataModels;

namespace PlantMaintenanceCore.Models.ViewModels
{
    public class EditBreakdownViewModel:BreakdownViewModel
    {
        [Required]
        public IEnumerable<SelectListItem> Urgencies { get; set; }

        [Required(ErrorMessage = "Breakdown Type Name field is required")]
        public IEnumerable<SelectListItem> PersonnelsRequesting { get; set; }

        [Required]
        public IEnumerable<SelectListItem> PersonnelsMaintenance { get; set; }

        [Required]
        public IEnumerable<SelectListItem> Machines { get; set; }

        [Required]
        public IEnumerable<SelectListItem> Plants { get; set; }

        [Required]
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
