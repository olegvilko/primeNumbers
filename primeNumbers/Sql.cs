//using Microsoft.Analytics.Interfaces;
//using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace primeNumbers
{
    class Sql
    {
        public SqlConnection sqlConnection;

        public SqlDataReader sqlReader = null;

        DefaultSettings defaultSettings;

        public Sql()
        {
            SqlConnect();
        }

        public async void SqlConnect()
        {
            defaultSettings = new DefaultSettings();

            sqlConnection = new SqlConnection(defaultSettings.connectionString);

            await sqlConnection.OpenAsync();

            SqlCommand command = new SqlCommand("SELECT * FROM [Numbers]", sqlConnection);

            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    //  listBox1.Items.Add(Convert.ToString((sqlReader["Id"]) + "        " + Convert.ToString(sqlReader["Num"]) + "      " + Convert.ToString(sqlReader["NumId"])));
                }
            }
            catch (Exception ex)
            {
                //  MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }

        public async void GetSelect(string select)
        {
            await sqlConnection.OpenAsync();

            SqlCommand command = new SqlCommand("SELECT * FROM [Numbers]", sqlConnection);

            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    //  listBox1.Items.Add(Convert.ToString((sqlReader["Id"]) + "        " + Convert.ToString(sqlReader["Num"]) + "      " + Convert.ToString(sqlReader["NumId"])));
                    //           return sqlReader["Num"];
                }
            }
            catch (Exception ex)
            {
                //  MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();

            }
            //  return null;
        }

        public void AddNum()
        {
            SqlCommand command = new SqlCommand("INSERT INTO [Numbers] (Num)VALUES (@Num)", sqlConnection);
            command.Parameters.AddWithValue("Num", 22);
        }

        public int GetMaxNum()
        {
            sqlConnection = new SqlConnection(defaultSettings.connectionString);

            sqlConnection.Open();

            SqlCommand command = new SqlCommand("SELECT MAX(Num) FROM [Numbers1]", sqlConnection);

            int max = Convert.ToInt32(command.ExecuteScalar());

            sqlConnection.Close();

            return max;
        }

        public int GetMaxSimple()
        {
            sqlConnection = new SqlConnection(defaultSettings.connectionString);

            sqlConnection.Open();

            SqlCommand command = new SqlCommand("SELECT MAX(Simple) FROM [Numbers1]", sqlConnection);

            int max = Convert.ToInt32(command.ExecuteScalar());

            sqlConnection.Close();

            return max;
        }

        SqlCommand GetSqlCommand(string command)
        {
            return new SqlCommand(command, sqlConnection);
        }
    }
}