using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;
using System.Data.SqlClient;

namespace WebApplicationDemo.Pages
{

    public class SQLUsageModel : PageModel
    {
        public List<MessageInfo> listInfo = new List<MessageInfo>();
        public void OnGet()
        {
            try
            {
                String connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
                Console.WriteLine("Opening Connection...");
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "USE master; SELECT * FROM messages;";
                    Console.WriteLine("Sending command...");
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        Console.WriteLine("Reading table...");
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            MessageInfo info = new MessageInfo();
                            info.id = "" + reader.GetInt32(0);
                            info.sender = reader.GetString(1);
                            info.payload = reader.GetString(2);
                            info.time_stamp = reader.GetDateTime(3).ToString();
                            listInfo.Add(info);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public void OnPost() 
        {
            
        }
    }
    public class MessageInfo 
    {
        public String id;
        public String sender;
        public String payload;
        public String time_stamp;
    }
}
