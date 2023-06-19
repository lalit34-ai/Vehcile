// using System.Diagnostics;
// using Microsoft.AspNetCore.Mvc;
// using VEHCILE.Models;
// using VEHCILE.Repository;

// namespace VEHCILE.Controllers
// {
//     [Actions]
//     public class CarController : Controller
//     {
//     //     private readonly IData data;
//         // public CarController(IData _data)
//         // {
//         //     data = _data;
//         // }
//         // public IActionResult Index()
//         // {
//         //     var list = data.GetAllCars();
//         //     return View(list);
//         // }
//         // public IActionResult Add()
//         // {
//         //     return View();
//         // }
//         // [HttpPost]
//         // public IActionResult Add(Car newcar) //to add new car
//         // {
//         //     if (!ModelState.IsValid)
//         //     {
//         //         return View();
//         //     }
//         //     else
//         //     {
//         //         bool inSaved = data.AddNewCar(newcar);
//         //         Console.WriteLine(newcar.CarNumber);
//         //         ViewBag.inSaved = inSaved;
//         //         return RedirectToAction("Index");
//         //     }
//         // }
//         // public IActionResult Update()
//         // {
//         //     return View();
//         // }
//         // [HttpPost]
//         // public IActionResult Update(string id, Car updatecar)
//         // {
//         //     bool sq1saved = data.UpdateCar(id, updatecar);
//         //     ViewBag.inSaved = sq1saved;
//         //     return RedirectToAction("Index");
//         // }

//         // public IActionResult Delete()
//         // {
//         //     return View();
//         // }
//         // [HttpPost]
//         // public IActionResult Delete(string id, Car deletecar)
//         // {
//         //     bool sq11saved = data.DeleteCar(id, deletecar);
//         //     ViewBag.inSaved = sq11saved;
//         //     return RedirectToAction("Index");
//         // }

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
//             var delete = _database.Car.Find(id);
//             _database.SaveChanges();
//             return View(delete);
//         }
//         [HttpPost]
//         [ValidateAntiForgeryToken]
//         public IActionResult DeleteCar(Car delcarNumber)
//         {
//             var delobj = _database.Car.Find(delcarNumber.CarNumber);
//             _database.Car.Remove(delobj);
//             _database.SaveChanges();
//             TempData["Done"] = "Successfully Deleted";
//             return RedirectToAction("Index");
//         }
//     }
// }
 
