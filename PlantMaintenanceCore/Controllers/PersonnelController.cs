﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PlantMaintenanceCore.Controllers
{
    public class PersonnelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}