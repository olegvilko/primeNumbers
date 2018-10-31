namespace primeNumbers
{
    partial class Simple
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Simple));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.русскийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearDataBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.applyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.applyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.countToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countToStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.applyToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.methodCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byArrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTheProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.maxIdToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.maxSimpleToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timeToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timeCounter = new System.Windows.Forms.ToolStripStatusLabel();
            this.message = new System.Windows.Forms.ToolStripStatusLabel();
            this.calculationBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.getToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.getFromToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.getFromToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.getToToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.getToToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.columnsToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.columnsToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.getTypeToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.oneColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.columnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ownToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.clipBoardToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.listBox = new System.Windows.Forms.ListBox();
            this.createTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.StartToolStripMenuItem,
            this.SettingsToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1384, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveBackupToolStripMenuItem,
            this.loadBackupToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // saveBackupToolStripMenuItem
            // 
            this.saveBackupToolStripMenuItem.Name = "saveBackupToolStripMenuItem";
            this.saveBackupToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveBackupToolStripMenuItem.Text = "Save";
            this.saveBackupToolStripMenuItem.Click += new System.EventHandler(this.saveBackupToolStripMenuItem_Click);
            // 
            // loadBackupToolStripMenuItem
            // 
            this.loadBackupToolStripMenuItem.Name = "loadBackupToolStripMenuItem";
            this.loadBackupToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadBackupToolStripMenuItem.Text = "Load";
            this.loadBackupToolStripMenuItem.Click += new System.EventHandler(this.loadBackupToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // StartToolStripMenuItem
            // 
            this.StartToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.StartToolStripMenuItem.Name = "StartToolStripMenuItem";
            this.StartToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.StartToolStripMenuItem.Text = "Start";
            this.StartToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemStart_Click);
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem,
            this.clearDataBaseToolStripMenuItem,
            this.pathToolStripMenuItem,
            this.toolStripMenuItem1,
            this.countToToolStripMenuItem,
            this.methodCheckToolStripMenuItem,
            this.createTableToolStripMenuItem});
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.SettingsToolStripMenuItem.Text = "Settings";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.русскийToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // русскийToolStripMenuItem
            // 
            this.русскийToolStripMenuItem.Name = "русскийToolStripMenuItem";
            this.русскийToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.русскийToolStripMenuItem.Text = "Русский";
            this.русскийToolStripMenuItem.Click += new System.EventHandler(this.ruToolStripMenuItem_Click);
            // 
            // clearDataBaseToolStripMenuItem
            // 
            this.clearDataBaseToolStripMenuItem.Name = "clearDataBaseToolStripMenuItem";
            this.clearDataBaseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearDataBaseToolStripMenuItem.Text = "Clear DataBase";
            this.clearDataBaseToolStripMenuItem.Click += new System.EventHandler(this.clearDataBaseToolStripMenuItem_Click);
            // 
            // pathToolStripMenuItem
            // 
            this.pathToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.applyToolStripMenuItem});
            this.pathToolStripMenuItem.Name = "pathToolStripMenuItem";
            this.pathToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pathToolStripMenuItem.Text = "Path";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.SystemColors.Info;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(400, 23);
            // 
            // applyToolStripMenuItem
            // 
            this.applyToolStripMenuItem.Name = "applyToolStripMenuItem";
            this.applyToolStripMenuItem.Size = new System.Drawing.Size(460, 22);
            this.applyToolStripMenuItem.Text = "Apply";
            this.applyToolStripMenuItem.Click += new System.EventHandler(this.applyToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox2,
            this.applyToolStripMenuItem1});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "Delay";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.BackColor = System.Drawing.SystemColors.Info;
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBox2_KeyPress);
            // 
            // applyToolStripMenuItem1
            // 
            this.applyToolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.applyToolStripMenuItem1.BackColor = System.Drawing.SystemColors.Control;
            this.applyToolStripMenuItem1.Name = "applyToolStripMenuItem1";
            this.applyToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.applyToolStripMenuItem1.Text = "Apply";
            this.applyToolStripMenuItem1.Click += new System.EventHandler(this.applyToolStripMenuItem1_Click);
            // 
            // countToToolStripMenuItem
            // 
            this.countToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countToStripTextBox,
            this.applyToolStripMenuItem2});
            this.countToToolStripMenuItem.Name = "countToToolStripMenuItem";
            this.countToToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.countToToolStripMenuItem.Text = "Count to";
            // 
            // countToStripTextBox
            // 
            this.countToStripTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.countToStripTextBox.Name = "countToStripTextBox";
            this.countToStripTextBox.Size = new System.Drawing.Size(100, 23);
            this.countToStripTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBox3_KeyPress);
            // 
            // applyToolStripMenuItem2
            // 
            this.applyToolStripMenuItem2.Name = "applyToolStripMenuItem2";
            this.applyToolStripMenuItem2.Size = new System.Drawing.Size(160, 22);
            this.applyToolStripMenuItem2.Text = "Apply";
            this.applyToolStripMenuItem2.Click += new System.EventHandler(this.applyToolStripMenuItem2_Click);
            // 
            // methodCheckToolStripMenuItem
            // 
            this.methodCheckToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simpleToolStripMenuItem,
            this.byTableToolStripMenuItem,
            this.byArrayToolStripMenuItem});
            this.methodCheckToolStripMenuItem.Name = "methodCheckToolStripMenuItem";
            this.methodCheckToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.methodCheckToolStripMenuItem.Text = "Method check";
            // 
            // simpleToolStripMenuItem
            // 
            this.simpleToolStripMenuItem.Name = "simpleToolStripMenuItem";
            this.simpleToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.simpleToolStripMenuItem.Text = "Simple";
            this.simpleToolStripMenuItem.Click += new System.EventHandler(this.simpleToolStripMenuItem_Click);
            // 
            // byTableToolStripMenuItem
            // 
            this.byTableToolStripMenuItem.Name = "byTableToolStripMenuItem";
            this.byTableToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.byTableToolStripMenuItem.Text = "By table";
            this.byTableToolStripMenuItem.Click += new System.EventHandler(this.byTableToolStripMenuItem_Click);
            // 
            // byArrayToolStripMenuItem
            // 
            this.byArrayToolStripMenuItem.Name = "byArrayToolStripMenuItem";
            this.byArrayToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.byArrayToolStripMenuItem.Text = "By array";
            this.byArrayToolStripMenuItem.Click += new System.EventHandler(this.byArrayToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutTheProgramToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem.Text = "Help";
            // 
            // aboutTheProgramToolStripMenuItem
            // 
            this.aboutTheProgramToolStripMenuItem.Name = "aboutTheProgramToolStripMenuItem";
            this.aboutTheProgramToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.aboutTheProgramToolStripMenuItem.Text = "About the program";
            this.aboutTheProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutTheProgramToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.maxIdToolStripStatusLabel,
            this.toolStripStatusLabel3,
            this.maxSimpleToolStripStatusLabel,
            this.timeToolStripStatusLabel,
            this.timeCounter,
            this.message});
            this.statusStrip1.Location = new System.Drawing.Point(0, 739);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1384, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // maxIdToolStripStatusLabel
            // 
            this.maxIdToolStripStatusLabel.Name = "maxIdToolStripStatusLabel";
            this.maxIdToolStripStatusLabel.Size = new System.Drawing.Size(13, 17);
            this.maxIdToolStripStatusLabel.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // maxSimpleToolStripStatusLabel
            // 
            this.maxSimpleToolStripStatusLabel.Name = "maxSimpleToolStripStatusLabel";
            this.maxSimpleToolStripStatusLabel.Size = new System.Drawing.Size(13, 17);
            this.maxSimpleToolStripStatusLabel.Text = "0";
            // 
            // timeToolStripStatusLabel
            // 
            this.timeToolStripStatusLabel.Name = "timeToolStripStatusLabel";
            this.timeToolStripStatusLabel.Size = new System.Drawing.Size(37, 17);
            this.timeToolStripStatusLabel.Text = "Time:";
            // 
            // timeCounter
            // 
            this.timeCounter.Name = "timeCounter";
            this.timeCounter.Size = new System.Drawing.Size(0, 17);
            // 
            // message
            // 
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 17);
            // 
            // calculationBackgroundWorker
            // 
            this.calculationBackgroundWorker.WorkerReportsProgress = true;
            this.calculationBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.calculationBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.calculationBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.getToolStripButton1,
            this.getFromToolStripLabel,
            this.getFromToolStripTextBox,
            this.getToToolStripLabel,
            this.getToToolStripTextBox,
            this.columnsToolStripLabel,
            this.columnsToolStripTextBox,
            this.getTypeToolStripDropDownButton,
            this.ownToolStripButton,
            this.toolStripSeparator1,
            this.clipBoardToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1384, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(31, 22);
            this.toolStripLabel1.Text = "F(x):";
            // 
            // getToolStripButton1
            // 
            this.getToolStripButton1.BackColor = System.Drawing.Color.Gainsboro;
            this.getToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.getToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("getToolStripButton1.Image")));
            this.getToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.getToolStripButton1.Name = "getToolStripButton1";
            this.getToolStripButton1.Size = new System.Drawing.Size(29, 22);
            this.getToolStripButton1.Text = "Get";
            this.getToolStripButton1.Click += new System.EventHandler(this.getToolStripButton1_Click);
            // 
            // getFromToolStripLabel
            // 
            this.getFromToolStripLabel.Name = "getFromToolStripLabel";
            this.getFromToolStripLabel.Size = new System.Drawing.Size(36, 22);
            this.getFromToolStripLabel.Text = "from:";
            // 
            // getFromToolStripTextBox
            // 
            this.getFromToolStripTextBox.Name = "getFromToolStripTextBox";
            this.getFromToolStripTextBox.Size = new System.Drawing.Size(50, 25);
            this.getFromToolStripTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBox4_KeyPress);
            // 
            // getToToolStripLabel
            // 
            this.getToToolStripLabel.Name = "getToToolStripLabel";
            this.getToToolStripLabel.Size = new System.Drawing.Size(21, 22);
            this.getToToolStripLabel.Text = "to:";
            // 
            // getToToolStripTextBox
            // 
            this.getToToolStripTextBox.Name = "getToToolStripTextBox";
            this.getToToolStripTextBox.Size = new System.Drawing.Size(50, 25);
            this.getToToolStripTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBox5_KeyPress);
            // 
            // columnsToolStripLabel
            // 
            this.columnsToolStripLabel.Name = "columnsToolStripLabel";
            this.columnsToolStripLabel.Size = new System.Drawing.Size(56, 22);
            this.columnsToolStripLabel.Text = "columns:";
            // 
            // columnsToolStripTextBox
            // 
            this.columnsToolStripTextBox.Name = "columnsToolStripTextBox";
            this.columnsToolStripTextBox.Size = new System.Drawing.Size(50, 25);
            this.columnsToolStripTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.columnsToolStripTextBox_KeyPress);
            // 
            // getTypeToolStripDropDownButton
            // 
            this.getTypeToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.getTypeToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oneColumnToolStripMenuItem,
            this.columnsToolStripMenuItem});
            this.getTypeToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("getTypeToolStripDropDownButton.Image")));
            this.getTypeToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.getTypeToolStripDropDownButton.Name = "getTypeToolStripDropDownButton";
            this.getTypeToolStripDropDownButton.Size = new System.Drawing.Size(64, 22);
            this.getTypeToolStripDropDownButton.Text = "Get type";
            this.getTypeToolStripDropDownButton.Visible = false;
            // 
            // oneColumnToolStripMenuItem
            // 
            this.oneColumnToolStripMenuItem.Name = "oneColumnToolStripMenuItem";
            this.oneColumnToolStripMenuItem.Size = new System.Drawing.Size(324, 22);
            this.oneColumnToolStripMenuItem.Text = "One column, number and count prime number";
            this.oneColumnToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // columnsToolStripMenuItem
            // 
            this.columnsToolStripMenuItem.Name = "columnsToolStripMenuItem";
            this.columnsToolStripMenuItem.Size = new System.Drawing.Size(324, 22);
            this.columnsToolStripMenuItem.Text = "Columns";
            this.columnsToolStripMenuItem.Click += new System.EventHandler(this.columnsToolStripMenuItem_Click);
            // 
            // ownToolStripButton
            // 
            this.ownToolStripButton.BackColor = System.Drawing.Color.Gainsboro;
            this.ownToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ownToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ownToolStripButton.Image")));
            this.ownToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ownToolStripButton.Name = "ownToolStripButton";
            this.ownToolStripButton.Size = new System.Drawing.Size(36, 22);
            this.ownToolStripButton.Text = "Own";
            this.ownToolStripButton.Click += new System.EventHandler(this.FormulaCheckToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // clipBoardToolStripButton
            // 
            this.clipBoardToolStripButton.BackColor = System.Drawing.Color.Gainsboro;
            this.clipBoardToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.clipBoardToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("clipBoardToolStripButton.Image")));
            this.clipBoardToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clipBoardToolStripButton.Name = "clipBoardToolStripButton";
            this.clipBoardToolStripButton.Size = new System.Drawing.Size(66, 22);
            this.clipBoardToolStripButton.Text = "Clip Board";
            this.clipBoardToolStripButton.Click += new System.EventHandler(this.clipBoardToolStripButton_Click);
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.SystemColors.Menu;
            this.listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox.FormattingEnabled = true;
            this.listBox.HorizontalScrollbar = true;
            this.listBox.ItemHeight = 14;
            this.listBox.Location = new System.Drawing.Point(0, 49);
            this.listBox.Name = "listBox";
            this.listBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox.Size = new System.Drawing.Size(1384, 690);
            this.listBox.TabIndex = 6;
            // 
            // createTableToolStripMenuItem
            // 
            this.createTableToolStripMenuItem.Name = "createTableToolStripMenuItem";
            this.createTableToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createTableToolStripMenuItem.Text = "Create table";
            this.createTableToolStripMenuItem.Click += new System.EventHandler(this.createTableToolStripMenuItem_Click);
            // 
            // Simple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Simple";
            this.Text = "Simple numbers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem русскийToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel maxIdToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel maxSimpleToolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem clearDataBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pathToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.ComponentModel.BackgroundWorker calculationBackgroundWorker;
        private System.Windows.Forms.ToolStripMenuItem applyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripMenuItem applyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem countToToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox countToStripTextBox;
        private System.Windows.Forms.ToolStripStatusLabel message;
        private System.Windows.Forms.ToolStripMenuItem applyToolStripMenuItem2;
        private System.Windows.Forms.ToolStripStatusLabel timeToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel timeCounter;
        private System.Windows.Forms.ToolStripMenuItem saveBackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadBackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem methodCheckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byArrayToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox getFromToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel getFromToolStripLabel;
        private System.Windows.Forms.ToolStripLabel getToToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox getToToolStripTextBox;
        private System.Windows.Forms.ToolStripButton getToolStripButton1;
        private System.Windows.Forms.ToolStripDropDownButton getTypeToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem oneColumnToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel columnsToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox columnsToolStripTextBox;
        private System.Windows.Forms.ToolStripMenuItem columnsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton ownToolStripButton;
        private System.Windows.Forms.ToolStripButton clipBoardToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.ToolStripMenuItem aboutTheProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createTableToolStripMenuItem;
    }
}

