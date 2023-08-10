using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using VEHCILE.Data;
using VEHCILE.Models;
using VEHCILE.Repository;

namespace VEHCILE.Controllers
{
    [Actions]
    public class ICarController : Controller
    {
        private readonly ICarRepository _carRepository;

        public ICarController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public IActionResult Index()
        {
            var list2 = _carRepository.GetAllCars();
            return View(list2);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Car newcar)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {
                bool inSaved = _carRepository.AddNewCar(newcar);
                ViewBag.inSaved = inSaved;
                return RedirectToAction("Index");
            }
        }

        public IActionResult UpdateCar(string id)
        {
            var update = _carRepository.GetCarById(id);
            return View(update);
        }

        [HttpPost]
        public IActionResult UpdateCar(Car updatecar)
        {
            bool isUpdated = _carRepository.UpdateCar(updatecar);
            ViewBag.inSaved = isUpdated;
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteCar(string id)
        {
            var delete = _carRepository.GetCarById(id);
            return View(delete);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteCar(Car delcarNumber)
        {
            _carRepository.DeleteCar(delcarNumber.CarNumber);
            TempData["Done"] = "Successfully Deleted";
            return RedirectToAction("Index");
        }

    }
}
