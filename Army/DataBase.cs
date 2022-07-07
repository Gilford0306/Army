using System;
using System.Data.SqlClient;

namespace Army
{
    class DataBase
    {
        public void Add(string res1, string res2)
        {
            string connStr = "Server=DESKTOP-37B5THF;Database=Army;Trusted_Connection=True;";
            string sqlText = "INSERT INTO [dbo].[FightResult]([Action],[Balance_Hp]) VALUES ('" + res1 +"','"+res2+"');";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(sqlText, conn))
                {
                    if (command.ExecuteNonQuery() > 0)
                        Console.WriteLine("Rows added!");
                        Console.WriteLine("Press Enter");
                }
            }
            Console.ReadLine();
        }
    }
}
