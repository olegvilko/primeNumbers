using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace primeNumbers
{
    public class Sql
    {
        MySqlConnection mySqlConnection;

        public enum Table
        {
            id,
            simple
        }

        public Sql()
        {
            NewConnection();
        }

        public void NewConnection()
        {
            mySqlConnection = new MySqlConnection(DefaultSettings.connectionString);
        }

        void ConnectionOpen()
        {
            try
            {
                mySqlConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ConnectionClose()
        {
            try
            {
                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public async void InsertSimple(string simple)
        {
            try
            {
                var connection = new MySqlConnection(DefaultSettings.connectionString);
                await connection.OpenAsync();
                var command = new MySqlCommand("INSERT INTO " + DefaultSettings.dataBase + " (simple)VALUES (@Simple)", connection);
                command.Parameters.AddWithValue("simple", simple);
                await command.ExecuteNonQueryAsync();
                await connection.CloseAsync();
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }
        }

        public List<object[]> SelectReader(string str)
        {
            var command = new MySqlCommand("SELECT " + str + " FROM " + DefaultSettings.dataBase, mySqlConnection);
            ConnectionOpen();
            var reader = command.ExecuteReader();
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

        public bool CheckSimple(int id)
        {
            if (SelectExecuteScalar("Simple", "id=" + id) != 0)
            {
                return true;
            }
            return false;
        }

        public int GetSimple(int id)
        {
            return SelectExecuteScalar("Simple", "id=" + id);
        }

        public void ClearDatabase()
        {
            ExecuteNonQuery("TRUNCATE TABLE " + DefaultSettings.dataBase);
        }

        public void CopyTable(string table, string tableTo)
        {
            ExecuteNonQuery("TRUNCATE TABLE " + tableTo);
            ExecuteNonQuery("INSERT INTO " + tableTo + " SELECT * FROM " + table);
        }

        public void CreateTable(string table)
        {
            ExecuteNonQuery("CREATE TABLE IF NOT EXISTS " + table + " (`id` int (11) NOT NULL, `simple` int (11) NOT NULL) ENGINE=InnoDB DEFAULT CHARSET=latin1;");
            ExecuteNonQuery("ALTER TABLE " + table + " ADD PRIMARY KEY(`id`);");
            ExecuteNonQuery("ALTER TABLE " + table + " MODIFY `id` int (11) NOT NULL AUTO_INCREMENT;");
        }

        #region Private
        private void ExecuteNonQuery(string query)
        {
            var command = new MySqlCommand(query, mySqlConnection);
            ConnectionOpen();
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ConnectionClose();
        }

        private int SelectExecuteScalar(string str, string where)
        {
            var command = new MySqlCommand("SELECT " + str + " FROM " + DefaultSettings.dataBase + " WHERE " + where, mySqlConnection);
            ConnectionOpen();
            object obj = command.ExecuteScalar();
            ConnectionClose();
            if (obj != DBNull.Value)
            {
                return Convert.ToInt32(obj);
            }
            return 0;
        }

        private int SelectExecuteScalar(string str)
        {
            var command = new MySqlCommand("SELECT " + str + " FROM " + DefaultSettings.dataBase, mySqlConnection);
            ConnectionOpen();
            object obj = null;
            try
            {
                obj = command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ConnectionClose();
            if (obj != DBNull.Value)
            {
                return Convert.ToInt32(obj);
            }
            return 0;
        }
        #endregion
    }
}