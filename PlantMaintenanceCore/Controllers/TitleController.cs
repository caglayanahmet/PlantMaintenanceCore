using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlantMaintenanceCore.Models.ViewModels;
using PlantMaintenanceCore.Services;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PlantMaintenanceCore.Controllers
{
    public class TitleController : Controller
    {
        private readonly PlantMaintenanceCoreService _service;

        public TitleController(PlantMaintenanceCoreService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var result = _service.GetTitleItems();
            var item = new DisplayTitleViewModel
            {
                Items = result
            };
            return View(item);
        }
    }
}