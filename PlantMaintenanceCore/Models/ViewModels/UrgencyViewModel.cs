using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlantMaintenanceCore.Models.ViewModels
{
    public class UrgencyViewModel
    {
        public int? Id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Urgency level field is required")]
        public string UrgencyLevel { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
