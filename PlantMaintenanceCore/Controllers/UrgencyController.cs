using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlantMaintenanceCore.Models.ViewModels;
using PlantMaintenanceCore.Services;

namespace PlantMaintenanceCore.Controllers
{
    public class UrgencyController : Controller
    {
        private readonly PlantMaintenanceCoreService _service;

        public UrgencyController(PlantMaintenanceCoreService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var result = _service.GetUrgencyItems();
            var item = new DisplayUrgencyViewModel
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
                var item = _service.GetUrgencyItem(id.Value);
                return View(item);
            }
            return View();
        }

        [HttpPost]
        public IActionResult Save(UrgencyViewModel item)
        {
            if (ModelState.IsValid)
            {
                _service.AddUpdateUrgency(item);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Edit");
        }

        public IActionResult Delete(int id)
        {
            _service.DeleteUrgency(id);
            return RedirectToAction("Index");
        }
    }
}