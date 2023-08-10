using System.Collections.Generic;
using System.Linq;
using VEHCILE.Data;
using VEHCILE.Models;

namespace VEHCILE.Repository
{
    public class BusRepository
    {
        private readonly ApplicationDbContext _database;

        public BusRepository(ApplicationDbContext database)
        {
            _database = database;
        }

        public List<Bus> GetAllBuses()
        {
            return _database.Buses.ToList();
        }

        public void AddBusEntry(Bus newBus)
        {
            _database.Buses.Add(newBus);
            _database.SaveChanges();
        }

        public Bus GetBusById(string id)
        {
            return _database.Buses.Find(id);
        }

        public void UpdateBus(Bus updateBus)
        {
            var existingBus = _database.Buses.Find(updateBus.BusNumber);
            if (existingBus != null)
            {
                existingBus.PickUp = updateBus.PickUp;
                existingBus.DropOff = updateBus.DropOff;
                existingBus.SeatingCapacity = updateBus.SeatingCapacity;
                _database.Buses.Update(existingBus);
                _database.SaveChanges();
            }
        }

        public void DeleteBus(string id)
        {
            var busToDelete = _database.Buses.Find(id);
            if (busToDelete != null)
            {
                _database.Buses.Remove(busToDelete);
                _database.SaveChanges();
            }
        }
    }
}
