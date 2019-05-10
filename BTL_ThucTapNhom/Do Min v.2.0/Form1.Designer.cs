namespace Do_Min_v._2._0
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoreBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnChơiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nudrow = new System.Windows.Forms.NumericUpDown();
            this.nudcol = new System.Windows.Forms.NumericUpDown();
            this.nudbom = new System.Windows.Forms.NumericUpDown();
            this.Row = new System.Windows.Forms.Label();
            this.Col = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.butstart = new System.Windows.Forms.Button();
            this.lblco = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbHienthi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudcol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudbom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(5, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 251);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(263, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.scoreBoardToolStripMenuItem,
            this.quitToolStripMenuItem,
            this.toolStripSeparator1});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // scoreBoardToolStripMenuItem
            // 
            this.scoreBoardToolStripMenuItem.Name = "scoreBoardToolStripMenuItem";
            this.scoreBoardToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.scoreBoardToolStripMenuItem.Text = "ScoreBoard";
            this.scoreBoardToolStripMenuItem.Click += new System.EventHandler(this.scoreBoardToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitToolStripMenuItem.Text = "&Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hướngDẫnChơiToolStripMenuItem,
            this.toolStripSeparator2,
            this.thôngTinToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // hướngDẫnChơiToolStripMenuItem
            // 
            this.hướngDẫnChơiToolStripMenuItem.Name = "hướngDẫnChơiToolStripMenuItem";
            this.hướngDẫnChơiToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.hướngDẫnChơiToolStripMenuItem.Text = "Hướng dẫn chơi";
            this.hướngDẫnChơiToolStripMenuItem.Click += new System.EventHandler(this.hướngDẫnChơiToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(157, 6);
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.thôngTinToolStripMenuItem.Text = "Thông Tin";
            this.thôngTinToolStripMenuItem.Click += new System.EventHandler(this.thôngTinToolStripMenuItem_Click);
            // 
            // nudrow
            // 
            this.nudrow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudrow.Location = new System.Drawing.Point(49, 37);
            this.nudrow.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudrow.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudrow.Name = "nudrow";
            this.nudrow.Size = new System.Drawing.Size(35, 20);
            this.nudrow.TabIndex = 2;
            this.nudrow.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // nudcol
            // 
            this.nudcol.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudcol.Location = new System.Drawing.Point(131, 37);
            this.nudcol.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudcol.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudcol.Name = "nudcol";
            this.nudcol.Size = new System.Drawing.Size(33, 20);
            this.nudcol.TabIndex = 3;
            this.nudcol.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // nudbom
            // 
            this.nudbom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudbom.Location = new System.Drawing.Point(205, 37);
            this.nudbom.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudbom.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudbom.Name = "nudbom";
            this.nudbom.Size = new System.Drawing.Size(39, 20);
            this.nudbom.TabIndex = 4;
            this.nudbom.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Row
            // 
            this.Row.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Row.AutoSize = true;
            this.Row.Location = new System.Drawing.Point(12, 37);
            this.Row.Name = "Row";
            this.Row.Size = new System.Drawing.Size(22, 13);
            this.Row.TabIndex = 5;
            this.Row.Text = "Col";
            // 
            // Col
            // 
            this.Col.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Col.AutoSize = true;
            this.Col.Location = new System.Drawing.Point(94, 40);
            this.Col.Name = "Col";
            this.Col.Size = new System.Drawing.Size(29, 13);
            this.Col.TabIndex = 6;
            this.Col.Text = "Row";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bom";
            // 
            // butstart
            // 
            this.butstart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butstart.AutoSize = true;
            this.butstart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butstart.Location = new System.Drawing.Point(113, 84);
            this.butstart.Name = "butstart";
            this.butstart.Size = new System.Drawing.Size(53, 23);
            this.butstart.TabIndex = 12;
            this.butstart.Text = "START";
            this.butstart.UseVisualStyleBackColor = true;
            this.butstart.Click += new System.EventHandler(this.butstart_Click);
            // 
            // lblco
            // 
            this.lblco.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblco.AutoSize = true;
            this.lblco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblco.Cursor = System.Windows.Forms.Cursors.No;
            this.lblco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblco.ForeColor = System.Drawing.Color.Black;
            this.lblco.Location = new System.Drawing.Point(225, 94);
            this.lblco.Name = "lblco";
            this.lblco.Size = new System.Drawing.Size(19, 13);
            this.lblco.TabIndex = 9;
            this.lblco.Text = "10";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::Do_Min_v._2._0.Properties.Resources.Img_co;
            this.pictureBox1.Location = new System.Drawing.Point(205, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(17, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lbHienthi
            // 
            this.lbHienthi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbHienthi.AutoSize = true;
            this.lbHienthi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbHienthi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHienthi.Location = new System.Drawing.Point(46, 94);
            this.lbHienthi.Name = "lbHienthi";
            this.lbHienthi.Size = new System.Drawing.Size(34, 13);
            this.lbHienthi.TabIndex = 11;
            this.lbHienthi.Text = "00:00";
            this.lbHienthi.Click += new System.EventHandler(this.lbHienthi_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Time:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(263, 398);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbHienthi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblco);
            this.Controls.Add(this.butstart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Col);
            this.Controls.Add(this.Row);
            this.Controls.Add(this.nudbom);
            this.Controls.Add(this.nudcol);
            this.Controls.Add(this.nudrow);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dò Mìn v2.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudcol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudbom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown nudrow;
        private System.Windows.Forms.NumericUpDown nudcol;
        private System.Windows.Forms.NumericUpDown nudbom;
        private System.Windows.Forms.Label Row;
        private System.Windows.Forms.Label Col;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnChơiToolStripMenuItem;
        private System.Windows.Forms.Button butstart;
        private System.Windows.Forms.Label lblco;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbHienthi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scoreBoardToolStripMenuItem;
    }
}

