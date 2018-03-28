namespace Control_ICL1904
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.emulateSystemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runICL1904G3SystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runICL1904G6SystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadVDUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadVDUsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.createCardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readDocumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOBOLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compilingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tPSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iDMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtmessage = new System.Windows.Forms.TextBox();
            this.programmingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cobolToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 541);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "1904 G6 Messages";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "1904 G3 Messages";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 35);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(344, 110);
            this.textBox1.TabIndex = 36;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(159, 157);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(344, 110);
            this.textBox2.TabIndex = 37;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emulateSystemsToolStripMenuItem,
            this.readDocumentsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(520, 24);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // emulateSystemsToolStripMenuItem
            // 
            this.emulateSystemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runICL1904G3SystemToolStripMenuItem,
            this.runICL1904G6SystemToolStripMenuItem,
            this.loadVDUsToolStripMenuItem});
            this.emulateSystemsToolStripMenuItem.Name = "emulateSystemsToolStripMenuItem";
            this.emulateSystemsToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.emulateSystemsToolStripMenuItem.Text = "Emulate Systems";
            // 
            // runICL1904G3SystemToolStripMenuItem
            // 
            this.runICL1904G3SystemToolStripMenuItem.Name = "runICL1904G3SystemToolStripMenuItem";
            this.runICL1904G3SystemToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.runICL1904G3SystemToolStripMenuItem.Text = "Run ICL 1904 G3 System";
            this.runICL1904G3SystemToolStripMenuItem.Click += new System.EventHandler(this.runICL1904G3SystemToolStripMenuItem_Click);
            // 
            // runICL1904G6SystemToolStripMenuItem
            // 
            this.runICL1904G6SystemToolStripMenuItem.Name = "runICL1904G6SystemToolStripMenuItem";
            this.runICL1904G6SystemToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.runICL1904G6SystemToolStripMenuItem.Text = "Run ICL 1904 G6 System";
            this.runICL1904G6SystemToolStripMenuItem.Click += new System.EventHandler(this.runICL1904G6SystemToolStripMenuItem_Click);
            // 
            // loadVDUsToolStripMenuItem
            // 
            this.loadVDUsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadVDUsToolStripMenuItem1,
            this.createCardsToolStripMenuItem,
            this.viewCardsToolStripMenuItem});
            this.loadVDUsToolStripMenuItem.Name = "loadVDUsToolStripMenuItem";
            this.loadVDUsToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.loadVDUsToolStripMenuItem.Text = "Tools";
            // 
            // loadVDUsToolStripMenuItem1
            // 
            this.loadVDUsToolStripMenuItem1.Name = "loadVDUsToolStripMenuItem1";
            this.loadVDUsToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.loadVDUsToolStripMenuItem1.Text = "Load VDUs";
            this.loadVDUsToolStripMenuItem1.Click += new System.EventHandler(this.loadVDUsToolStripMenuItem1_Click);
            // 
            // createCardsToolStripMenuItem
            // 
            this.createCardsToolStripMenuItem.Name = "createCardsToolStripMenuItem";
            this.createCardsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createCardsToolStripMenuItem.Text = "Create Cards";
            this.createCardsToolStripMenuItem.Click += new System.EventHandler(this.createCardsToolStripMenuItem_Click_1);
            // 
            // viewCardsToolStripMenuItem
            // 
            this.viewCardsToolStripMenuItem.Name = "viewCardsToolStripMenuItem";
            this.viewCardsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewCardsToolStripMenuItem.Text = "View Cards";
            this.viewCardsToolStripMenuItem.Click += new System.EventHandler(this.viewCardsToolStripMenuItem_Click);
            // 
            // readDocumentsToolStripMenuItem
            // 
            this.readDocumentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cOBOLToolStripMenuItem,
            this.tPSToolStripMenuItem,
            this.iDMSToolStripMenuItem});
            this.readDocumentsToolStripMenuItem.Name = "readDocumentsToolStripMenuItem";
            this.readDocumentsToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.readDocumentsToolStripMenuItem.Text = "Read Documents";
            // 
            // cOBOLToolStripMenuItem
            // 
            this.cOBOLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualToolStripMenuItem,
            this.compilingToolStripMenuItem});
            this.cOBOLToolStripMenuItem.Name = "cOBOLToolStripMenuItem";
            this.cOBOLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cOBOLToolStripMenuItem.Text = "COBOL";
            this.cOBOLToolStripMenuItem.Click += new System.EventHandler(this.COBOLToolStripMenuItem_Click);
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.manualToolStripMenuItem.Text = "Cobol Manual";
            this.manualToolStripMenuItem.Click += new System.EventHandler(this.ManualToolStripMenuItem_Click);
            // 
            // compilingToolStripMenuItem
            // 
            this.compilingToolStripMenuItem.Name = "compilingToolStripMenuItem";
            this.compilingToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.compilingToolStripMenuItem.Text = "Compiling";
            this.compilingToolStripMenuItem.Click += new System.EventHandler(this.CompilingToolStripMenuItem_Click);
            // 
            // tPSToolStripMenuItem
            // 
            this.tPSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programmingToolStripMenuItem});
            this.tPSToolStripMenuItem.Name = "tPSToolStripMenuItem";
            this.tPSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tPSToolStripMenuItem.Text = "TPS";
            // 
            // iDMSToolStripMenuItem
            // 
            this.iDMSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.cobolToolStripMenuItem1});
            this.iDMSToolStripMenuItem.Name = "iDMSToolStripMenuItem";
            this.iDMSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iDMSToolStripMenuItem.Text = "IDMS";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(159, 282);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(344, 110);
            this.textBox3.TabIndex = 41;
            this.textBox3.Text = "At RESTORE? type N\r\nAt IS CONFIGURATION REPORT... type Y\r\nAt GEORGE READY type MP" +
    " ON,57";
            this.textBox3.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "1904 G3EE Messages";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 417);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Messages";
            // 
            // txtmessage
            // 
            this.txtmessage.Location = new System.Drawing.Point(159, 414);
            this.txtmessage.Multiline = true;
            this.txtmessage.Name = "txtmessage";
            this.txtmessage.Size = new System.Drawing.Size(344, 109);
            this.txtmessage.TabIndex = 43;
            // 
            // programmingToolStripMenuItem
            // 
            this.programmingToolStripMenuItem.Name = "programmingToolStripMenuItem";
            this.programmingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.programmingToolStripMenuItem.Text = "Programming";
            this.programmingToolStripMenuItem.Click += new System.EventHandler(this.programmingToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // cobolToolStripMenuItem1
            // 
            this.cobolToolStripMenuItem1.Name = "cobolToolStripMenuItem1";
            this.cobolToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.cobolToolStripMenuItem1.Text = "Cobol";
            this.cobolToolStripMenuItem1.Click += new System.EventHandler(this.cobolToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(520, 567);
            this.Controls.Add(this.txtmessage);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ICL 1904 Control System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem readDocumentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOBOLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem tPSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iDMSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compilingToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtmessage;
        private System.Windows.Forms.ToolStripMenuItem emulateSystemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runICL1904G3SystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runICL1904G6SystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadVDUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadVDUsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem createCardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programmingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cobolToolStripMenuItem1;
    }
}

