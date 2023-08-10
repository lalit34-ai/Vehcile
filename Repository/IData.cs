using VEHCILE.Models;

namespace VEHCILE.Repository
{
    public interface IData
    {
        // bool AddNewCar(Car newcar);
        // bool UpdateCar(string id, Car updatecar);
        // bool DeleteCar(string id, Car deletecar);
       // public List<Car> GetAllCars();

        //bool AddNewDriver(Driver newdriver);

        //bool UpDriver(string id,Driver updatedriver);
        // bool DeDriver(string id,Driver deletedriver);
        //List<Driver> GetAllDrivers();
        IEnumerable<Driver> GetAllDrivers();
        // bool DeleteDriver(string id);
        // void AddNewEmployee(Employees newemployee);

        // // bool DeleteEmployee(Employees newemployee);
        // List<Employees> GetAllEmployees();
    }
}
