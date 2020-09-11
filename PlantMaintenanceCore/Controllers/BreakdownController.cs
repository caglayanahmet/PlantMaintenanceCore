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
    public class BreakdownController : Controller
    {
        private readonly PlantMaintenanceCoreService _service;

        public BreakdownController(PlantMaintenanceCoreService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var result = _service.GetBreakdownItems();
            var item = new DisplayBreakdownViewModel()
            {
                Items = result
            };
            return View(item);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var model = id != null
                ? new EditBreakdownViewModel(_service.GetBreakdownItem(id.Value))
                : new EditBreakdownViewModel();

            model.BreakdownTypes = _service.GetBreakdownTypeItems().Select(x => new SelectListItem(x.BreakdownTypeName, x.Id.ToString()));
            model.Machines = _service.GetMachineItems().Select(x => new SelectListItem(x.MachineName, x.Id.ToString()));
            model.PersonnelsRequesting = _service.GetPersonnelItems()
                .Select(x => new SelectListItem(x.FirstName + " " + x.LastName, x.Id.ToString()));
            model.PersonnelsMaintenance = _service.GetPersonnelItems()
                .Select(x => new SelectListItem(x.FirstName + " " + x.LastName, x.Id.ToString()));
            model.Urgencies = _service.GetUrgencyItems()
                .Select(x => new SelectListItem(x.UrgencyLevel, x.Id.ToString())); 
            model.Plants = _service.GetPlantItems()
                .Select(x => new SelectListItem(x.PlantName, x.Id.ToString()));

            return View(model);
        }

        [HttpPost]
        public IActionResult Save(EditBreakdownViewModel model)
        {
            if (ModelState.IsValid)
            {
                _service.AddUpdateBreakdown(model);
                return RedirectToAction("Index");
            }

            return RedirectToAction("Edit");
        }
    }
}