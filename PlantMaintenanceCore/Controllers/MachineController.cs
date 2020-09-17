using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PlantMaintenanceCore.Models.ViewModels;
using PlantMaintenanceCore.Services;

namespace PlantMaintenanceCore.Controllers
{
    public class MachineController : Controller
    {

        private readonly PlantMaintenanceCoreService _service;

        public MachineController(PlantMaintenanceCoreService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var result = _service.GetMachineItems();
            var item = new DisplayMachineViewModel()
            {
                Items = result
            };
            return View(item);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var model = id != null
                ? new EditMachineViewModel(_service.GetMachineItem(id.Value))
                : new EditMachineViewModel();

            model.Plants = _service.GetPlantItems().Select(a => new SelectListItem(a.PlantName, a.Id.ToString()));
            return View(model);
        }

        [HttpPost]
        public IActionResult Save(EditMachineViewModel item)
        {
            if (ModelState.IsValid)
            {
                _service.AddUpdateMachine(item);
                return RedirectToAction("Index");
            }

            return RedirectToAction("Edit");
        }

        public IActionResult Delete(int id)
        {
            _service.DeleteMachine(id);
            return RedirectToAction("Index");
        }
    }
}