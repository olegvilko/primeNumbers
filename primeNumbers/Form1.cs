using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Linq;

namespace primeNumbers
{
    public partial class Simple : Form
    {
        Language language = new Language(DefaultSettings.language);
        Logics logics = new Logics();
        Stopwatch stopWatch;

        public Simple()
        {
            InitializeComponent();
        }

        #region Interface
        private void Form1_Load(object sender, EventArgs e)
        {
            StartOptions();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logics.ExitProgramm();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            logics.ExitProgramm();
        }

        private void ToolStripMenuItemStart_Click(object sender, EventArgs e)
        {
            if (logics.calculationState == Logics.CalculationState.Start)
            {
                logics.calculationState = Logics.CalculationState.Stop;
                StartToolStripMenuItem.Text = language.text.stop;
                stopWatch = new Stopwatch();
                stopWatch.Start();
                calculationBackgroundWorker.RunWorkerAsync();
            }
            else
            {
                logics.calculationState = Logics.CalculationState.Start;
                StartToolStripMenuItem.Text = language.text.start;
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

        private void clearDataBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(language.text.clearBaseCompleteTheProcess, language.text.clearBaseConfirmAction, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                logics.clearDataBase();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int countTo = Convert.ToInt32(countToStripTextBox.Text);
            logics.CalculationPrimeNumbers(calculationBackgroundWorker, countTo);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            timeCounter.Text = stopWatch.Elapsed.ToString();
            maxIdToolStripStatusLabel.Text = e.ProgressPercentage.ToString();
            MaxSimple();
            if (Convert.ToInt32(e.ProgressPercentage) >= DefaultSettings.countTo)
            {
                message.Text = language.text.logCountTo + DefaultSettings.countTo.ToString();
                StartToolStripMenuItem.Text = language.text.start;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            stopWatch.Stop();
        }

        private void applyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DefaultSettings.connectionString = toolStripTextBox1.Text;
            logics.NewConnection();
        }

        private void applyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DefaultSettings.threadSleep = Convert.ToInt32(toolStripTextBox2.Text);
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
            DefaultSettings.countTo = Convert.ToInt32(countToStripTextBox.Text);
        }

        private void saveBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(language.text.saveConfirmAction, language.text.clearBaseConfirmAction, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                logics.CopyTable(DefaultSettings.table, DefaultSettings.tableBackup);
        }

        private void loadBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(language.text.loadConfirmAction, language.text.clearBaseConfirmAction, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                logics.CopyTable(DefaultSettings.tableBackup, DefaultSettings.table);
        }

        private void getToolStripButton1_Click(object sender, EventArgs e)
        {
            StartGetNumbersToScreen();
        }

        private void toolStripTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumber(e);
        }

        private void toolStripTextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumber(e);
        }

        private void columnsToolStripTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumber(e);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            //  getTypeOutput = new GetTypeOutput(GetTypeOneColumn);
        }

        private void columnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //    getTypeOutput = new GetTypeOutput(maths.GetTypeColumns);
        }

        private void FormulaCheckToolStripButton_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            var from = Convert.ToInt32(getFromToolStripTextBox.Text);
            var to = Convert.ToInt32(getToToolStripTextBox.Text);
            logics.OwnAlgorithm(from, to, listBox);
        }

        private void clipBoardToolStripButton_Click(object sender, EventArgs e)
        {
            if (listBox.Items.Count != 0)
                Clipboard.SetText(string.Join(Environment.NewLine, listBox.Items.OfType<string>().ToArray()));
        }

        private void aboutTheProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(language.text.aboutTheProgramText);
        }

        private void createTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logics.CreateTables();
        }
        #endregion

        #region Methods
        void MethodKeyColorClear()
        {
            simpleToolStripMenuItem.BackColor = SystemColors.Control;
            byTableToolStripMenuItem.BackColor = SystemColors.Control;
            byArrayToolStripMenuItem.BackColor = SystemColors.Control;
        }

        void SimpleMethod()
        {
            MethodKeyColorClear();
            simpleToolStripMenuItem.BackColor = SystemColors.ControlLight;
            logics.checkSimpleMethod = new Logics.CheckSimpleMethod(logics.CheckSimple);
            logics.methodCheck = Logics.MethodCheck.CheckSimple;
        }

        void ByTableMethod()
        {
            MethodKeyColorClear();
            byTableToolStripMenuItem.BackColor = SystemColors.ControlLight;
            logics.checkSimpleMethod = new Logics.CheckSimpleMethod(logics.CheckSimpleByTable);
            logics.methodCheck = Logics.MethodCheck.CheckSimpleByTable;
        }

        void ByArrayMethot()
        {
            MethodKeyColorClear();
            byArrayToolStripMenuItem.BackColor = SystemColors.ControlLight;
            logics.checkSimpleMethod = new Logics.CheckSimpleMethod(logics.CheckSimpleArray);
            logics.methodCheck = Logics.MethodCheck.CheckSimpleArray;
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

        #region Private
        private void ApplyLanguage()
        {
            this.Text = language.text.nameProject;
            FileToolStripMenuItem.Text = language.text.file;
            HelpToolStripMenuItem.Text = language.text.help;
            StartToolStripMenuItem.Text = language.text.start;
            SettingsToolStripMenuItem.Text = language.text.settings;
            getToolStripButton1.Text = language.text.get;
            toolStripStatusLabel1.Text = language.text.maxNum;
            toolStripStatusLabel3.Text = language.text.maxSimple;
            languageToolStripMenuItem.Text = language.text.language;
            clearDataBaseToolStripMenuItem.Text = language.text.clearDataBase;
            pathToolStripMenuItem.Text = language.text.pathDataBase;
            exitToolStripMenuItem.Text = language.text.exit;
            toolStripMenuItem1.Text = language.text.delay;
            applyToolStripMenuItem.Text = language.text.apply;
            applyToolStripMenuItem1.Text = language.text.apply;
            applyToolStripMenuItem2.Text = language.text.apply;
            countToToolStripMenuItem.Text = language.text.countTo;
            timeToolStripStatusLabel.Text = language.text.time;
            saveBackupToolStripMenuItem.Text = language.text.saveBackup;
            loadBackupToolStripMenuItem.Text = language.text.loadBackup;
            methodCheckToolStripMenuItem.Text = language.text.methodCheck;
            simpleToolStripMenuItem.Text = language.text.methodCheckSimple;
            byTableToolStripMenuItem.Text = language.text.methodCheckByTable;
            byArrayToolStripMenuItem.Text = language.text.methodSimpleArray;
            getFromToolStripLabel.Text = language.text.getFrom;
            getToToolStripLabel.Text = language.text.getTo;
            getTypeToolStripDropDownButton.Text = language.text.getType;
            oneColumnToolStripMenuItem.Text = language.text.getTypeOneColumn;
            columnsToolStripLabel.Text = language.text.getColumns;
            aboutTheProgramToolStripMenuItem.Text = language.text.aboutTheProgram;
            ownToolStripButton.Text = language.text.ownAlgorithm;
            clipBoardToolStripButton.Text = language.text.clipBoard;
            createTableToolStripMenuItem.Text = language.text.createTables;
        }

        private void VariableToForm()
        {
            toolStripTextBox1.Text = DefaultSettings.connectionString;
            toolStripTextBox2.Text = DefaultSettings.threadSleep.ToString();
            countToStripTextBox.Text = DefaultSettings.countTo.ToString();
            getFromToolStripTextBox.Text = DefaultSettings.getFrom.ToString();
            getToToolStripTextBox.Text = DefaultSettings.getTo.ToString();
            columnsToolStripTextBox.Text = DefaultSettings.getColumns.ToString();
        }

        private void StartOptions()
        {
            ApplyLanguage();
            VariableToForm();
            SimpleMethod();
        }

        private void StartGetNumbersToScreen()
        {
            listBox.Items.Clear();
            int from = Convert.ToInt32(getFromToolStripTextBox.Text);
            int to = Convert.ToInt32(getToToolStripTextBox.Text);
            int columns = Convert.ToInt32(columnsToolStripTextBox.Text);
            logics.GetTypeColumns(listBox, from, to, columns);
            MaxId();
            MaxSimple();
        }

        private bool OnlyNumber(KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
            return false;
        }

        private void MaxId()
        {
            maxIdToolStripStatusLabel.Text = logics.MaxId();
        }

        private void MaxSimple()
        {
            maxSimpleToolStripStatusLabel.Text = logics.MaxSimple();
        }

        #region Message
        private void Message(string mes)
        {
            message.Text = mes;
        }

        private void Message(int mes)
        {
            message.Text = mes.ToString();
        }
        #endregion
        #endregion
    }
}
