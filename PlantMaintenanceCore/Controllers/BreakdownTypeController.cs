using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlantMaintenanceCore.Models.ViewModels;
using PlantMaintenanceCore.Services;

namespace PlantMaintenanceCore.Controllers
{
    public class BreakdownTypeController : Controller
    {
        private readonly PlantMaintenanceCoreService _service;

        public BreakdownTypeController(PlantMaintenanceCoreService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var result = _service.GetBreakdownTypeItems();
            var item = new DisplayBreakdownTypeViewModel()
            {
                Items = result
            };
            return View(item);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id != null)
            {
                var item = _service.GetBreakdownTypeItem(id.Value);
                return View(item);
            }

            return View();
        }

        [HttpPost]
        public IActionResult Save(BreakdownTypeViewModel item)
        {
            if (ModelState.IsValid)
            {
                _service.AddUpdateBreakdownType(item);
                RedirectToAction("Index");
            }

            return RedirectToAction("Edit");
        }

        public IActionResult Delete(int id)
        {
            _service.DeleteBreakdownType(id);
            return RedirectToAction("Index");
        }
    }
}