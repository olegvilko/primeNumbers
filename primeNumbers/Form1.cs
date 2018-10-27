using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Linq;

namespace primeNumbers
{
    public partial class Simple : Form
    {
        Language language;

        Sql sql;

        Maths maths;

        Custom custom;

        delegate bool CheckSimpleMethod(int id);
        CheckSimpleMethod checkSimpleMethod;

        delegate void GetTypeOutput(List<object[]> list, int from, int to);
        GetTypeOutput getTypeOutput;


        Stopwatch stopWatch;

        Maths.MethodCheck methodCheck;

        // TableLayoutPanel tableLayoutPanel;

        void ApplyLanguage()
        {
            this.Text = language.name.nameProject;
            FileToolStripMenuItem.Text = language.name.file;
            HelpToolStripMenuItem.Text = language.name.help;
            StartToolStripMenuItem.Text = language.name.start;
            SettingsToolStripMenuItem.Text = language.name.settings;
            getToolStripButton1.Text = language.name.get;
            toolStripStatusLabel1.Text = language.name.maxNum;
            toolStripStatusLabel3.Text = language.name.maxSimple;
            languageToolStripMenuItem.Text = language.name.language;
            clearDataBaseToolStripMenuItem.Text = language.name.clearDataBase;
            pathToolStripMenuItem.Text = language.name.pathDataBase;
            exitToolStripMenuItem.Text = language.name.exit;
            toolStripMenuItem1.Text = language.name.delay;
            applyToolStripMenuItem.Text = language.name.apply;
            applyToolStripMenuItem1.Text = language.name.apply;
            applyToolStripMenuItem2.Text = language.name.apply;
            toolStripMenuItem2.Text = language.name.countTo;
            timeToolStripStatusLabel.Text = language.name.time;
            saveBackupToolStripMenuItem.Text = language.name.saveBackup;
            loadBackupToolStripMenuItem.Text = language.name.loadBackup;
            methodCheckToolStripMenuItem.Text = language.name.methodCheck;
            simpleToolStripMenuItem.Text = language.name.methodCheckSimple;
            byTableToolStripMenuItem.Text = language.name.methodCheckByTable;
            byArrayToolStripMenuItem.Text = language.name.methodSimpleArray;
            getFromToolStripLabel.Text = language.name.getFrom;
            getToToolStripLabel.Text = language.name.getTo;
            getTypeToolStripDropDownButton.Text = language.name.getType;
            oneColumnToolStripMenuItem.Text = language.name.getTypeOneColumn;
            columnsToolStripLabel.Text = language.name.getColumns;
            //

        }

        void VariableToForm()
        {
            toolStripTextBox1.Text = sql.defaultSettings.connectionString;
            toolStripTextBox2.Text = sql.defaultSettings.threadSleep.ToString();
            toolStripTextBox3.Text = sql.defaultSettings.countTo.ToString();
            getFromToolStripTextBox.Text = sql.defaultSettings.getFrom.ToString();
            getToToolStripTextBox.Text = sql.defaultSettings.getTo.ToString();
            columnsToolStripTextBox.Text = sql.defaultSettings.getColumns.ToString();
        }

        void StartOptions()
        {
            DefaultSettings defaultSettings = new DefaultSettings();

            language = new Language(defaultSettings.language);

            sql = new Sql();

            custom = new Custom();

            ApplyLanguage();

            VariableToForm();

            maths = new Maths();

            MaxId();

            MaxSimple();

            // SimpleMethod();

            ByArrayMethot();
            //Maths.MethodCheck methodCheck = Maths.MethodCheck.CheckSimple;
            getTypeOutput = new GetTypeOutput(GetTypeColumns);

            //PanelInitialization();
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
            Environment.Exit(0);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sql.mySqlConnection != null && sql.mySqlConnection.State != ConnectionState.Closed)
                sql.mySqlConnection.Close();
        }

        private void ToolStripMenuItemStart_Click(object sender, EventArgs e)
        {
            if (StartToolStripMenuItem.Text == language.name.start)
            {
                StartToolStripMenuItem.Text = language.name.stop;

                stopWatch = new Stopwatch();
                stopWatch.Start();
                calculationBackgroundWorker.RunWorkerAsync();
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

        private void ruToolStripMenuItem_Click(object sender, EventArgs e)
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
            DialogResult result = MessageBox.Show(language.name.clearBaseCompleteTheProcess, language.name.clearBaseConfirmAction, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                sql.ClearDatabase();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (StartToolStripMenuItem.Text == language.name.stop)
            {
                int id = sql.GetMaxId() + 1;
                int simple = sql.GetMaxSimple();
                int counter = id;

                if (methodCheck == Maths.MethodCheck.CheckSimpleArray)
                {
                    maths.AddSimpleToArray();
                }

                while (StartToolStripMenuItem.Text == language.name.stop)
                {
                    if (id > sql.defaultSettings.countTo)
                    {
                        calculationBackgroundWorker.ReportProgress(id - 1);

                        break;
                    }

                    if (checkSimpleMethod(id))
                    {
                        sql.InsertSimple((++simple).ToString());
                    }
                    else
                    {
                        sql.InsertSimple("");
                    }
                    id++;

                    if (id - counter >= sql.defaultSettings.timeOutput)
                    {
                        calculationBackgroundWorker.ReportProgress(id);
                        counter = id;
                    }

                    Thread.Sleep(sql.defaultSettings.threadSleep);
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            timeCounter.Text = stopWatch.Elapsed.ToString();
            toolStripStatusLabel2.Text = e.ProgressPercentage.ToString();
            MaxSimple();
            if (Convert.ToInt32(e.ProgressPercentage) >= sql.defaultSettings.countTo)
            {
                message.Text = language.name.logCountTo + sql.defaultSettings.countTo.ToString();
                StartToolStripMenuItem.Text = language.name.start;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            stopWatch.Stop();
        }

        private void applyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sql.defaultSettings.connectionString = toolStripTextBox1.Text;
            sql.NewConnection();
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

        private void applyToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            sql.defaultSettings.countTo = Convert.ToInt32(toolStripTextBox3.Text);
        }

        private void saveBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sql.CopyTable(sql.defaultSettings.table, sql.defaultSettings.tableBackup);
        }

        private void loadBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sql.CopyTable(sql.defaultSettings.tableBackup, sql.defaultSettings.table);
        }

        void MethodKeyColorClear()
        {
            simpleToolStripMenuItem.BackColor = SystemColors.Control;
            byTableToolStripMenuItem.BackColor = SystemColors.Control;
            byArrayToolStripMenuItem.BackColor = SystemColors.Control;
        }
        #region Methods
        void SimpleMethod()
        {
            MethodKeyColorClear();
            simpleToolStripMenuItem.BackColor = SystemColors.ControlLight;
            checkSimpleMethod = new CheckSimpleMethod(maths.CheckSimple);
            methodCheck = Maths.MethodCheck.CheckSimple;
        }

        void ByTableMethod()
        {
            MethodKeyColorClear();
            byTableToolStripMenuItem.BackColor = SystemColors.ControlLight;
            checkSimpleMethod = new CheckSimpleMethod(maths.CheckSimpleByTable);
            methodCheck = Maths.MethodCheck.CheckSimpleByTable;
        }

        void ByArrayMethot()
        {
            MethodKeyColorClear();
            byArrayToolStripMenuItem.BackColor = SystemColors.ControlLight;
            checkSimpleMethod = new CheckSimpleMethod(maths.CheckSimpleArray);
            methodCheck = Maths.MethodCheck.CheckSimpleArray;
        }

        private void simpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimpleMethod();
        }

        private void byTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ByTableMethod();
        }

        private void byArrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ByArrayMethot();
        }
        #endregion
        private void getToolStripButton1_Click(object sender, EventArgs e)
        {
            StartGetNumbersToScreen();
        }

        void GetTypeOneColumn(List<object[]> list, int from, int to)
        {
            //   PanelInitialization();

            int column = Convert.ToInt32(columnsToolStripTextBox.Text);
            //      int j = 0;
            //        int row = 0;
            for (int i = from; i < to; i++)
            {


                // listBox1.Items.Add(list[i][(int)Sql.Table.id].ToString() + " " + list[i][(int)Sql.Table.simple].ToString());
                //  string str = list[i][(int)Sql.Table.id].ToString();
                //  int simple = (int)list[i][(int)Sql.Table.simple];
                //Color color;
                //if (simple != 0)
                //{
                //    color = Color.White;
                //}
                //else
                //{
                //    color = SystemColors.Control;
                //}
                //AddToPanel(str, j, row, color);
                //j++;
                //if (j > column)
                //{
                //    j = 0;
                //    row += 1;
                //}
            }
        }

        void GetTypeColumns(List<object[]> list, int from, int to)
        {
            int columns = Convert.ToInt32(columnsToolStripTextBox.Text);

            for (int j = from; j < to; j += columns)
            {
                string str = null;
                for (int i = j; i < j + columns; i++)
                {
                    if (custom.ColumnVisible(i - j))
                    {
                        if (i > to) break;
                        int id = (int)list[i][(int)Sql.Table.id];
                        int simple = (int)list[i][(int)Sql.Table.simple];

                        string idStr = "";
                        if (custom.IsVisible(id, simple)) idStr = id.ToString();

                        if (custom.AllotmentString(id, simple)) idStr = maths.AllotmentString(idStr, sql.defaultSettings.allotmentLeft, sql.defaultSettings.AllotmentRigth);


                        str += maths.AlignmentString(idStr, sql.defaultSettings.lengthOutput);
                    }
                }
                AddToLisbox(str);
            }
        }

        void StartGetNumbersToScreen()
        {
            listBox1.Items.Clear();

            List<object[]> list = sql.SelectReader("*");

            int from = Convert.ToInt32(getFromToolStripTextBox.Text);
            int to = Convert.ToInt32(getToToolStripTextBox.Text);
            int listCount = list.Count;

            if (from > listCount) from = listCount;
            if (to > listCount) to = listCount;

            getTypeOutput(list, from, to);

            MaxId();
            MaxSimple();
        }

        private void toolStripTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void toolStripTextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void columnsToolStripTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            getTypeOutput = new GetTypeOutput(GetTypeOneColumn);
        }

        private void columnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getTypeOutput = new GetTypeOutput(GetTypeColumns);
        }

        #region Lisbox
        public void AddToLisbox(string str)
        {

            listBox1.Items.Add(str);
        }


        #endregion

        #region Panel
        //public void AddToPanel(string str, int column, int row, Color color)
        //{
        //    //  panel.Controls.Add(new Label() { Text = str, BackColor = color }, column, row);
        //    //panel.Controls.Add(new Label() { Text = str, BackColor = color }, column, row);
        //    // tableLayoutPanel.Controls.Add(new Label() { Text = str, BackColor = color }, column, row);
        //}

        //void PanelInitialization()
        //{
        //    int column = Convert.ToInt32(columnsToolStripTextBox.Text);
        //    int row = 100;
        //    panel.ColumnCount = column;
        //    panel.RowCount = row;
        //    panel.AutoSize = true;
        //    //panel.size

        //    for (int i = 0; i < column; i++)
        //        panel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300));

        //    for (int i = 0; i < row; i++)
        //        panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));

        //    //panel.an
        //    //tableLayoutPanel = new TableLayoutPanel
        //    //{
        //    //    Parent = this,
        //    //    CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset,
        //    //    AutoSize = true,
        //    //    AutoSizeMode = AutoSizeMode.GrowAndShrink,
        //    //    Dock=DockStyle.Fill
        //    //};

        //    //  tableLayoutPanel.ColumnCount = column;
        //    //  tableLayoutPanel.RowCount = row;

        //    //  panel.Controls.Add(new Label() { Text = "Street, City, State" }, 1, panel.RowCount - 1);
        //}
        #endregion

        #region Message
        void Message(string mes)
        {
            message.Text = mes;
        }

        void Message(int mes)
        {
            message.Text = mes.ToString();
        }
        #endregion

        private void FormulaCheckToolStripButton_Click(object sender, EventArgs e)
        {
            int from = Convert.ToInt32(getFromToolStripTextBox.Text);

            int to = Convert.ToInt32(getToToolStripTextBox.Text);

            int length = sql.GetMaxId();

            if (from > length) from = length;

            if (to > length) to = length;

            custom.FormulaCheck(from, to, listBox1);
        }

        private void clipBoardToolStripButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(string.Join(Environment.NewLine, listBox1.Items.OfType<string>().ToArray()));
        }
    }
}
