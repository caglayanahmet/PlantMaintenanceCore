using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using PlantMaintenanceCore.Models.DataModels;

namespace PlantMaintenanceCore.Models.ViewModels
{
    public class EditPersonnelViewModel:PersonnelViewModel
    {
        [Required]
        public IEnumerable<SelectListItem> Roles { get; set; }

        [Required]
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
