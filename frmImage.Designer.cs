namespace Control_ICL1904
{
    partial class frmImage
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
            this.button1 = new System.Windows.Forms.Button();
            this.image1 = new System.Windows.Forms.PictureBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.lbldesc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.image1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(675, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // image1
            // 
            this.image1.Location = new System.Drawing.Point(12, 12);
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(392, 451);
            this.image1.TabIndex = 1;
            this.image1.TabStop = false;
            // 
            // lblname
            // 
            this.lblname.Location = new System.Drawing.Point(12, 466);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(124, 23);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "Name";
            // 
            // lbltitle
            // 
            this.lbltitle.Location = new System.Drawing.Point(12, 489);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(555, 47);
            this.lbltitle.TabIndex = 3;
            this.lbltitle.Text = "Description";
            // 
            // lbldesc
            // 
            this.lbldesc.Location = new System.Drawing.Point(433, 12);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(348, 451);
            this.lbldesc.TabIndex = 4;
            this.lbldesc.Text = "label1";
            // 
            // frmImage
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 545);
            this.Controls.Add(this.lbldesc);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.image1);
            this.Controls.Add(this.button1);
            this.Name = "frmImage";
            this.Text = "frmImage";
            this.Load += new System.EventHandler(this.frmImage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.image1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox image1;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lbldesc;
    }
}