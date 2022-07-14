using System;
using System.Data.SqlClient;

namespace Army
{
    public sealed class Singleton
    {
        private static SqlConnection conn;
        private Singleton() 
        {
            conn = new SqlConnection(connStr);
            conn.Open();
        }
        private string connStr = "Server=DESKTOP-37B5THF;Database=Army;Trusted_Connection=True;";
        private static Singleton _instance;
        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
        public static void Add(string attack, string Hpres)
        {
            string sqlText = "INSERT INTO [dbo].[FightResult]([Action],[Balance_Hp]) VALUES ('" + attack + "','" + Hpres + "');";
            using (SqlCommand command = new SqlCommand(sqlText, conn))
                {
                    if (command.ExecuteNonQuery() > 0)
                        Console.WriteLine("Rows added!");
                    Console.WriteLine("Press Enter");
                }
            Console.ReadLine();
        }
        public static void Show ()
        {
            //string sqlStr = "SELECT * FROM [FightResult];";
            string sqlStr = "SELECT [Action],[Balance_Hp]  FROM[Army].[dbo].[FightResult];";
            SqlCommand SqlCommand = new SqlCommand(sqlStr, conn);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            for (int i = 0; i < reader.FieldCount; i++)
            Console.Write($"{reader.GetName(i).ToString()}\t");
            Console.WriteLine($"\n{new String('-', 25)} \n");
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.Write($"{reader.GetValue(i).ToString()}\n");
                }
                Console.WriteLine();
            }
            reader.Close();
        }

    }
}
