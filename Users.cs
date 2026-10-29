using Microsoft.Data.SqlClient;
using System;
public class Users
{
    string name;
    string users_name;
    string password;
    static string connectionString = "Server=SG2NWPLS19SQL-v09.mssql.shr.prod.sin2.secureserver.net,1433;" + "Database=testwhatsapp;" + "User Id=testwhatsapp;" + "Password=M%E4Zn3li3oxjkp_;" + "Encrypt=True;" + "TrustServerCertificate=True;";
    public string Name
    {
        get { return name; }
    }
    public string Users_name
    {
        get { return users_name; }
    }
    public string Password
    {
        get { return password; }
    }
    public Users(string name, string users_name, string password)
    {
        this.name = name;
        this.users_name = users_name;
        this.password = password;

        using SqlConnection con = new SqlConnection(connectionString);

        string sql = "INSERT INTO Users(name, users_name, password) VALUES(@name, @users_name, @password)";

        using SqlCommand cmd = new SqlCommand(sql, con);

        cmd.Parameters.AddWithValue("@name", this.name);
        cmd.Parameters.AddWithValue("@users_name", this.users_name);
        cmd.Parameters.AddWithValue("@password", this.password);

        con.Open();
        cmd.ExecuteNonQuery();

        Console.WriteLine("Successfully!");
    }
    public override string ToString()
    {
        return "Name: " + name + " , Users_Name: " + users_name +" , Password: " + password;
    }
}