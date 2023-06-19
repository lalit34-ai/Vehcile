namespace VEHCILE
{
    using System;
    using System.Collections.Generic;
    public partial class SignOut
    {
        public int SignOutID { get; set; }
        public int EmployeeID { get; set; }
        public string? Destination { get; set; }
        public string? VehcileID { get; set; }

        public Nullable<System.DateTime> CheckOutTime { get; set; }
        public Nullable<System.DateTime> CheckInTime { get; set; }
        public Nullable<System.DateTime> ActivityTime { get; set; }
        public virtual LoginEmployee? Employee { get; set; }
        // public virtual VEHCILE VEHCILE { get; set; }F
    }



}