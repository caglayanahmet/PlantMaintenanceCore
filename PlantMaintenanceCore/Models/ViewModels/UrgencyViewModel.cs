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

        [Required]
        [StringLength(50)]
        [Display(Name = "Urgency Level Name")]
        public string UrgencyLevel { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
