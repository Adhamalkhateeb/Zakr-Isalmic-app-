namespace Islamic_app
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lblMain = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblAzkar = new System.Windows.Forms.Label();
            this.lblquran = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMain
            // 
            resources.ApplyResources(this.lblMain, "lblMain");
            this.lblMain.BackColor = System.Drawing.Color.Transparent;
            this.lblMain.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblMain.Name = "lblMain";
            // 
            // lblTime
            // 
            resources.ApplyResources(this.lblTime, "lblTime");
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTime.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTime.Name = "lblTime";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // lblAzkar
            // 
            resources.ApplyResources(this.lblAzkar, "lblAzkar");
            this.lblAzkar.BackColor = System.Drawing.Color.Transparent;
            this.lblAzkar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAzkar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAzkar.Name = "lblAzkar";
            this.lblAzkar.Click += new System.EventHandler(this.lblAzkar_Click);
            // 
            // lblquran
            // 
            resources.ApplyResources(this.lblquran, "lblquran");
            this.lblquran.BackColor = System.Drawing.Color.Transparent;
            this.lblquran.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblquran.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblquran.Name = "lblquran";
            this.lblquran.Click += new System.EventHandler(this.lblquran_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Name = "label6";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::Islamic_app.Properties.Resources.exit;
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Islamic_app.Properties.Resources.Main_Screen_photo;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // FrmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblquran);
            this.Controls.Add(this.lblAzkar);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblMain);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmMain_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblAzkar;
        private System.Windows.Forms.Label lblquran;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

