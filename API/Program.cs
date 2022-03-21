using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
//{
//                SqliteConnection sqlite_conn;
//                sqlite_conn = CreateConnection();
//                CreateTable(sqlite_conn);
//                InsertData(sqlite_conn);
//                ReadData(sqlite_conn);
//}

//            static SqliteConnection CreateConnection()
//{

//                SqliteConnection sqlite_conn;
//                // Create a new database connection:
//                sqlite_conn = new SqliteConnection("Data Source=database.db; Version = 3; New = True; Compress = True; ");
//               // Open the connection:
//                try {
//                    sqlite_conn.Open();
//                }
//                catch (Exception ex) {

//                }
//                return sqlite_conn;
//            }

//            static void CreateTable(SqliteConnection conn)
//{

//                SqliteCommand sqlite_cmd;
//                string Createsql = "CREATE TABLE SampleTable(Col1 VARCHAR(20), Col2 INT)";
//               string Createsql1 = "CREATE TABLE SampleTable1(Col1 VARCHAR(20), Col2 INT)";
//               sqlite_cmd = conn.CreateCommand();
//                sqlite_cmd.CommandText = Createsql;
//                sqlite_cmd.ExecuteNonQuery();
//                sqlite_cmd.CommandText = Createsql1;
//                sqlite_cmd.ExecuteNonQuery();

//            }

//            static void InsertData(SqliteConnection conn)
//{
//                SqliteCommand sqlite_cmd;
//                sqlite_cmd = conn.CreateCommand();
//                sqlite_cmd.CommandText = "INSERT INTO SampleTable(Col1, Col2) VALUES('Test Text ', 1); ";
//               sqlite_cmd.ExecuteNonQuery();
//                sqlite_cmd.CommandText = "INSERT INTO SampleTable(Col1, Col2) VALUES('Test1 Text1 ', 2); ";
//               sqlite_cmd.ExecuteNonQuery();
//                sqlite_cmd.CommandText = "INSERT INTO SampleTable(Col1, Col2) VALUES('Test2 Text2 ', 3); ";
//               sqlite_cmd.ExecuteNonQuery();


//                sqlite_cmd.CommandText = "INSERT INTO SampleTable1(Col1, Col2) VALUES('Test3 Text3 ', 3); ";
//               sqlite_cmd.ExecuteNonQuery();

//            }

//            static void ReadData(SqliteConnection conn)
//{
//                SqliteDataReader sqlite_datareader;
//                SqliteCommand sqlite_cmd;
//                sqlite_cmd = conn.CreateCommand();
//                sqlite_cmd.CommandText = "SELECT * FROM SampleTable";

//                sqlite_datareader = sqlite_cmd.ExecuteReader();
//                while (sqlite_datareader.Read()) {
//                    string myreader = sqlite_datareader.GetString(0);
//                    Console.WriteLine(myreader);
//                }
//                conn.Close();
//            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
