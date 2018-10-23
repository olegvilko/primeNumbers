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

        Sql sql;

        //       SqlConnection sqlConnection;

        void ApplyLanguage()
        {
            FileToolStripMenuItem.Text = language.name.file;
            HelpToolStripMenuItem.Text = language.name.help;
            StartToolStripMenuItem.Text = language.name.start;
            StopToolStripMenuItem.Text = language.name.stop;
            SettingsToolStripMenuItem.Text = language.name.settings;
            getToolStripMenuItem.Text = language.name.get;
            toolStripStatusLabel1.Text = language.name.maxNum;
            toolStripStatusLabel3.Text = language.name.maxSimple;
        }

        void StartOptions()
        {
            defaultSettings = new DefaultSettings();

            language = new Language(defaultSettings.language);

            ApplyLanguage();

            sql = new Sql();

            MaxNumber();

            MaxSimple();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartOptions();

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sql.sqlConnection != null && sql.sqlConnection.State != ConnectionState.Closed)
                sql.sqlConnection.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sql.sqlConnection != null && sql.sqlConnection.State != ConnectionState.Closed)
                sql.sqlConnection.Close();
        }

        private async void ToolStripMenuItemStart_Click(object sender, EventArgs e)
        {
            if (StartToolStripMenuItem.Text == language.name.start)
            {
                StartToolStripMenuItem.Text = language.name.stop;
            }
            else
            {
                StartToolStripMenuItem.Text = language.name.start;
            }

            if (StartToolStripMenuItem.Text == language.name.stop)
            {
                //  sql.AddNum();
                SqlCommand command = new SqlCommand("INSERT INTO [Numbers] (Num)VALUES (@Num)", sql.sqlConnection);
                command.Parameters.AddWithValue("Num", "22");
                await command.ExecuteNonQueryAsync();
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

        private async void getToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            sql.sqlConnection = new SqlConnection(defaultSettings.connectionString);

            await sql.sqlConnection.OpenAsync();

            SqlCommand command = new SqlCommand("SELECT * FROM [Numbers1]", sql.sqlConnection);

            try
            {
                sql.sqlReader = await command.ExecuteReaderAsync();

                while (await sql.sqlReader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(sql.sqlReader["Num"]) + "      " + Convert.ToString(sql.sqlReader["Simple"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sql.sqlReader != null)
                    sql.sqlReader.Close();
            }

            MaxNumber();
            MaxSimple();
          //  toolStripStatusLabel1.Text = Convert.ToString(sql.GetMaxNum());
        }

        void MaxNumber()
        {
            toolStripStatusLabel2.Text= Convert.ToString(sql.GetMaxNum());
        }

        void MaxSimple()
        {
            toolStripStatusLabel4.Text = Convert.ToString(sql.GetMaxSimple());
        }
    }
}
