using System;
using Microsoft.Data.SqlClient;

public class Login
{
     string users_name;
     string password;
    static string connectionString = "Server=SG2NWPLS19SQL-v09.mssql.shr.prod.sin2.secureserver.net,1433;" + "Database=testwhatsapp;" + "User Id=testwhatsapp;" + "Password=M%E4Zn3li3oxjkp_;" + "Encrypt=True;" + "TrustServerCertificate=True;";
    public Login(string users_name, string password)
    {
        this.users_name = users_name;
        this.password = password;

        using SqlConnection con = new SqlConnection(connectionString);

        con.Open();

        string sql = @"SELECT COUNT(*) FROM Users WHERE Users_name = @users_name AND password = @password";

        using SqlCommand cmd = new SqlCommand(sql, con);

        cmd.Parameters.AddWithValue("@users_name", users_name);
        cmd.Parameters.AddWithValue("@password", password);

        int count = Convert.ToInt32(cmd.ExecuteScalar());

        if (count > 0)
        {
            Console.WriteLine("Login Success 😎");
        }
        else
        {
            Console.WriteLine("Login Failed 🥺");
        }
    }    
    public override string ToString()
    {
        return "Users Name: " + users_name;
    }
}