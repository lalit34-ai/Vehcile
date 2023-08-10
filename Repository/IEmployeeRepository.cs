using System.Collections.Generic;
using VEHCILE.Models;

namespace VEHCILE.Repository
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employees> GetAllEmployees();
        void AddNewEmployee(Employees employee);
        // Add other necessary methods for updating and deleting employees if needed.
      //  bool DeleteEmployee(Employees newemployee);
        
    }
}
