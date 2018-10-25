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
using MySql.Data.MySqlClient;
using System.Threading;

namespace primeNumbers
{
    public partial class Simple : Form
    {
      //  DefaultSettings defaultSettings;

        Language language;

        Sql sql;

        Maths maths;

       // BackgroundWorker background;

        //       SqlConnection sqlConnection;

        void ApplyLanguage()
        {
            this.Text = language.name.nameProject;
            FileToolStripMenuItem.Text = language.name.file;
            HelpToolStripMenuItem.Text = language.name.help;
            StartToolStripMenuItem.Text = language.name.start;
            SettingsToolStripMenuItem.Text = language.name.settings;
            getToolStripMenuItem.Text = language.name.get;
            toolStripStatusLabel1.Text = language.name.maxNum;
            toolStripStatusLabel3.Text = language.name.maxSimple;
            languageToolStripMenuItem.Text = language.name.language;
            clearDataBaseToolStripMenuItem.Text = language.name.clearDataBase;
            pathToolStripMenuItem.Text = language.name.pathDataBase;
            exitToolStripMenuItem.Text = language.name.exit;
            toolStripMenuItem1.Text = language.name.delay;
            applyToolStripMenuItem1.Text = language.name.applay;
            applyToolStripMenuItem.Text = language.name.applay;

            //
            toolStripTextBox1.Text = sql.defaultSettings.connectionString;
            toolStripTextBox2.Text = sql.defaultSettings.threadSleep.ToString();
        }

        void StartOptions()
        {
            DefaultSettings defaultSettings = new DefaultSettings();

            language = new Language(defaultSettings.language);

            sql = new Sql();

            ApplyLanguage();

           

            maths = new Maths();

            MaxId();

            MaxSimple();
        }

        public Simple()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartOptions();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sql.mySqlConnection != null && sql.mySqlConnection.State != ConnectionState.Closed)
                sql.mySqlConnection.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sql.mySqlConnection != null && sql.mySqlConnection.State != ConnectionState.Closed)
                sql.mySqlConnection.Close();
        }

        void NextSimple(int times)
        {
            if (StartToolStripMenuItem.Text == language.name.stop)
            {
                int id = sql.GetMaxId() + 1;
                int simple = sql.GetMaxSimple();

                while (StartToolStripMenuItem.Text == language.name.stop)
                {
                    if (maths.CheckSimple(id))
                    {
                        sql.InsertSimple((++simple).ToString());
                    }
                    else
                    {
                        sql.InsertSimple("");
                    }
                    id++;
                    
                    Thread.Sleep(sql.defaultSettings.threadSleep);
                }
            }
        }

        private void ToolStripMenuItemStart_Click(object sender, EventArgs e)
        {
            if (StartToolStripMenuItem.Text == language.name.start)
            {
                StartToolStripMenuItem.Text = language.name.stop;

                backgroundWorker1.RunWorkerAsync();
            
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

        private void getToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            List<object[]> list = sql.SelectReader("*");

            for (int i = 0; i < list.Count; i++)
                listBox1.Items.Add(list[i][(int)Sql.Table.id].ToString() + " " + list[i][(int)Sql.Table.simple].ToString());

            MaxId();
            MaxSimple();
        }

        void MaxId()
        {
            toolStripStatusLabel2.Text = Convert.ToString(sql.GetMaxId());
        }

        void MaxSimple()
        {
            toolStripStatusLabel4.Text = Convert.ToString(sql.GetMaxSimple());
        }

        private void clearDataBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sql.ClearDatabase();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (StartToolStripMenuItem.Text == language.name.stop)
            {
                int id = sql.GetMaxId() + 1;
                int simple = sql.GetMaxSimple();

                while (StartToolStripMenuItem.Text == language.name.stop)
                {
                    if (maths.CheckSimple(id))
                    {
                        sql.InsertSimple((++simple).ToString());
                    }
                    else
                    {
                        sql.InsertSimple("");
                    }
                    id++;

                    backgroundWorker1.ReportProgress(id);

                    Thread.Sleep(sql.defaultSettings.threadSleep);
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolStripStatusLabel2.Text = e.ProgressPercentage.ToString();
            MaxSimple();
        }

        private void applyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sql.defaultSettings.connectionString = toolStripTextBox1.Text;
            sql.Connect();
        }

        private void applyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sql.defaultSettings.threadSleep = Convert.ToInt32(toolStripTextBox2.Text);
        }

        private void toolStripTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) 
            {
                e.Handled = true;
            }
        }

        private void toolStripTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
