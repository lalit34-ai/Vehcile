using System;
using System.Collections.Generic;
using VEHCILE.Data;
using VEHCILE.Models;

namespace VEHCILE.Repository
{
    public class DriverRepository : IDriverRepository
    {
        private readonly IData data;

        public DriverRepository(IData data)
        {
            this.data = data;
        }

        public IEnumerable<Driver> GetAllDrivers()
        {
            return data.GetAllDrivers();
        }

        public bool AddNewDriver(Driver newDriver)
        {
            // Add implementation for adding a new driver
            throw new NotImplementedException();
        }

        public bool UpdateDriver(string id, Driver updatedDriver)
        {
            // Add implementation for updating a driver
            throw new NotImplementedException();
        }

        public bool DeleteDriver(string id)
        {
            // Add implementation for deleting a driver
            throw new NotImplementedException();
        }
    }
}
