using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlantMaintenanceCore.Models.ViewModels;
using PlantMaintenanceCore.Services;

namespace PlantMaintenanceCore.Controllers
{
    public class PlantController : Controller
    {
        private readonly PlantMaintenanceCoreService _service;

        public PlantController(PlantMaintenanceCoreService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var result = _service.GetPlantItems();
            var item = new DisplayPlantViewModel
            {
                Items = result
            };
            return View(item);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id!=null)
            {
                var item = _service.GetPlantItem(id.Value);
                return View(item);
            }

            return View();
        }

        [HttpPost]
        public IActionResult Save(PlantViewModel item)
        {
            if (ModelState.IsValid)
            {
                _service.AddUpdatePlant(item);
                return RedirectToAction("Index");
            }

            return RedirectToAction("Edit");
        }
    }
}