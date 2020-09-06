using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlantMaintenanceCore.Models.ViewModels;
using PlantMaintenanceCore.Services;

namespace PlantMaintenanceCore.Controllers
{
    public class RoleController : Controller
    {
        private readonly PlantMaintenanceCoreService _service;

        public RoleController(PlantMaintenanceCoreService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var result = _service.GetRoleItems();
            var item = new DisplayRoleViewModel
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
                var item = _service.GetRoleItem(id.Value);
                return View(item);
            }

            return View();
        }

        [HttpPost]
        public IActionResult Save(RoleViewModel item)
        {
            if (ModelState.IsValid)
            {
                _service.AddUpdateRole(item);
                return RedirectToAction("Index");
            }

            return RedirectToAction("Edit");
        }
    }
}