using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace VEHCILE.Models
{
    public class DBFacilities
    {
        public string? EmployeeID { get; set; }
        public string? EmployeeName { get; set; }
        public string? Department { get; set; }

        public string? Vehicle_type { get; set; }
    }
}