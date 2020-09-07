using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using PlantMaintenanceCore.Models.ViewModels;
using PlantMaintenanceCore.Services;

namespace PlantMaintenanceCore.Controllers
{
    public class PersonnelController : Controller
    {
        private readonly PlantMaintenanceCoreService _service;

        public PersonnelController(PlantMaintenanceCoreService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var result = _service.GetPersonnelItems();
            var item = new DisplayPersonnelViewModel
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
                var item = _service.GetPersonnelItem(id.Value);
                return View(item);
            }
            return View();
        }

        [HttpPost]
        public IActionResult Save(PersonnelViewModel item)
        {
            if (ModelState.IsValid)
            {
                _service.AddUpdatePersonnel(item);
                return RedirectToAction("Index");
            }

            return RedirectToAction("Edit");
        }
    }
}