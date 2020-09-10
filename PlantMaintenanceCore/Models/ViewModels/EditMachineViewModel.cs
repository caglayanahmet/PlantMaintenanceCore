using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using PlantMaintenanceCore.Models.DataModels;

namespace PlantMaintenanceCore.Models.ViewModels
{
    public class EditMachineViewModel : MachineViewModel
    {
        public IEnumerable<SelectListItem> Plants { get; set; }

        public EditMachineViewModel(MachineViewModel model)
        {
            Id = model.Id;
            PlantId = model.PlantId;
            MachineName = model.MachineName;
            Description = model.Description;
            IsActive = model.IsActive;
        }

        public EditMachineViewModel()
        {
        }
    }


}
