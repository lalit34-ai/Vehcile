using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using VEHCILE.Models;
using VEHCILE.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VEHCILE.Data;

namespace VEHCILE.Controllers
{
    [Actions]
    public class DriverController : Controller
    {
        private readonly IDriverRepository driverRepository;

        public DriverController(IDriverRepository driverRepository)
        {
            this.driverRepository = driverRepository;
        }

        public IActionResult Index()
        {
            var drivers = driverRepository.GetAllDrivers();
            return View(drivers);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Driver newdriver) //to add new car
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {
                bool isSaved = driverRepository.AddNewDriver(newdriver);
                ViewBag.isSaved = isSaved;
                return RedirectToAction("Index");
            }
        }

       
        public IActionResult DeleteDriver()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteDriver(string id, Driver deletedriver)
        {
            bool isSaved = driverRepository.DeleteDriver(id);
            ViewBag.inSaved = isSaved;
            return RedirectToAction("Index");
        }
    }
}

