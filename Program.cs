using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace Devops_CaseStudy_Sohaib
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SQLiteConnection conn;
            conn = CreateConnection();
            CreateTable(conn);
            conn.Close();
            Application.Run(new Form2());
        }

        public static SQLiteConnection CreateConnection()
        {
            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=database.db;Version=3;New=True;Compress=True;");
            // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch 
            {
                
            }
            return sqlite_conn;
        }

        public static void CreateTable(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;
            string Createsql = "CREATE TABLE IF NOT EXISTS Scores (ID INTEGER PRIMARY KEY AUTOINCREMENT, Player VARCHAR(20), Level VARCHAR(20), Time INTEGER)";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = Createsql;
            sqlite_cmd.ExecuteNonQuery();
        }

        public static void InsertData(SQLiteConnection conn, string player, string level, int time)
        {
            SQLiteCommand sqliteCommand;
            sqliteCommand = conn.CreateCommand();
            sqliteCommand.CommandText = "INSERT INTO Scores (Player, Level, Time) VALUES (@player, @level, @time)";

            sqliteCommand.Parameters.AddWithValue("@player", player);
            sqliteCommand.Parameters.AddWithValue("@level", level);
            sqliteCommand.Parameters.AddWithValue("@time", time);

            sqliteCommand.ExecuteNonQuery();
        }

        public static string ReadPlayer(SQLiteConnection conn, string level)
        {
            SQLiteDataReader sqliteReader;
            SQLiteCommand sqliteCommand;
            sqliteCommand = conn.CreateCommand();
            sqliteCommand.CommandText = "SELECT Player FROM Scores WHERE level like @level ORDER BY time ASC LIMIT 1";
            sqliteCommand.Parameters.AddWithValue("@level", level);

            sqliteReader = sqliteCommand.ExecuteReader();
            string player = "No player yet";
            while(sqliteReader.Read())
            {
                player = sqliteReader.GetString(0);
            }
            sqliteReader.Close();

            return player;
        }

        public static string ReadTime(SQLiteConnection conn, string level)
        {
            SQLiteDataReader sqliteReader;
            SQLiteCommand sqliteCommand;
            sqliteCommand = conn.CreateCommand();
            sqliteCommand.CommandText = "SELECT Time FROM Scores WHERE level like @level ORDER BY time ASC LIMIT 1";
            sqliteCommand.Parameters.AddWithValue("@level", level);

            sqliteReader = sqliteCommand.ExecuteReader();
            string time = "No player yet";
            while (sqliteReader.Read())
            {
                time = sqliteReader.GetInt32(0).ToString();
            }
            sqliteReader.Close();

            return time;
        }
    }
}
