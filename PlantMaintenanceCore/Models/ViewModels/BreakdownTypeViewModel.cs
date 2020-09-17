using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlantMaintenanceCore.Models.ViewModels
{
    public class BreakdownTypeViewModel
    {
        public int? Id { get; set; }

        [Display(Name = "Breakdown Type Name")]
        [StringLength(50)]
        [Required(ErrorMessage = "Breakdown Type Name field is required")]
        public string BreakdownTypeName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
