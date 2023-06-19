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
    public class BusController : Controller
    {
        private ApplicationDbContext _database;
        public BusController(ApplicationDbContext database)
        {
            _database = database;
        }
        public IActionResult Index()
        {
            var list2 = _database.Buses.ToList();
            return View(list2);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Bus newbus)
        {
            _database.Buses.Add(newbus);
            _database.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult UpdateBus(string id)
        {
            var update = _database.Buses.Find(id);
            _database.SaveChanges();
            return View(update);
        }
        [HttpPost]
        public IActionResult UpdateBus(Bus updatebus)
        {
            var update = _database.Buses.Find(updatebus.BusNumber);
            update.PickUp = updatebus.PickUp;
            update.DropOff = updatebus.DropOff;
            update.SeatingCapacity = updatebus.SeatingCapacity;
            _database.Buses.Update(update);
            _database.SaveChanges();
            return RedirectToAction("Index", "Bus");
        }
        [HttpGet]
        public IActionResult DeleteBus(string id)
        {
            var delete = _database.Buses.Find(id);
            _database.SaveChanges();
            return View(delete);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteBus(Bus delbusNumber)
        {
            var delobj = _database.Buses.Find(delbusNumber.BusNumber);
            _database.Buses.Remove(delobj);
            _database.SaveChanges();
            TempData["Done"] = "Successfully Deleted";
            return RedirectToAction("Index");
        }
    }
}