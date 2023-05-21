namespace lr4
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
            this.chbCTRL = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCircle = new System.Windows.Forms.ToolStripButton();
            this.btnRectangle = new System.Windows.Forms.ToolStripButton();
            this.btnTriangle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnRed = new System.Windows.Forms.ToolStripButton();
            this.btnGreen = new System.Windows.Forms.ToolStripButton();
            this.btnBlue = new System.Windows.Forms.ToolStripButton();
            this.btnPink = new System.Windows.Forms.ToolStripButton();
            this.btnYellow = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chbCTRL
            // 
            this.chbCTRL.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chbCTRL.AutoSize = true;
            this.chbCTRL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbCTRL.Location = new System.Drawing.Point(0, 419);
            this.chbCTRL.Margin = new System.Windows.Forms.Padding(2);
            this.chbCTRL.Name = "chbCTRL";
            this.chbCTRL.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.chbCTRL.Size = new System.Drawing.Size(69, 21);
            this.chbCTRL.TabIndex = 0;
            this.chbCTRL.Text = "CTRL";
            this.chbCTRL.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox2.Location = new System.Drawing.Point(0, 398);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.checkBox2.Size = new System.Drawing.Size(384, 21);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Выделение только одного объекта при пересечении";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCircle,
            this.btnRectangle,
            this.btnTriangle,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.btnRed,
            this.btnGreen,
            this.btnBlue,
            this.btnPink,
            this.btnYellow});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(689, 39);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCircle
            // 
            this.btnCircle.AutoSize = false;
            this.btnCircle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCircle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCircle.Image = global::lr4.Properties.Resources.circle1;
            this.btnCircle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(36, 36);
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.AutoSize = false;
            this.btnRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRectangle.Image = global::lr4.Properties.Resources.square;
            this.btnRectangle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(36, 36);
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnTriangle
            // 
            this.btnTriangle.AutoSize = false;
            this.btnTriangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTriangle.Image = global::lr4.Properties.Resources.triangle;
            this.btnTriangle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTriangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(36, 36);
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 36);
            // 
            // btnRed
            // 
            this.btnRed.AutoSize = false;
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRed.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRed.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(36, 36);
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.AutoSize = false;
            this.btnGreen.BackColor = System.Drawing.Color.LimeGreen;
            this.btnGreen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGreen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(36, 36);
            this.btnGreen.Text = "toolStripButton5";
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.AutoSize = false;
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBlue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(36, 36);
            this.btnBlue.Text = "toolStripButton6";
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnPink
            // 
            this.btnPink.AutoSize = false;
            this.btnPink.BackColor = System.Drawing.Color.DeepPink;
            this.btnPink.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPink.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPink.Name = "btnPink";
            this.btnPink.Size = new System.Drawing.Size(36, 36);
            this.btnPink.Text = "toolStripButton7";
            this.btnPink.Click += new System.EventHandler(this.btnPink_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.AutoSize = false;
            this.btnYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnYellow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnYellow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(36, 36);
            this.btnYellow.Text = "toolStripButton8";
            this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 440);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.chbCTRL);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "Визуальный редактор";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseClick);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbCTRL;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCircle;
        private System.Windows.Forms.ToolStripButton btnRectangle;
        private System.Windows.Forms.ToolStripButton btnTriangle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnRed;
        private System.Windows.Forms.ToolStripButton btnGreen;
        private System.Windows.Forms.ToolStripButton btnBlue;
        private System.Windows.Forms.ToolStripButton btnPink;
        private System.Windows.Forms.ToolStripButton btnYellow;
    }
}

