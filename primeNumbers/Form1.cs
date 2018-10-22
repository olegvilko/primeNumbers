using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace primeNumbers
{
    public partial class Form1 : Form
    {
        DefaultSettings defaultSettings;

        Language language;

        SqlConnection sqlConnection;

        void ApplyLanguage()
        {
            FileToolStripMenuItem.Text = language.name.file;
            HelpToolStripMenuItem.Text = language.name.help;
            StartToolStripMenuItem.Text = language.name.start;
            StopToolStripMenuItem.Text = language.name.stop;
            SettingsToolStripMenuItem.Text = language.name.settings;
        }

        void StartOptions()
        {
            defaultSettings = new DefaultSettings();

            language = new Language(defaultSettings.language);

            ApplyLanguage();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            StartOptions();


            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\helgi\source\repos\primeNumbers\primeNumbers\Database1.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            await sqlConnection.OpenAsync();

            SqlDataReader sqlReader = null;

            SqlCommand command = new SqlCommand("SELECT * FROM [Numbers]", sqlConnection);

            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString((sqlReader["Id"]) + "        " + Convert.ToString(sqlReader["Num"]) + "      " + Convert.ToString(sqlReader["NumId"])));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
        }

        private void ToolStripMenuItemStart_Click(object sender, EventArgs e)
        {
            if (StartToolStripMenuItem.Text == language.name.start)
            {
                StartToolStripMenuItem.Text = language.name.stop;
            }
            else
            {
                StartToolStripMenuItem.Text = language.name.start;
            }
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            language = new Language(language.en);

            ApplyLanguage();
        }

        private void русскийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            language = new Language(language.ru);

            ApplyLanguage();
        }
    }
}
