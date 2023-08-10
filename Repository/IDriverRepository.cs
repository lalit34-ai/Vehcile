using System.Collections.Generic;
using VEHCILE.Models;

namespace VEHCILE.Repository
{
    public interface IDriverRepository
    {
        IEnumerable<Driver> GetAllDrivers();
        bool AddNewDriver(Driver newDriver);
        bool UpdateDriver(string id, Driver updatedDriver);
        bool DeleteDriver(string id);
    }
}
