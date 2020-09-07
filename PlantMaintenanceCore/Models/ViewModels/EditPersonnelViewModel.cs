using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using PlantMaintenanceCore.Models.DataModels;

namespace PlantMaintenanceCore.Models.ViewModels
{
    public class EditPersonnelViewModel:PersonnelViewModel
    {
        public IEnumerable<SelectListItem> Roles { get; set; }
        public IEnumerable<SelectListItem> Titles { get; set; }

        public EditPersonnelViewModel(PersonnelViewModel model)
        {
            Id = model.Id;
            FirstName = model.FirstName;
            LastName = model.LastName;
            DateOfBirth = model.DateOfBirth;
            Performance = model.Performance;
            Title = model.Title;
            Role = model.Role;
            IsActive = model.IsActive;
        }

        public EditPersonnelViewModel()
        {
        }
    }
}
