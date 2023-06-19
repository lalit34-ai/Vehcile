using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Http;
using System.Web;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using VEHCILE.Data;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Microsoft.Extensions.Configuration;
using VEHCILE.Models;
using System.Text;
using VEHCILE.Repository;
using Newtonsoft.Json;


namespace VEHCILE.Controllers
{
    [Actions]
    public class CarBookingController : Controller
    {
        private readonly IData _data;
        private readonly ApplicationDbContext _db;
        public CarBookingController(IData data){
            _data=data;
        }

        [HttpGet]
        public IActionResult Cab1()
        {
            ViewBag.userSession = HttpContext.Session.GetString("EmployeeID");
            // List<Car> car1 =car1 ;
            // ata n1=new Data(); new inner();
            // inner data =new inner(IConfiguration configuration) ;
            // List <IEnumerable<Car>> carList =null ;
            List<Car> cars = _data.GetAllCars();
            Console.WriteLine(cars);
            //ViewBag.carList = cars;
            // if(data!=null){
            //     carList=(IEnumerable<Car>)data.GetAllCars();
            // }
            return View(cars);
        }
        [HttpPost]
        public IActionResult Cab1(Car obj1)
        {
            if (true)
            {
                ViewBag.Session = HttpContext.Session.GetString("EmployeeID");
                Bookcaruser requestObj1 = new Bookcaruser();
                requestObj1.EmployeeID = ViewBag.Session;
                // requestObj.EmployeeID = null;
                requestObj1.PickUp = obj1.PickUp;
                requestObj1.DropOff = obj1.DropOff;
                requestObj1.senddate = obj1.Date;
                requestObj1.quantity = null;
                requestObj1.status = null;
                _db.CustomerCar.Add(requestObj1);
                _db.SaveChanges();
                SeatBooked.CarLinking();
                return RedirectToAction("BusSeat");
            }
            return RedirectToAction("Cab1");
        }
    }
}
