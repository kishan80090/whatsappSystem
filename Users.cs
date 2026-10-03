using Microsoft.Data.SqlClient;
using System;

public class Users
{
    string name;
    string user_name;
    string password;
    static string connectionString = "Server=localhost;Database=whatsapp;Trusted_Connection=True;TrustServerCertificate=True;";

    public string Name
    {
        get { return name; }
    }
    public string Username
    {
        get { return user_name; }
    }
    public string Password
    {
        get { return password; }
    }
    
    public Users(string name, string user_name, string password)
    {
        this.name = name;
        this.user_name = user_name;
        this.password = password;

        using SqlConnection con = new SqlConnection(connectionString);
        //con.Open();
        string sql = "INSERT INTO Users(name, user_name, password) VALUES(@name, @user_name, @password)";
        using SqlCommand cmd = new SqlCommand(sql, con);
        cmd.Parameters.AddWithValue("@Name", this.name);
        cmd.Parameters.AddWithValue("@User_name", this.user_name);
        cmd.Parameters.AddWithValue("@Password", this.password);
        con.Open();
        cmd.ExecuteNonQuery();
        Console.WriteLine("Successfully!");
    }
    public override string ToString()
    {
        return "Name: " + name + " , User_Name: " + user_name + " , Password: " + password;
    }
}