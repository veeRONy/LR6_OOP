using System.Drawing;

namespace WindowsFormsApp1
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("Умыться");
            System.Windows.Forms.TreeNode treeNode58 = new System.Windows.Forms.TreeNode("Завтрак");
            System.Windows.Forms.TreeNode treeNode59 = new System.Windows.Forms.TreeNode("Утром:", new System.Windows.Forms.TreeNode[] {
            treeNode57,
            treeNode58});
            System.Windows.Forms.TreeNode treeNode60 = new System.Windows.Forms.TreeNode("Сделать дз");
            System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("Днем:", new System.Windows.Forms.TreeNode[] {
            treeNode60});
            System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("Прогулка");
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("Вечером:", new System.Windows.Forms.TreeNode[] {
            treeNode62});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnOK = new System.Windows.Forms.Button();
            this.chbLaba = new System.Windows.Forms.CheckBox();
            this.chbReport = new System.Windows.Forms.CheckBox();
            this.lbCoordX = new System.Windows.Forms.Label();
            this.lbCoordY = new System.Windows.Forms.Label();
            this.cb = new System.Windows.Forms.ComboBox();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.pbCats = new System.Windows.Forms.PictureBox();
            this.btnClickMe = new System.Windows.Forms.Button();
            this.btnMouse = new System.Windows.Forms.Button();
            this.pnl = new System.Windows.Forms.Panel();
            this.lbDay = new System.Windows.Forms.Label();
            this.clndr = new System.Windows.Forms.MonthCalendar();
            this.tbSchedule = new System.Windows.Forms.TextBox();
            this.tbMouse = new System.Windows.Forms.TextBox();
            this.rbColorful = new System.Windows.Forms.RadioButton();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.nmr = new System.Windows.Forms.NumericUpDown();
            this.linklb = new System.Windows.Forms.LinkLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.gb = new System.Windows.Forms.GroupBox();
            this.lbCoord = new System.Windows.Forms.Label();
            this.mtbFIO = new System.Windows.Forms.MaskedTextBox();
            this.flpnl = new System.Windows.Forms.FlowLayoutPanel();
            this.nfIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.prBar = new System.Windows.Forms.ProgressBar();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.trv = new System.Windows.Forms.TreeView();
            this.tbctrl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listBox = new System.Windows.Forms.ListBox();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.pbDraw = new System.Windows.Forms.PictureBox();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnGo = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.btnSize = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCats)).BeginInit();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmr)).BeginInit();
            this.gb.SuspendLayout();
            this.tbctrl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDraw)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Red;
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.btnOK.FlatAppearance.BorderSize = 2;
            this.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOK.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOK.Location = new System.Drawing.Point(1039, 458);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(115, 47);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            this.btnOK.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnOK_MouseDown);
            this.btnOK.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnOK_MouseMove);
            // 
            // chbLaba
            // 
            this.chbLaba.AutoSize = true;
            this.chbLaba.ForeColor = System.Drawing.Color.DarkBlue;
            this.chbLaba.Location = new System.Drawing.Point(15, 124);
            this.chbLaba.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbLaba.Name = "chbLaba";
            this.chbLaba.Size = new System.Drawing.Size(103, 20);
            this.chbLaba.TabIndex = 1;
            this.chbLaba.Text = "Сдать лабу";
            this.chbLaba.UseVisualStyleBackColor = true;
            this.chbLaba.CheckedChanged += new System.EventHandler(this.chbLaba_CheckedChanged);
            // 
            // chbReport
            // 
            this.chbReport.AutoSize = true;
            this.chbReport.Location = new System.Drawing.Point(15, 161);
            this.chbReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbReport.Name = "chbReport";
            this.chbReport.Size = new System.Drawing.Size(109, 20);
            this.chbReport.TabIndex = 2;
            this.chbReport.Text = "Сдать отчет";
            this.chbReport.UseVisualStyleBackColor = true;
            this.chbReport.CheckedChanged += new System.EventHandler(this.chbReport_CheckedChanged);
            // 
            // lbCoordX
            // 
            this.lbCoordX.AutoSize = true;
            this.lbCoordX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCoordX.Location = new System.Drawing.Point(193, 59);
            this.lbCoordX.Name = "lbCoordX";
            this.lbCoordX.Size = new System.Drawing.Size(18, 20);
            this.lbCoordX.TabIndex = 4;
            this.lbCoordX.Text = "0";
            // 
            // lbCoordY
            // 
            this.lbCoordY.AutoSize = true;
            this.lbCoordY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCoordY.Location = new System.Drawing.Point(193, 91);
            this.lbCoordY.Name = "lbCoordY";
            this.lbCoordY.Size = new System.Drawing.Size(18, 20);
            this.lbCoordY.TabIndex = 5;
            this.lbCoordY.Text = "0";
            // 
            // cb
            // 
            this.cb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb.FormattingEnabled = true;
            this.cb.Items.AddRange(new object[] {
            "Добавить кнопку",
            "Удалить кнопки"});
            this.cb.Location = new System.Drawing.Point(28, 158);
            this.cb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(151, 24);
            this.cb.TabIndex = 7;
            this.cb.Text = "Выберите...";
            this.toolTip.SetToolTip(this.cb, "это комбо бокс");
            this.cb.SelectionChangeCommitted += new System.EventHandler(this.cb_SelectionChangeCommitted);
            // 
            // tbCount
            // 
            this.tbCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCount.ForeColor = System.Drawing.Color.Blue;
            this.tbCount.Location = new System.Drawing.Point(1063, 524);
            this.tbCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(83, 27);
            this.tbCount.TabIndex = 8;
            this.tbCount.Text = "0";
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(23, 10);
            this.dtp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(225, 26);
            this.dtp.TabIndex = 9;
            this.dtp.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // pbCats
            // 
            this.pbCats.BackColor = System.Drawing.Color.White;
            this.pbCats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCats.Location = new System.Drawing.Point(475, 336);
            this.pbCats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbCats.Name = "pbCats";
            this.pbCats.Size = new System.Drawing.Size(253, 196);
            this.pbCats.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCats.TabIndex = 10;
            this.pbCats.TabStop = false;
            // 
            // btnClickMe
            // 
            this.btnClickMe.BackColor = System.Drawing.Color.MediumBlue;
            this.btnClickMe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClickMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClickMe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClickMe.Location = new System.Drawing.Point(1025, 582);
            this.btnClickMe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClickMe.Name = "btnClickMe";
            this.btnClickMe.Size = new System.Drawing.Size(160, 58);
            this.btnClickMe.TabIndex = 11;
            this.btnClickMe.Text = "Click me!";
            this.btnClickMe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClickMe.UseVisualStyleBackColor = false;
            this.btnClickMe.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnMouse
            // 
            this.btnMouse.BackColor = System.Drawing.Color.Magenta;
            this.btnMouse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMouse.Location = new System.Drawing.Point(20, 543);
            this.btnMouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMouse.Name = "btnMouse";
            this.btnMouse.Size = new System.Drawing.Size(176, 46);
            this.btnMouse.TabIndex = 12;
            this.btnMouse.Text = "Наведи сюда мышь";
            this.btnMouse.UseVisualStyleBackColor = false;
            this.btnMouse.MouseEnter += new System.EventHandler(this.btnMouse_MouseEnter);
            this.btnMouse.MouseLeave += new System.EventHandler(this.btnMouse_MouseLeave);
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.LightYellow;
            this.pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl.Controls.Add(this.lbDay);
            this.pnl.Controls.Add(this.clndr);
            this.pnl.Controls.Add(this.tbSchedule);
            this.pnl.Controls.Add(this.dtp);
            this.pnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pnl.Location = new System.Drawing.Point(700, 50);
            this.pnl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(527, 260);
            this.pnl.TabIndex = 13;
            // 
            // lbDay
            // 
            this.lbDay.AutoSize = true;
            this.lbDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDay.Location = new System.Drawing.Point(269, 218);
            this.lbDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDay.Name = "lbDay";
            this.lbDay.Size = new System.Drawing.Size(200, 18);
            this.lbDay.TabIndex = 22;
            this.lbDay.Text = "Это не мой день рождения!";
            // 
            // clndr
            // 
            this.clndr.AnnuallyBoldedDates = new System.DateTime[] {
        new System.DateTime(2003, 8, 11, 0, 0, 0, 0)};
            this.clndr.Location = new System.Drawing.Point(273, 10);
            this.clndr.MaxSelectionCount = 1;
            this.clndr.Name = "clndr";
            this.clndr.TabIndex = 21;
            this.clndr.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.clndr_DateSelected);
            // 
            // tbSchedule
            // 
            this.tbSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSchedule.Location = new System.Drawing.Point(23, 42);
            this.tbSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSchedule.Multiline = true;
            this.tbSchedule.Name = "tbSchedule";
            this.tbSchedule.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbSchedule.Size = new System.Drawing.Size(225, 166);
            this.tbSchedule.TabIndex = 16;
            this.tbSchedule.Text = "Расписание:";
            // 
            // tbMouse
            // 
            this.tbMouse.Location = new System.Drawing.Point(20, 598);
            this.tbMouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMouse.Name = "tbMouse";
            this.tbMouse.Size = new System.Drawing.Size(297, 22);
            this.tbMouse.TabIndex = 14;
            this.tbMouse.Text = "Вы не навели мышь на кнопку.";
            // 
            // rbColorful
            // 
            this.rbColorful.AutoSize = true;
            this.rbColorful.Location = new System.Drawing.Point(23, 36);
            this.rbColorful.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbColorful.Name = "rbColorful";
            this.rbColorful.Size = new System.Drawing.Size(114, 20);
            this.rbColorful.TabIndex = 17;
            this.rbColorful.Text = "Цветной фон";
            this.rbColorful.UseVisualStyleBackColor = true;
            this.rbColorful.CheckedChanged += new System.EventHandler(this.rbColorful_CheckedChanged);
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Checked = true;
            this.rbNormal.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.rbNormal.FlatAppearance.BorderSize = 2;
            this.rbNormal.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.rbNormal.Location = new System.Drawing.Point(23, 75);
            this.rbNormal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(118, 20);
            this.rbNormal.TabIndex = 18;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Обычный фон";
            this.rbNormal.UseVisualStyleBackColor = true;
            this.rbNormal.CheckedChanged += new System.EventHandler(this.rbNormal_CheckedChanged);
            // 
            // nmr
            // 
            this.nmr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nmr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nmr.Location = new System.Drawing.Point(20, 210);
            this.nmr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmr.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmr.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nmr.Name = "nmr";
            this.nmr.Size = new System.Drawing.Size(93, 27);
            this.nmr.TabIndex = 19;
            this.nmr.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nmr.ValueChanged += new System.EventHandler(this.nmr_ValueChanged);
            // 
            // linklb
            // 
            this.linklb.AutoSize = true;
            this.linklb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linklb.Location = new System.Drawing.Point(48, 204);
            this.linklb.Name = "linklb";
            this.linklb.Size = new System.Drawing.Size(239, 16);
            this.linklb.TabIndex = 20;
            this.linklb.TabStop = true;
            this.linklb.Text = "https://github.com/veeRONy/veeRONy";
            this.linklb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklb_LinkClicked);
            // 
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "Что это?";
            // 
            // gb
            // 
            this.gb.Controls.Add(this.rbColorful);
            this.gb.Controls.Add(this.rbNormal);
            this.gb.Location = new System.Drawing.Point(1004, 336);
            this.gb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb.Name = "gb";
            this.gb.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb.Size = new System.Drawing.Size(184, 110);
            this.gb.TabIndex = 21;
            this.gb.TabStop = false;
            this.gb.Text = "Выберите:";
            // 
            // lbCoord
            // 
            this.lbCoord.AutoSize = true;
            this.lbCoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCoord.Location = new System.Drawing.Point(11, 68);
            this.lbCoord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCoord.Name = "lbCoord";
            this.lbCoord.Size = new System.Drawing.Size(172, 20);
            this.lbCoord.TabIndex = 22;
            this.lbCoord.Text = "Координаты мыши:";
            // 
            // mtbFIO
            // 
            this.mtbFIO.Location = new System.Drawing.Point(373, 569);
            this.mtbFIO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtbFIO.Mask = "L.L.LLLLLLLLLLLLLL";
            this.mtbFIO.Name = "mtbFIO";
            this.mtbFIO.Size = new System.Drawing.Size(147, 22);
            this.mtbFIO.TabIndex = 23;
            this.mtbFIO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbFIO_KeyDown);
            // 
            // flpnl
            // 
            this.flpnl.AutoScroll = true;
            this.flpnl.BackColor = System.Drawing.Color.Honeydew;
            this.flpnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpnl.Location = new System.Drawing.Point(8, 10);
            this.flpnl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flpnl.Name = "flpnl";
            this.flpnl.Size = new System.Drawing.Size(371, 123);
            this.flpnl.TabIndex = 24;
            // 
            // nfIcon
            // 
            this.nfIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.nfIcon.BalloonTipText = "Это уведомление!";
            this.nfIcon.BalloonTipTitle = "Это заголовок!";
            this.nfIcon.Text = "Это тоже уведомление!";
            this.nfIcon.Visible = true;
            // 
            // prBar
            // 
            this.prBar.ForeColor = System.Drawing.Color.SpringGreen;
            this.prBar.Location = new System.Drawing.Point(29, 419);
            this.prBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prBar.Name = "prBar";
            this.prBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.prBar.Size = new System.Drawing.Size(328, 27);
            this.prBar.Step = 1;
            this.prBar.TabIndex = 25;
            // 
            // rtb
            // 
            this.rtb.Location = new System.Drawing.Point(8, 9);
            this.rtb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(371, 169);
            this.rtb.TabIndex = 26;
            this.rtb.Text = "";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(125, 197);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(147, 28);
            this.btnLoad.TabIndex = 27;
            this.btnLoad.Text = "Загрузить файл";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // trv
            // 
            this.trv.BackColor = System.Drawing.Color.MistyRose;
            this.trv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trv.CheckBoxes = true;
            this.trv.Location = new System.Drawing.Point(64, 27);
            this.trv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trv.Name = "trv";
            treeNode57.Checked = true;
            treeNode57.Name = "Node1";
            treeNode57.Text = "Умыться";
            treeNode58.Name = "Node2";
            treeNode58.Text = "Завтрак";
            treeNode59.Name = "Node0";
            treeNode59.Text = "Утром:";
            treeNode60.Name = "Node4";
            treeNode60.Text = "Сделать дз";
            treeNode61.Name = "Node3";
            treeNode61.Text = "Днем:";
            treeNode62.Name = "Node6";
            treeNode62.Text = "Прогулка";
            treeNode63.Name = "Node5";
            treeNode63.Text = "Вечером:";
            this.trv.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode59,
            treeNode61,
            treeNode63});
            this.trv.Size = new System.Drawing.Size(273, 156);
            this.trv.TabIndex = 28;
            this.trv.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.trv_AfterCheck);
            // 
            // tbctrl
            // 
            this.tbctrl.Controls.Add(this.tabPage1);
            this.tbctrl.Controls.Add(this.tabPage2);
            this.tbctrl.Controls.Add(this.tabPage3);
            this.tbctrl.Location = new System.Drawing.Point(269, 33);
            this.tbctrl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbctrl.Name = "tbctrl";
            this.tbctrl.SelectedIndex = 0;
            this.tbctrl.Size = new System.Drawing.Size(407, 281);
            this.tbctrl.TabIndex = 29;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flpnl);
            this.tabPage1.Controls.Add(this.cb);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(399, 252);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Страница 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rtb);
            this.tabPage2.Controls.Add(this.btnLoad);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(399, 252);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Страница 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.trv);
            this.tabPage3.Controls.Add(this.linklb);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(399, 252);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Страница 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listBox
            // 
            this.listBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Items.AddRange(new object[] {
            "Лев",
            "Тигр",
            "Леопард",
            "Пантера"});
            this.listBox.Location = new System.Drawing.Point(357, 336);
            this.listBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(111, 66);
            this.listBox.TabIndex = 30;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "лев.jpg");
            this.imgList.Images.SetKeyName(1, "тигр.jpg");
            this.imgList.Images.SetKeyName(2, "леопард.jpg");
            this.imgList.Images.SetKeyName(3, "пантера.jpg");
            // 
            // pbDraw
            // 
            this.pbDraw.BackColor = System.Drawing.SystemColors.Window;
            this.pbDraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDraw.Location = new System.Drawing.Point(737, 338);
            this.pbDraw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbDraw.Name = "pbDraw";
            this.pbDraw.Size = new System.Drawing.Size(238, 194);
            this.pbDraw.TabIndex = 31;
            this.pbDraw.TabStop = false;
            // 
            // btnCircle
            // 
            this.btnCircle.Location = new System.Drawing.Point(763, 540);
            this.btnCircle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(171, 28);
            this.btnCircle.TabIndex = 32;
            this.btnCircle.Text = "Нарисовать круг";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.pbDraw_Paint);
            // 
            // btnSquare
            // 
            this.btnSquare.Location = new System.Drawing.Point(763, 576);
            this.btnSquare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(171, 28);
            this.btnSquare.TabIndex = 33;
            this.btnSquare.Text = "Нарисовать квадрат";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.pbDraw_Paint);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(763, 612);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(171, 28);
            this.btnClear.TabIndex = 34;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.pbDraw_Paint);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 300;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(80, 458);
            this.btnGo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(100, 28);
            this.btnGo.TabIndex = 35;
            this.btnGo.Text = "Запустить";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(188, 458);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 28);
            this.btnStop.TabIndex = 36;
            this.btnStop.Text = "Остановить";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1229, 28);
            this.menu.TabIndex = 37;
            this.menu.Text = "menuStrip1";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click_1);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(67, 26);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(543, 569);
            this.tbCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(185, 22);
            this.tbCode.TabIndex = 38;
            this.tbCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbCode_KeyUp);
            // 
            // btnSize
            // 
            this.btnSize.Location = new System.Drawing.Point(51, 303);
            this.btnSize.Name = "btnSize";
            this.btnSize.Size = new System.Drawing.Size(132, 57);
            this.btnSize.TabIndex = 39;
            this.btnSize.Text = "Увеличить размер формы";
            this.btnSize.UseVisualStyleBackColor = true;
            this.btnSize.Click += new System.EventHandler(this.btnSize_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1229, 654);
            this.Controls.Add(this.btnSize);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSquare);
            this.Controls.Add(this.prBar);
            this.Controls.Add(this.btnCircle);
            this.Controls.Add(this.pbDraw);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.tbctrl);
            this.Controls.Add(this.mtbFIO);
            this.Controls.Add(this.lbCoord);
            this.Controls.Add(this.gb);
            this.Controls.Add(this.nmr);
            this.Controls.Add(this.tbMouse);
            this.Controls.Add(this.btnMouse);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.btnClickMe);
            this.Controls.Add(this.pbCats);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbCount);
            this.Controls.Add(this.lbCoordY);
            this.Controls.Add(this.lbCoordX);
            this.Controls.Add(this.chbReport);
            this.Controls.Add(this.chbLaba);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI приложение";
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pbCats)).EndInit();
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmr)).EndInit();
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.tbctrl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDraw)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckBox chbLaba;
        private System.Windows.Forms.CheckBox chbReport;
        private System.Windows.Forms.Label lbCoordX;
        private System.Windows.Forms.Label lbCoordY;
        private System.Windows.Forms.ComboBox cb;
        private System.Windows.Forms.TextBox tbCount;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.PictureBox pbCats;
        private System.Windows.Forms.Button btnClickMe;
        private System.Windows.Forms.Button btnMouse;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.TextBox tbMouse;
        private System.Windows.Forms.TextBox tbSchedule;
        private System.Windows.Forms.RadioButton rbColorful;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.NumericUpDown nmr;
        private System.Windows.Forms.LinkLabel linklb;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MonthCalendar clndr;
        private System.Windows.Forms.Label lbDay;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.Label lbCoord;
        private System.Windows.Forms.MaskedTextBox mtbFIO;
        private System.Windows.Forms.FlowLayoutPanel flpnl;
        private System.Windows.Forms.NotifyIcon nfIcon;
        private System.Windows.Forms.ProgressBar prBar;
        private System.Windows.Forms.RichTextBox rtb;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TreeView trv;
        private System.Windows.Forms.TabControl tbctrl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.PictureBox pbDraw;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Button btnSize;
    }
}

