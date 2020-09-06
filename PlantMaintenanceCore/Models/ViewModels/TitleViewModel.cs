﻿using PlantMaintenanceCore.Models.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlantMaintenanceCore.Models.ViewModels
{
    public class TitleViewModel
    {
        public int? Id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Title Name")]
        public string TitleName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Personnel> Personnels { get; set; }
    }
}
