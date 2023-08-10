using System.Collections.Generic;
using VEHCILE.Models;
using VEHCILE.Repository;

namespace VEHCILE.Repository{
    public interface ICarRepository{
        IEnumerable<Char> GetAllCars();
        Car GetCarById(string id);
        bool AddNewCar(Car newcar);
        bool UpdateCar(Car updatecar);
        bool DeleteCar(string id);
    }
}