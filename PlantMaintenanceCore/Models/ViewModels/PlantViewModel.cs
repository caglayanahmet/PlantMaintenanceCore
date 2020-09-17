using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlantMaintenanceCore.Models.ViewModels
{
    public class PlantViewModel
    {
        public int? Id { get; set; }

        [Required]
        [StringLength(50)]
        public string PlantName { get; set; }
        public bool IsActive { get; set; }
    }
}
