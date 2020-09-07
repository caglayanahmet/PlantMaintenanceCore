using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using PlantMaintenanceCore.Models.DataModels;

namespace PlantMaintenanceCore.Models.ViewModels
{
    public class PersonnelViewModel
    {
        public int? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Role { get; set; }
        public int Title { get; set; }
        public int Performance { get; set; }
        public bool IsActive { get; set; }

        public IEnumerable<SelectListItem> Roles { get; set; }
        public IEnumerable<SelectListItem> Titles { get; set; }
    }
}
