using System;
using System.Collections.Generic;
using System.Linq;
using VEHCILE.Data;
using VEHCILE.Models;
using VEHCILE.Repository;   

namespace VEHCILE.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _db;

        public EmployeeRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Employees> GetAllEmployees()
        {
            return _db.Employees.ToList();
        }

        public void AddNewEmployee(Employees employee)
        {
            _db.Employees.Add(employee);
            _db.SaveChanges();
        }

    //     public void DeleteEmployee(Employees employee)
    //     {
    //         try{
    //             _db.Employees.Remove(employee);
    //             _db.SaveChanges();
    //             return true;
    //     }
    //     catch(Exception){
    //         return false;     
    //     }
    // }
    }
}
