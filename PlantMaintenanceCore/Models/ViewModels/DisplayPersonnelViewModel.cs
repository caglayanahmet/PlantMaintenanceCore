using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantMaintenanceCore.Models.ViewModels
{
    public class DisplayPersonnelViewModel:PersonnelViewModel
    {
        public IEnumerable<DisplayPersonnelViewModelItem> Items { get; set; }
    }

    public class DisplayPersonnelViewModelItem
    {
        public int? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Role { get; set; }
        public string Title { get; set; }
        public int Performance { get; set; }
        public bool IsActive { get; set; }
    }
}
