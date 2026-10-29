using Microsoft.Data.SqlClient;
using System;

public class Messages
{
    string messageFrom;
    string messageTo;
    string message;
    static string connectionString = "Server=SG2NWPLS19SQL-v09.mssql.shr.prod.sin2.secureserver.net,1433;" + "Database=testwhatsapp;" + "User Id=testwhatsapp;" + "Password=M%E4Zn3li3oxjkp_;" + "Encrypt=True;" + "TrustServerCertificate=True;";
    public string MessageFrom
    {
        get { return messageFrom; }
    }
    public string MessageTo
    {
        get { return messageTo; }
    }
    public string Message
    {
        get { return message; }
    }
    public Messages(string messageFrom, string messageTo, string message)
    {
        this.messageFrom = messageFrom;
        this.messageTo = messageTo;
        this.message = message;
        using SqlConnection con = new SqlConnection(connectionString);
        string sql = @"INSERT INTO Messages(MessageFrom, MessageTo, Message) VALUES(@MessageFrom, @MessageTo, @Message)";
        using SqlCommand cmd = new SqlCommand(sql, con);
        cmd.Parameters.AddWithValue("@MessageFrom", this.messageFrom);
        cmd.Parameters.AddWithValue("@MessageTo", this.messageTo);
        cmd.Parameters.AddWithValue("@Message", this.message);
        con.Open();
        cmd.ExecuteNonQuery();
        Console.WriteLine("Message Sent Successfully!");
    }
  public override string ToString()
    {
        return "Message From: " + messageFrom + " , Message To: " + messageTo + " , Message: " + message;
    }
}