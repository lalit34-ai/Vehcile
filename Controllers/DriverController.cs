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
        private readonly IData data1;
        public DriverController(IData _data1)
        {
            data1 = _data1;
        }

        public IActionResult Index()
        {
            var list122 = data1.GetAllDrivers();
            return View(list122);
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
            bool inSaved = data1.AddNewDriver(newdriver);
            ViewBag.inSaved = inSaved;
            return RedirectToAction("Index");
        }}
        // public IActionResult UpdateDriver()
        // {
        //     return View();
        // }
        // [HttpPost]
        // public IActionResult UpdateDriver(string id, Driver updatedriver)
        // {
        //     Console.WriteLine("Reached");
        //     bool sq1saved = data1.UpDriver(id, updatedriver);
        //     ViewBag.inSaved = sq1saved;
        //     return RedirectToAction("Index");
        // }

        public IActionResult DeleteDriver()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DeleteDriver(string id, Driver deletedriver)
        {
            bool s11saved = data1.DeDriver(id, deletedriver);
            ViewBag.inSaved = s11saved;
            return RedirectToAction("Index");
        }
    }

}

