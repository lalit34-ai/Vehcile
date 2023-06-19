using System.Text.RegularExpressions;
using System;
using System.Data;
using System.Data.SqlClient;

class Database
{
    public static string connectionstring = @"Data Source=Lalit-PC\SQLEXPREss;Initial Catalog=Users;Integrated Security=SSPI";
    static SqlConnection connection = new SqlConnection(connectionstring);

    public int SignInAccount(LoginEmployee loginemployee)
    {
        string info = "";
        try
        {
            connection.Open();
            String uname = loginemployee.EmployeeID;
            String pwd = loginemployee.Password;

            SqlCommand sqlcmd = new SqlCommand("select * from Vehcile where EmployeeID='" + uname + "' and password='" + pwd + "';", connection);
            SqlDataReader reader = sqlcmd.ExecuteReader();

            if (reader.Read())
            {
                if (Convert.ToString(reader["EmployeeID"]) == uname && Convert.ToString(reader["password"]) == pwd)
                {
                    return 1;
                }
            }

        }
        catch (SqlException ex)
        {
            Console.WriteLine("Error : " + ex.Message.ToString());
        }
        finally
        {
            Console.WriteLine("Press any key to exit.....");
            connection.Close();
        }
        connection.Close();
        return 0;
    }
    public void forgotPassword(LoginEmployee loginEmployee)
    {
        try
        {
            connection.Open();
            String uname = loginEmployee.EmployeeID;
            String pwd = loginEmployee.Password;
            string str = "update Vehcile set passwprd=' " + pwd + " ' WHERE EmployeeID=' " + uname + " ';";
            SqlCommand sqlcommand = new SqlCommand(str, connection);
            sqlcommand.ExecuteNonQuery();
        }
        catch (SqlException ex)
        {
            Console.WriteLine("Error : " + ex.Message.ToString());
        }
        finally
        {
            connection.Close();
        }
    }

    public string LogValidation(LoginEmployee loginemployee)
    {
        string info = "";

        // using(SqlConnection sqlcommand11=new SqlConnection("Data Source=ASPIRE1649;Initial Catalog=Users;Integrated Security=SSPI")){
        connection.Open();
        SqlCommand sqlCommand11 = new SqlCommand("Select EmployeeID,password from Vehcile where password = @password;");
        string password = (string)sqlCommand11.ExecuteScalar();
        if (password != null && password == loginemployee.Password)
        {
            info = "Okay";
        }
        else
        {
            info = "Not Okay";
        }
        return info;

    }

}