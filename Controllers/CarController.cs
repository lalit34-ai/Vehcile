// using System.Diagnostics;
// using Microsoft.AspNetCore.Mvc;
// using VEHCILE.Models;
// using VEHCILE.Repository;
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Web;
// using VEHCILE.Data;

// namespace VEHCILE.Controllers
// {
//     [Actions]
//     public class CarController : Controller
//     {
//         private ApplicationDbContext _database;
//         public CarController(ApplicationDbContext database)
//         {
//             _database = database;
//         }
//         public IActionResult Index()
//         {
//             var list2 = _database.Cars.ToList();
//             return View(list2);
//         }
//         public IActionResult Add()
//         {
//             return View();
//         }
//         [HttpPost]
//         public IActionResult Add(Car newcar)
//         {
//             _database.Cars.Add(newcar);
//             _database.SaveChanges();
//             return RedirectToAction("Index");
//         }
//         public IActionResult UpdateCar(string id)
//         {
//             var update = _database.Cars.Find(id);
//             _database.SaveChanges();
//             return View(update);
//         }
//         [HttpPost]
//         public IActionResult UpdateCar(Car updatecar)
//         {
//             var update = _database.Cars.Find(updatecar.CarNumber);
//             update.PickUp = updatecar.PickUp;
//             update.DropOff = updatecar.DropOff;
//             update.SeatingCapacity = updatecar.SeatingCapacity;
//             _database.Cars.Update(update);
//             _database.SaveChanges();
//             return RedirectToAction("Index", "Car");
//         }
//         [HttpGet]
//         public IActionResult DeleteCar(string id)
//         {
//             var delete = _database.Cars.Find(id);
//             _database.SaveChanges();
//             return View(delete);
//         }
//         [HttpPost]
//         [ValidateAntiForgeryToken]
//         public IActionResult DeleteCar(Car delcarNumber)
//         {
//             var delobj = _database.Cars.Find(delcarNumber.CarNumber);
//             _database.Cars.Remove(delobj);
//             _database.SaveChanges();
//             TempData["Done"] = "Successfully Deleted";
//             return RedirectToAction("Index");
//         }
//     }
// }