using Microsoft.Data.SqlClient;
using System;
public class Chats
{    
    int MessageNo;
    static string connectionString = "Server=localhost;Database=whatsapp;Trusted_Connection=True;TrustServerCertificate=True;";
    public chats(int MessageNo)
	{ 
        this.MessageNo = MessageNo;
        using SqlConnection con = new SqlConnection(connectionString);
        con.Open();
        string sql = @"select MessageFrom, MessageTo, Message from Messages";
        using SqlCommand cmd = new SqlCommand(sql, con);
        cmd.ExecuteScalar();

    }
     
}
