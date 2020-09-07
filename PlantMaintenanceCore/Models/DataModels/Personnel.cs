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
        public int RoleId { get; set; }
        public int TitleId { get; set; }
        public int Performance { get; set; }
        public bool IsActive { get; set; }
    }
}
