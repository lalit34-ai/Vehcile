namespace VEHCILE
{
    using System;
    using System.Collections.Generic;
    public partial class Admin_Approval
    {
        public string? EmployeeID { get; set; }
        public string? Destination { get; set; }
        public string? VehcileNumber { get; set; }
        public Nullable<int> SignOutId { get; set; }
        public Nullable<System.DateTime> CheckOutTime { get; set; }
        public Nullable<System.DateTime> CheckInTime { get; set; }
        public Nullable<System.DateTime> ActivityTime { get; set; }
        public Nullable<bool> ApprovedDmv { get; set; }
    }
}



