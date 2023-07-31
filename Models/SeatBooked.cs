using System;
using System.Collections.Generic;
using System.Web;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Data;
using VEHCILE.Models;

namespace VEHCILE.Models
{
    public class SeatBooked
    {
        public static void BusLinking(){

            Dictionary<string,List<string>> busDetails = new Dictionary<string, List<string>>();
            using(SqlConnection connection = new SqlConnection()){
                connection.ConnectionString = @"data source=Lalit-PC\SQLEXPRESS; Database=Enterprise;integrated security=SSPI;MultipleActiveResultSets=true";
                try{
                    connection.Open();
                    string query1 = "SELECT BusNumber,PickUp,DropOff,SeatingCapacity FROM Buses";
                    SqlCommand command = new SqlCommand(query1,connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while(reader.Read()){
                        busDetails.Add(
                            reader.GetString(0), new List<string>(){reader.GetString(1),reader.GetString(2)}
                        );
                    }
                }
                catch(SqlException e){
                    Console.WriteLine("Exception occurred");
                    Console.WriteLine(e);
                }
                finally{
                    connection.Close();
                }
            }

            using(SqlConnection connection = new SqlConnection()){
                connection.ConnectionString = "data source=ASPIRE1649; Database=Enterprise;integrated security=SSPI;MultipleActiveResultSets=true";
                try{
                    connection.Open();

                    foreach(var item in busDetails){
                        string query1 = $"UPDATE CustomerRequest SET BusNumber = '{item.Key}' WHERE PickUp = '{item.Value[0]}' and DropOff = '{item.Value[1]}'";
                        SqlCommand command = new SqlCommand(query1,connection);
                        command.ExecuteNonQuery();
                    }
                }
                catch(SqlException e){
                    Console.WriteLine("Exception occurred");
                    Console.WriteLine(e);
                }
                finally{
                    connection.Close();
                }
            }
        }


        public static void CarLinking(){
            Dictionary<string,List<string>> carDetails = new Dictionary<string, List<string>>();
            using(SqlConnection connection = new SqlConnection()){
                connection.ConnectionString = "data source=ASPIRE1649; Database=Enterprise;integrated security=SSPI;MultipleActiveResultSets=true";
                try{
                    connection.Open();
                    string query1 = "SELECT CarNumber,PickUp,DropOff FROM Car";
                    SqlCommand command = new SqlCommand(query1,connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while(reader.Read()){
                        carDetails.Add(
                            reader.GetString(0), new List<string>(){reader.GetString(1),reader.GetString(2)}
                        );
                    }
                }
                catch(SqlException e){
                    Console.WriteLine("Exception occurred");
                    Console.WriteLine(e);
                }
                finally{
                    connection.Close();
                }
            }
            using(SqlConnection connection = new SqlConnection()){
                connection.ConnectionString = "data source=ASPIRE1649; Database=Enterprise;integrated security=SSPI;MultipleActiveResultSets=true";
                try{
                    connection.Open();

                    foreach(var item in carDetails){
                        string query1 = $"UPDATE CustomerCar SET CarNumber = '{item.Key}' WHERE PickUp = '{item.Value[0]}' and DropOff = '{item.Value[1]}'";
                        SqlCommand command = new SqlCommand(query1,connection);
                        command.ExecuteNonQuery();
                    }
                }
                catch(SqlException e){
                    Console.WriteLine("Exception occurred");
                    Console.WriteLine(e);
                }
                finally{
                    connection.Close();
                }
            }

        }
    }
}