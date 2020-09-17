using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            var model = id != null
                ? new EditPersonnelViewModel(_service.GetPersonnelItem(id.Value))
                : new EditPersonnelViewModel();

            model.Roles = _service.GetRoleItems().Select(a => new SelectListItem(a.RoleName, a.Id.ToString()));
            model.Titles = _service.GetTitleItems().Select(a => new SelectListItem(a.TitleName, a.Id.ToString()));
            return View(model);
        }

        [HttpPost]
        public IActionResult Save(EditPersonnelViewModel item)
        {
            if (ModelState.IsValid)
            {
                _service.AddUpdatePersonnel(item);
                return RedirectToAction("Index");
            }

            return RedirectToAction("Edit");
        }

        public IActionResult Delete(int id)
        {
            _service.DeletePersonnel(id);
            return RedirectToAction("Index");
        }
    }
}