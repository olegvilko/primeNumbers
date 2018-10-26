//using Microsoft.Analytics.Interfaces;
//using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace primeNumbers
{
    class Sql
    {
        public MySqlConnection mySqlConnection;

        public DefaultSettings defaultSettings;

        public enum Table
        {
            id,
            simple
        }

        public Sql()
        {
            defaultSettings = new DefaultSettings();

            NewConnection();           
        }

        public void NewConnection()
        {
            mySqlConnection = new MySqlConnection(defaultSettings.connectionString);
        }

        void ConnectionOpen()
        {
            try
            {
                mySqlConnection.Open();
            }
            catch
            {

            }
        }

        void ConnectionClose()
        {
            try
            {
                mySqlConnection.Close();
            }
            catch
            {

            }
        }

        int SelectExecuteScalar(string str)
        {
            MySqlCommand command = new MySqlCommand("SELECT " + str + " FROM " + defaultSettings.dataBase, mySqlConnection);

            ConnectionOpen();
            //mySqlConnection.Open();
            object obj = command.ExecuteScalar();
            ConnectionClose();

            if (obj != DBNull.Value)
            {
                return Convert.ToInt32(obj);
            }
            return 0;
        }

        int SelectExecuteScalar(string str, string where)
        {
            MySqlCommand command = new MySqlCommand("SELECT " + str + " FROM " + defaultSettings.dataBase + " WHERE " + where, mySqlConnection);
            ConnectionOpen();
            object obj = command.ExecuteScalar();
            ConnectionClose();

            if (obj != DBNull.Value)
            {
                return Convert.ToInt32(obj);
            }
            return 0;
        }

        public async void InsertSimple(string simple)
        {
            //  if (mySqlConnection.State == ConnectionState.Closed)
            MySqlConnection connection = new MySqlConnection(defaultSettings.connectionString);
            await connection.OpenAsync();
            MySqlCommand command = new MySqlCommand("INSERT INTO " + defaultSettings.dataBase + " (simple)VALUES (@Simple)", connection);
            command.Parameters.AddWithValue("simple", simple);
            await command.ExecuteNonQueryAsync();
            await connection.CloseAsync();
        }

        public List<object[]> SelectReader(string str)
        {
            MySqlCommand command = new MySqlCommand("SELECT " + str + " FROM " + defaultSettings.dataBase, mySqlConnection);
            ConnectionOpen();
            MySqlDataReader reader = command.ExecuteReader();

            List<object[]> list = new List<object[]>();

            foreach (IDataRecord current in reader)
            {
                object[] row = new object[reader.FieldCount];
                reader.GetValues(row);
                list.Add(row);
            }
            ConnectionClose();
            return list;
        }

        public int GetMaxId()
        {
            return SelectExecuteScalar("MAX(id)");
        }

        public int GetMaxSimple()
        {
            return SelectExecuteScalar("MAX(Simple)");
        }

        public int GetNum(int simple)
        {
            return SelectExecuteScalar("id", "Simple=" + simple);
        }

        //____________________________________________________________________________________
        public void ClearDatabase()
        {
            MySqlCommand command = new MySqlCommand("TRUNCATE TABLE " + defaultSettings.dataBase, mySqlConnection);
            ConnectionOpen();
            command.ExecuteNonQuery();
            ConnectionClose();
        }

        public void CopyTable(string table, string tableTo)
        {
            MySqlCommand command = new MySqlCommand("TRUNCATE TABLE " +tableTo, mySqlConnection);

            ConnectionOpen();

            command.ExecuteNonQuery();

            command = new MySqlCommand("INSERT INTO "+tableTo+ " SELECT * FROM "+table, mySqlConnection);

            command.ExecuteNonQuery();

            ConnectionClose();
        }
    }
}