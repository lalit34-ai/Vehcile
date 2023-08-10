// using VEHCILE.Models;
// using System.Text.RegularExpressions;
// using System.Web;
// using Microsoft.AspNetCore.Mvc;
// using System.Data.SqlClient;
// using VEHCILE.Repository;
// using System;
// using System.Data;
// using Microsoft.AspNetCore.Http;


// namespace VEHCILE.Repository
// {
//     public class inner : IData
//     {
//         private IConfiguration configuration;
//         private string dbcon = "";
        
//         public inner(IConfiguration configuration)
//         {
//             this.configuration = configuration;
//             dbcon = this.configuration.GetConnectionString("DefaultConnection");
//         }
//         public List<Employees> GetAllEmployees()
//         {
//             List<Employees> employees = new List<Employees>();
//             Employees employees1;
//             SqlConnection con1 = new SqlConnection(dbcon);
//             try
//             {
//                 con1.Open();
//                 String qryem = "Select * from EmployeeDetails";
//                 SqlDataReader reader1 = GetData(qryem, con1);
//                 while (reader1.Read())
//                 {
//                     employees1 = new Employees();
//                     employees1.EmployeeID = reader1["EmployeeID"].ToString();
//                     employees1.Firstname = reader1["Firstname"].ToString();
//                     employees1.Department = reader1["Department"].ToString();
//                     employees.Add(employees1);
//                 }
//             }
//             catch (Exception)
//             {
//                 throw;
//             }
//             finally
//             {
//                 con1.Close();
//             }
//             return employees;
//         }

//         public void AddNewEmployee(Employees newemployee)
//         {
//             // bool y1saved = false;
//             Console.WriteLine("Reached add employee");
//             SqlConnection connection = new SqlConnection(dbcon);
//             try
//             {
//                 connection.Open();
//                 string que = String.Format($"Insert into EmployeeDetails(Firstname,Middlename,Lastname,Department,Gender,Phone,CurrentAddress,EmployeeID,Password) values('{newemployee.Firstname}','{newemployee.Middlename}','{newemployee.Lastname}','{newemployee.Department}','{newemployee.Gender}','{newemployee.Phone}','{newemployee.CurrentAddress}','{newemployee.EmployeeID}','{newemployee.Password}')",  newemployee.Firstname, newemployee.Middlename, newemployee.Lastname, newemployee.Department, newemployee.Gender, newemployee.Phone, newemployee.CurrentAddress,newemployee.EmployeeID, newemployee.Password);
//                 SqlCommand command = new SqlCommand(que,connection);
//                 command.ExecuteNonQuery();
//             }
//             catch (Exception)
//             {
//                 Console.WriteLine("Exception occurred");
//             }
//             finally
//             {
//                 connection.Close();
//             }
//             // return y1saved;
//         }
//         public bool DeleteEmployee(Employees newemployee)
//         {
//             bool y1saved = true;
//             Console.WriteLine("Enter EmployeeID to Delete:");
//             String EID = Console.ReadLine();
//             SqlConnection connection = new SqlConnection(dbcon);
//             try
//             {
//                 connection.Open();
//                 string q = "Delete from Employee where EmployeeID='" + EID + "')";
//                 using (SqlCommand cmd = new SqlCommand(q, connection))
//                 {
//                     cmd.ExecuteNonQuery();
//                     Console.WriteLine("Record Deleted");
//                 }
//             }
//             catch (Exception)
//             {
//                 throw;
//             }
//             finally
//             {
//                 connection.Close();
//             }
//             return y1saved;
//         }

//         public List<Driver> GetAllDrivers()
//         {
//             List<Driver> drivers = new List<Driver>();
//             Driver driver;
//             SqlConnection con3 = new SqlConnection(dbcon);
//             try
//             {
//                 con3.Open();
//                 String qry3 = "Select * from Driver";
//                 SqlDataReader reader1 = GetData(qry3, con3);
//                 while (reader1.Read())
//                 {
//                     driver = new Driver();
//                     driver.EmployeeID = reader1["EmployeeID"].ToString();
//                     driver.Name = reader1["Name"].ToString();
//                     driver.PhoneNumber = reader1["PhoneNumber"].ToString();
//                     drivers.Add(driver);

//                 }
//             }
//             catch (Exception)
//             {
//                 throw;
//             }
//             finally
//             {
//                 con3.Close();
//             }
//             return drivers;
//         }

//         public bool AddNewDriver(Driver newdriver)
//         {
//             bool d1savesd = false;
//             SqlConnection connection = new SqlConnection(dbcon);
//             try
//             {
//                 connection.Open();
//                 string query = String.Format($"Insert into Driver(EmployeeID,Name,PhoneNumber) values('{newdriver.EmployeeID}','{newdriver.Name}','{newdriver.PhoneNumber}')", newdriver.EmployeeID, newdriver.Name, newdriver.PhoneNumber);
//                 SqlCommand cmd = new SqlCommand(query, connection);
//                 cmd.ExecuteNonQuery();
//             }
//             catch (Exception)
//             {
//                 throw;
//             }
//             finally
//             {
//                 connection.Close();
//             }
//             return d1savesd;
//         }

//         // public bool UpDriver(string EmployeeID, Driver updatedriver)
//         // {
//         //     bool s11saved = true;
//         //     SqlConnection connection = new SqlConnection(dbcon);
//         //     try
//         //     {
//         //         connection.Open();
//         //         string queryup = String.Format($"UPDATE Driver SET Name={updatedriver.Name},PhoneNumber='{updatedriver.PhoneNumber}' where EmployeeID= '{}'");
//         //         SqlCommand cmd = new SqlCommand(queryup, connection);
//         //         cmd.ExecuteNonQuery();
//         //         s11saved = false;
//         //     }
//         //     catch (Exception)
//         //     {
//         //         throw;
//         //     }
//         //     finally
//         //     {
//         //         connection.Close();
//         //     }
//         //     return s11saved;
//         // }

//         public bool DeleteDriver(string id, Driver deletedriver)
//         {
//             bool sq1s1aved = true;
//             SqlConnection connection = new SqlConnection(dbcon);
//             try
//             {
//                 connection.Open();
//                 string queryDel1 = String.Format($"DELETE From Driver where EmployeeID='{id}'");
//                 SqlCommand cmd = new SqlCommand(queryDel1, connection);
//                 cmd.ExecuteNonQuery();
//                 sq1s1aved = false;
//             }
//             catch (Exception)
//             {
//                 throw;
//             }
//             finally { connection.Close(); }
//             return sq1s1aved;
//         }
        
        
//         public List<Car> GetAllCars()
//         {   
//             List<Car> cars = new List<Car>();
//             Car car;
//             SqlConnection con =new SqlConnection(@"Data Source=LALIT\SQLEXPRESS;Initial Catalog=enterprise;Integrated Security=SSPI");
//             try
//             {
//                 con.Open();
//                 SqlDataReader reader=null;
//                 String qry = "Select * from Car";
//                 SqlCommand cmd = new SqlCommand(qry, con);
//                 reader = cmd.ExecuteReader();
//                 while (reader.Read())
//                 {
//                     car = new Car();
//                     car.CarType = reader["CarType"].ToString();
//                     car.CarNumber = reader["CarNumber"].ToString();
//                     car.SeatingCapacity = int.Parse(reader["SeatingCapacity"].ToString());
//                     car.FuelType = reader["FuelType"].ToString();
//                     car.PickUp = reader["PickUp"].ToString();
//                     car.DropOff = reader["DropOff"].ToString();
//                     car.Date = reader["Date"].ToString();
//                     cars.Add(car);
//                 }
//             }
//             catch (Exception)
//             {
//                 throw;
//             }
//             finally
//             {
//                 con.Close();
//             }
//             return cars;
//         }



//         public static DataTable displayBookingDetails(string empid)
//         {
//             SqlConnection con11 = new SqlConnection(getConnection());
//             DataTable userdatas11 = new DataTable();
//             try
//             {
//                 con11.Open();
//                 SqlDataAdapter dataadapter = new SqlDataAdapter($"select * from CustomerRequest where EmployeeID='{empid}'", con11);
//                 dataadapter.Fill(userdatas11);
//             }
//             catch (Exception exception)
//             {
//                 Console.WriteLine(exception.Message);
//             }
//             finally
//             {
//                 con11.Close();
//             }
//             return userdatas11;
//         }

//         public static string? getConnection()
//         {
//             var build = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
//             IConfiguration configuration = build.Build();
//             string? connectionString = Convert.ToString(configuration.GetConnectionString("DefaultConnection"));
//             return connectionString;
//         }

//         private SqlDataReader GetData(string qry, SqlConnection con)
//         {
//             SqlDataReader reader = null;
//             try
//             {
//                 SqlCommand cmd = new SqlCommand(qry, con);
//                 reader = cmd.ExecuteReader();
//             }
//             catch (Exception)
//             {
//                 throw;
//             }
//             finally
//             {

//             }
//             return reader;
//         }

//         //  private SqlDataReader GetData1(string querysel,SqlConnection conmicr){
//         //     SqlDataReader rd1=null;
//         //     try{
//         //         SqlCommand c1=new SqlCommand(querysel,conmicr);
//         //         rd1=c1.ExecuteReader();
//         //     }
//         //     catch(Exception) {
//         //         throw;
//         //     }
//         //     finally{

//         //     }
//         //     return rd1;
//         //  }
//         public bool AddNewCar(Car newcar)
//         {
//             bool inSaved = false;
//             // GetSqlDbConnection con=GetSqlDbConnection();
//             SqlConnection connection = new SqlConnection(dbcon);
//             // using(dbcon)
//             try
//             {
//                 connection.Open();
//                 Console.WriteLine(newcar.CarNumber);
//                 string query = String.Format($"Insert into Car(CarType,CarNumber,SeatingCapacity,FuelType,PickUp,DropOff) values('{newcar.CarType}','{newcar.CarNumber}',{newcar.SeatingCapacity},'{newcar.FuelType}','{newcar.PickUp}','{newcar.DropOff}')", newcar.CarType, newcar.CarNumber, newcar.SeatingCapacity, newcar.FuelType, newcar.PickUp, newcar.DropOff);
//                 SqlCommand cmd = new SqlCommand(query, connection);
//                 cmd.ExecuteNonQuery();
//                 inSaved = true;
//             }
//             catch (Exception)
//             {
//                 throw;
//             }
//             finally
//             {
//                 connection.Close();
//             }
//             return inSaved;
//         }

//         public bool UpdateCar(string id, Car updatecar)
//         {
//             bool sq1saved = true;
//             SqlConnection connection = new SqlConnection(dbcon);
//             try
//             {
//                 connection.Open();
//                 // Console.WriteLine(updatecar.SeatingCapacity);
//                 string queryDel = String.Format($"UPDATE Car SET SeatingCapacity={updatecar.SeatingCapacity},PickUp='{updatecar.PickUp}',DropOff='{updatecar.DropOff}' where CarNumber= '{id}'");
//                 SqlCommand cmd = new SqlCommand(queryDel, connection);
//                 cmd.ExecuteNonQuery();
//                 sq1saved = false;
//             }
//             catch (Exception)
//             {
//                 throw;
//             }
//             finally
//             {
//                 connection.Close();
//             }
//             return sq1saved;
//         }

//         public bool DeleteCar(string id, Car deletecar)
//         {
//             bool sq11saved = true;
//             SqlConnection connection = new SqlConnection(dbcon);
//             try
//             {
//                 connection.Open();
//                 string queryDel1 = String.Format($"DELETE From Car where CarNumber='{deletecar.CarNumber}'");
//                 SqlCommand cmd = new SqlCommand(queryDel1, connection);
//                 cmd.ExecuteNonQuery();
//                 sq11saved = false;
//             }
//             catch (Exception)
//             {
//                 throw;
//             }
//             finally { connection.Close(); }
//             return sq11saved;

//         }

        
//         // private SqlConnection GetSqlConnection()
//         // {
//         //     return new SqlConnection(dbcon);
//         // }

//         public bool SaveData(string query, SqlConnection con)
//         {
//             bool inSaved = false;
//             SqlConnection connection = new SqlConnection(dbcon);
//             try
//             {
//                 SqlCommand cmd = new SqlCommand(query, con);
//                 cmd.ExecuteNonQuery();
//                 inSaved = true;

//             }
//             catch (Exception)
//             {
//                 throw;
//             }
//             return inSaved;
//         }

//         public bool SaveData2(string q11, SqlConnection con)
//         {
//             bool sq1saved = false;
//             SqlConnection connection = new SqlConnection(dbcon);
//             try
//             {
//                 SqlCommand cmd = new SqlCommand(q11, con);
//                 cmd.ExecuteNonQuery();
//                 sq1saved = true;
//             }
//             catch (Exception)
//             {
//                 throw;
//             }
//             return sq1saved;
//         }
//         public bool SaveData1(string qry2, SqlConnection con)
//         {
//             bool yesSaved = false;
//             SqlConnection connection = new SqlConnection(dbcon);
//             try
//             {
//                 SqlCommand cmd = new SqlCommand(qry2, con);
//                 cmd.ExecuteNonQuery();
//                 yesSaved = true;

//             }
//             catch (Exception)
//             {
//                 throw;
//             }
//             return yesSaved;
//         }
//         public bool SavedData(string qry3, SqlConnection con)
//         {
//             bool d1savesd = false;
//             SqlConnection connection = new SqlConnection(dbcon);
//             try
//             {
//                 SqlCommand cmd = new SqlCommand(qry3, con);
//                 cmd.ExecuteNonQuery();
//                 d1savesd = true;

//             }
//             catch (Exception)
//             {
//                 throw;
//             }
//             return d1savesd;
//         }
//     }
// }



using System.Collections.Generic;
using VEHCILE.Models;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace VEHCILE.Repository
{
    public class inner : IData
    {
        private IConfiguration configuration;
        private string dbcon = "";

        public inner(IConfiguration configuration)
        {
            this.configuration = configuration;
            dbcon = this.configuration.GetConnectionString("DefaultConnection");
        }

        // Other methods in the class...

        public IEnumerable<Driver> GetAllDrivers()
        {
            List<Driver> drivers = new List<Driver>();
            Driver driver;
            SqlConnection con3 = new SqlConnection(dbcon);
            try
            {
                con3.Open();
                String qry3 = "Select * from Driver";
                SqlDataReader reader1 = GetData(qry3, con3);
                while (reader1.Read())
                {
                    driver = new Driver();
                    driver.EmployeeID = reader1["EmployeeID"].ToString();
                    driver.Name = reader1["Name"].ToString();
                    driver.PhoneNumber = reader1["PhoneNumber"].ToString();
                    drivers.Add(driver);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con3.Close();
            }
            return drivers;
        }
         public bool AddNewDriver(Driver newdriver)
        {
            bool d1savesd = false;
            SqlConnection connection = new SqlConnection(dbcon);
            try
            {
                connection.Open();
                string query = String.Format($"Insert into Driver(EmployeeID,Name,PhoneNumber) values('{newdriver.EmployeeID}','{newdriver.Name}','{newdriver.PhoneNumber}')", newdriver.EmployeeID, newdriver.Name, newdriver.PhoneNumber);
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return d1savesd;
        }

        // public bool UpDriver(string EmployeeID, Driver updatedriver)
        // {
        //     bool s11saved = true;
        //     SqlConnection connection = new SqlConnection(dbcon);
        //     try
        //     {
        //         connection.Open();
        //         string queryup = String.Format($"UPDATE Driver SET Name={updatedriver.Name},PhoneNumber='{updatedriver.PhoneNumber}' where EmployeeID= '{}'");
        //         SqlCommand cmd = new SqlCommand(queryup, connection);
        //         cmd.ExecuteNonQuery();
        //         s11saved = false;
        //     }
        //     catch (Exception)
        //     {
        //         throw;
        //     }
        //     finally
        //     {
        //         connection.Close();
        //     }
        //     return s11saved;
        // }

        public bool DeDriver(string id, Driver deletedriver)
        {
            bool sq1s1aved = true;
            SqlConnection connection = new SqlConnection(dbcon);
            try
            {
                connection.Open();
                string queryDel1 = String.Format($"DELETE From Driver where EmployeeID='{id}'");
                SqlCommand cmd = new SqlCommand(queryDel1, connection);
                cmd.ExecuteNonQuery();
                sq1s1aved = false;
            }
            catch (Exception)
            {
                throw;
            }
            finally { connection.Close(); }
            return sq1s1aved;
        }
        
        
        public List<Car> GetAllCars()
        {   
            List<Car> cars = new List<Car>();
            Car car;
            SqlConnection con =new SqlConnection(@"Data Source=LALIT\SQLEXPRESS;Initial Catalog=enterprise;Integrated Security=SSPI");
            try
            {
                con.Open();
                SqlDataReader reader=null;
                String qry = "Select * from Car";
                SqlCommand cmd = new SqlCommand(qry, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    car = new Car();
                    car.CarType = reader["CarType"].ToString();
                    car.CarNumber = reader["CarNumber"].ToString();
                    car.SeatingCapacity = int.Parse(reader["SeatingCapacity"].ToString());
                    car.FuelType = reader["FuelType"].ToString();
                    car.PickUp = reader["PickUp"].ToString();
                    car.DropOff = reader["DropOff"].ToString();
                    car.Date = reader["Date"].ToString();
                    cars.Add(car);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
            return cars;
        }

        public static DataTable displayBookingDetails(string empid)
        {
            SqlConnection con11 = new SqlConnection(getConnection());
            DataTable userdatas11 = new DataTable();
            try
            {
                con11.Open();
                SqlDataAdapter dataadapter = new SqlDataAdapter($"select * from CustomerRequest where EmployeeID='{empid}'", con11);
                dataadapter.Fill(userdatas11);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                con11.Close();
            }
            return userdatas11;
        }

        public static string? getConnection()
        {
            var build = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfiguration configuration = build.Build();
            string? connectionString = Convert.ToString(configuration.GetConnectionString("DefaultConnection"));
            return connectionString;
        }

        private SqlDataReader GetData(string qry, SqlConnection con)
        {
            SqlDataReader reader = null;
            try
            {
                SqlCommand cmd = new SqlCommand(qry, con);
                reader = cmd.ExecuteReader();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {

            }
            return reader;
        }

        //  private SqlDataReader GetData1(string querysel,SqlConnection conmicr){
        //     SqlDataReader rd1=null;
        //     try{
        //         SqlCommand c1=new SqlCommand(querysel,conmicr);
        //         rd1=c1.ExecuteReader();
        //     }
        //     catch(Exception) {
        //         throw;
        //     }
        //     finally{

        //     }
        //     return rd1;
        //  }
        public bool AddNewCar(Car newcar)
        {
            bool inSaved = false;
            // GetSqlDbConnection con=GetSqlDbConnection();
            SqlConnection connection = new SqlConnection(dbcon);
            // using(dbcon)
            try
            {
                connection.Open();
                Console.WriteLine(newcar.CarNumber);
                string query = String.Format($"Insert into Car(CarType,CarNumber,SeatingCapacity,FuelType,PickUp,DropOff) values('{newcar.CarType}','{newcar.CarNumber}',{newcar.SeatingCapacity},'{newcar.FuelType}','{newcar.PickUp}','{newcar.DropOff}')", newcar.CarType, newcar.CarNumber, newcar.SeatingCapacity, newcar.FuelType, newcar.PickUp, newcar.DropOff);
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                inSaved = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return inSaved;
        }

        public bool UpdateCar(string id, Car updatecar)
        {
            bool sq1saved = true;
            SqlConnection connection = new SqlConnection(dbcon);
            try
            {
                connection.Open();
                // Console.WriteLine(updatecar.SeatingCapacity);
                string queryDel = String.Format($"UPDATE Car SET SeatingCapacity={updatecar.SeatingCapacity},PickUp='{updatecar.PickUp}',DropOff='{updatecar.DropOff}' where CarNumber= '{id}'");
                SqlCommand cmd = new SqlCommand(queryDel, connection);
                cmd.ExecuteNonQuery();
                sq1saved = false;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return sq1saved;
        }

        public bool DeleteCar(string id, Car deletecar)
        {
            bool sq11saved = true;
            SqlConnection connection = new SqlConnection(dbcon);
            try
            {
                connection.Open();
                string queryDel1 = String.Format($"DELETE From Car where CarNumber='{deletecar.CarNumber}'");
                SqlCommand cmd = new SqlCommand(queryDel1, connection);
                cmd.ExecuteNonQuery();
                sq11saved = false;
            }
            catch (Exception)
            {
                throw;
            }
            finally { connection.Close(); }
            return sq11saved;

        }

        
        // private SqlConnection GetSqlConnection()
        // {
        //     return new SqlConnection(dbcon);
        // }

        public bool SaveData(string query, SqlConnection con)
        {
            bool inSaved = false;
            SqlConnection connection = new SqlConnection(dbcon);
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                inSaved = true;

            }
            catch (Exception)
            {
                throw;
            }
            return inSaved;
        }

        public bool SaveData2(string q11, SqlConnection con)
        {
            bool sq1saved = false;
            SqlConnection connection = new SqlConnection(dbcon);
            try
            {
                SqlCommand cmd = new SqlCommand(q11, con);
                cmd.ExecuteNonQuery();
                sq1saved = true;
            }
            catch (Exception)
            {
                throw;
            }
            return sq1saved;
        }
        public bool SaveData1(string qry2, SqlConnection con)
        {
            bool yesSaved = false;
            SqlConnection connection = new SqlConnection(dbcon);
            try
            {
                SqlCommand cmd = new SqlCommand(qry2, con);
                cmd.ExecuteNonQuery();
                yesSaved = true;

            }
            catch (Exception)
            {
                throw;
            }
            return yesSaved;
        }
        public bool SavedData(string qry3, SqlConnection con)
        {
            bool d1savesd = false;
            SqlConnection connection = new SqlConnection(dbcon);
            try
            {
                SqlCommand cmd = new SqlCommand(qry3, con);
                cmd.ExecuteNonQuery();
                d1savesd = true;

            }
            catch (Exception)
            {
                throw;
            }
            return d1savesd;
        }
    }

        
    }
