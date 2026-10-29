using Microsoft.Data.SqlClient;
using System;

public class Chats
{
    string user1;
    string user2;

    string messageFrom;
    string messageTo;
    string message;

    static string connectionString = "Server=SG2NWPLS19SQL-v09.mssql.shr.prod.sin2.secureserver.net,1433;" + "Database=testwhatsapp;" + "User Id=testwhatsapp;" + "Password=M%E4Zn3li3oxjkp_;" + "Encrypt=True;" + "TrustServerCertificate=True;";
    public Chats(string user1, string user2)
    {
        this.user1 = user1;
        this.user2 = user2;

        using SqlConnection con = new SqlConnection(connectionString);
        con.Open();

        string sql = @"SELECT *FROM Messages WHERE (MessageFrom = @user1 AND MessageTo = @user2)OR(MessageFrom = @user2 AND MessageTo = @user1)ORDER BY MessageNo DESC";

        using SqlCommand cmd = new SqlCommand(sql, con);

        cmd.Parameters.AddWithValue("@user1", user1);
        cmd.Parameters.AddWithValue("@user2", user2);

        using SqlDataReader reader = cmd.ExecuteReader();

        if (reader.Read())
        {
            messageFrom = reader["MessageFrom"].ToString();
            messageTo = reader["MessageTo"].ToString();
            message = reader["Message"].ToString();
        }
    }
    public override string ToString()
    {
        return "MessageFrom: " + messageFrom +" , \nMessageTo: " + messageTo +" , \nMessage: " + message;
    }
}