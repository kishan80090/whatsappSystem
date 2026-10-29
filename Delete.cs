using System;
using Microsoft.Data.SqlClient;

public class Delete
{
    int messageNo;
    static string connectionString = "Server=SG2NWPLS19SQL-v09.mssql.shr.prod.sin2.secureserver.net,1433;" + "Database=testwhatsapp;" + "User Id=testwhatsapp;" + "Password=M%E4Zn3li3oxjkp_;" + "Encrypt=True;" + "TrustServerCertificate=True;";
    public Delete(int messageNo)
    {
        this.messageNo = messageNo;
        DeleteMessage();
    }
    public void DeleteMessage()
    {
        string sql = "DELETE FROM Messages WHERE MessageNo = @MessageNo";

        using (SqlConnection con = new SqlConnection(connectionString))
        {
            con.Open();

            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@MessageNo", messageNo);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    Console.WriteLine("Message deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Message not found.");
                }
            }
        }
    }
    public override string ToString()
    {
        return "Message No: " + messageNo;
    }
}