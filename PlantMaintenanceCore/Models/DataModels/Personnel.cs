using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantMaintenanceCore.Models.DataModels
{
    public class Personnel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string RoleId { get; set; }
        public int Performance { get; set; }
        public bool IsActive { get; set; }

        public Title Title { get; set; }
        public Role Role { get; set; }
    }
}
