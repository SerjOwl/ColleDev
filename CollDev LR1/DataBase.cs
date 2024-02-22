using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS.database
{
    public static class DataBase
    {   
        private static SQLiteConnection CreateConnection()
        {

            SQLiteConnection sqlite_conn;

            sqlite_conn = new SQLiteConnection("Data Source= database.db");

            return sqlite_conn;
        }
        public static List<string> GetTableNames()
        {
            List<string> tableNames = new List<string>();

            using (SQLiteConnection sqlite_conn = CreateConnection())
            {
                sqlite_conn.Open();
                using (SQLiteCommand cmd = sqlite_conn.CreateCommand())
                {

                    cmd.CommandText = "SELECT \r\n    name\r\nFROM \r\n    sqlite_schema\r\nWHERE \r\n    type ='table' AND \r\n    name NOT LIKE 'sqlite_%';";

                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            tableNames.Add(rdr.GetString(0));
                        }
                    }
                }
                sqlite_conn.Close();
            }
            return tableNames;
        }

        public static DataTable GetDocData()
        {
            DataTable dataTable = new();

            using (SQLiteConnection sqlite_conn = CreateConnection())
            {
                sqlite_conn.Open();
                using (SQLiteCommand cmd = sqlite_conn.CreateCommand())
                {
                    cmd.CommandText = $"select Worker.full_name, Job.pay, Department.name \r\nfrom Worker\r\nleft join Department on Worker.department_id = Department.id\r\nleft join Job on Worker.job_id = Job.id\r\nORDER by Department.id, Worker.full_name";

                    SQLiteDataAdapter dataAdapter = new(cmd);
                    dataAdapter.Fill(dataTable);
                }
                sqlite_conn.Close();
            }

            return dataTable;
        }
        public static DataTable GetDocAddInfo()
        {
            DataTable dataTable = new();

            using (SQLiteConnection sqlite_conn = CreateConnection())
            {
                sqlite_conn.Open();
                using (SQLiteCommand cmd = sqlite_conn.CreateCommand())
                {
                    cmd.CommandText = $"select Department.name, count(Worker.full_name)\r\nfrom Department\r\nleft join Worker on Worker.department_id = Department.id\r\nGROUP by Department.name";

                    SQLiteDataAdapter dataAdapter = new(cmd);
                    dataAdapter.Fill(dataTable);
                }
                sqlite_conn.Close();
            }

            return dataTable;
        }

        public static void CreateNewJob(string name, decimal pay)
        {
            using (SQLiteConnection sqlite_conn = CreateConnection())
            {
                sqlite_conn.Open();
                using (SQLiteCommand cmd = sqlite_conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO \"Job\"  (name, pay)" +
                                                     $" VALUES('{name}', {pay}); ";
                    cmd.ExecuteNonQuery();
                }
                sqlite_conn.Close();
            }
        }

        public static void CreateNewWorker(string full_name, string birth_date, string sex, string adress, string in_company_since, int department_id, int job_id)
        {
            using (SQLiteConnection sqlite_conn = CreateConnection())
            {
                sqlite_conn.Open();
                using (SQLiteCommand cmd = sqlite_conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO \"Worker\"  (full_name, birth_date, sex, adress, in_company_since, department_id, job_id)" +
                                                     $" VALUES('{full_name}', '{birth_date}', '{sex}', '{adress}', '{in_company_since}', {department_id}, {job_id}); ";
                    cmd.ExecuteNonQuery();
                }
                sqlite_conn.Close();
            }
        }

        public static DataTable GetFromChosenTable(string tableName)
        {
            DataTable dataTable = new();

            using (SQLiteConnection sqlite_conn = CreateConnection())
            {
                sqlite_conn.Open();
                using (SQLiteCommand cmd = sqlite_conn.CreateCommand())
                {
                    cmd.CommandText = $"SELECT * FROM \"{tableName}\"";

                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd);
                    dataAdapter.Fill(dataTable);
                }
                sqlite_conn.Close();
            }

            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                switch (dataTable.Columns[i].ColumnName)
                {
                    case ("full_name"):
                        dataTable.Columns[i].ColumnName = "ФИО";
                        break;
                    case ("birth_date"):
                        dataTable.Columns[i].ColumnName = "Дата рождения";
                        break;
                    case ("sex"):
                        dataTable.Columns[i].ColumnName = "Пол";
                        break;
                    case ("adress"):
                        dataTable.Columns[i].ColumnName = "Адрес";
                        break;
                    case ("in_company_since"):
                        dataTable.Columns[i].ColumnName = "Стаж на предприятии";
                        break;
                    case ("name"):
                        dataTable.Columns[i].ColumnName = "Название";
                        break;
                    case ("id"):
                        dataTable.Columns[i].ColumnName = "Номер";
                        break;
                    case ("department_id"):
                        dataTable.Columns[i].ColumnName = "Номер отдела";
                        break;
                    case ("job_id"):
                        dataTable.Columns[i].ColumnName = "Номер должности";
                        break;
                    case ("pay"):
                        dataTable.Columns[i].ColumnName = "Зарплата";
                        break;
                }
            }

            return dataTable;
        }
    }
}
