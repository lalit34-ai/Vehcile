using Microsoft.AspNetCore.Mvc;
using VEHCILE.Models;
using VEHCILE.Repository;
using VEHCILE.Data;
using System.Linq;

// we implemented separation of concern by refactoring the controller and moving the data access logic to separate repository class.
//Hence making controller responsible for handling customer inputs, invoking the repository  for data operations and managing the view render.

namespace VEHCILE.Controllers
{
    [Actions]
    public class BusController : Controller
    {
        private readonly BusRepository _busRepository;

        public BusController(BusRepository busRepository)
        {
            _busRepository = busRepository;
        }

        public IActionResult Index()
        {
            var buses = _busRepository.GetAllBuses();
            return View(buses);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Bus newbus)
        {
            _busRepository.AddBusEntry(newbus);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateBus(string id)
        {
            var updateBusData = _busRepository.GetBusById(id);
            if (updateBusData == null)
            {
                return NotFound();
            }
            return View(updateBusData);
        }

        [HttpPost]
        public IActionResult UpdateBus(Bus updateBus)
        {
            _busRepository.UpdateBus(updateBus);
            return RedirectToAction("Index");
        }

        [HttpGet] // the deletebus method is not working check it.
        public IActionResult DeleteBus(string id)
        {
            var deleteBusData = _busRepository.GetBusById(id);
            if (deleteBusData == null)
            {
                return NotFound();
            }
            return View(deleteBusData);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteBusConfirmed(string id)
        {
            _busRepository.DeleteBus(id);
            TempData["Done"] = "Successfully Deleted";
            return RedirectToAction("Index");
        }
    }
}
