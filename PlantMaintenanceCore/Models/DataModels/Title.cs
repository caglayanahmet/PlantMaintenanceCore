using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlantMaintenanceCore.Models.DataModels
{
    public class Title
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string TitleName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Personnel> Personnels { get; set; }
    }
}
