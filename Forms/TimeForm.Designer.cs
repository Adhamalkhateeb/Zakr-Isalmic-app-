namespace Islamic_app
{
    partial class frmTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTime));
            this.lblquran = new System.Windows.Forms.Label();
            this.lblAzkar = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblMain = new System.Windows.Forms.Label();
            this.lblCurrentTimetxt = new System.Windows.Forms.Label();
            this.lblClockNow = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblNextPrayText = new System.Windows.Forms.Label();
            this.lblNextPray = new System.Windows.Forms.Label();
            this.lblReamingTimeTxt = new System.Windows.Forms.Label();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblfagr = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSunRise = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDhur = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAsr = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblMaghrub = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblIsha = new System.Windows.Forms.Label();
            this.lblNext = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblquran
            // 
            this.lblquran.AutoSize = true;
            this.lblquran.BackColor = System.Drawing.Color.Transparent;
            this.lblquran.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblquran.Font = new System.Drawing.Font("Andalus", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquran.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblquran.Location = new System.Drawing.Point(560, 9);
            this.lblquran.Name = "lblquran";
            this.lblquran.Size = new System.Drawing.Size(189, 57);
            this.lblquran.TabIndex = 14;
            this.lblquran.Text = "القران الكريم";
            this.lblquran.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblquran.Click += new System.EventHandler(this.lblquran_Click);
            // 
            // lblAzkar
            // 
            this.lblAzkar.AutoSize = true;
            this.lblAzkar.BackColor = System.Drawing.Color.Transparent;
            this.lblAzkar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAzkar.Font = new System.Drawing.Font("Andalus", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAzkar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAzkar.Location = new System.Drawing.Point(428, 9);
            this.lblAzkar.Name = "lblAzkar";
            this.lblAzkar.Size = new System.Drawing.Size(121, 57);
            this.lblAzkar.TabIndex = 12;
            this.lblAzkar.Text = "الاذكار";
            this.lblAzkar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAzkar.Click += new System.EventHandler(this.lblAzkar_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTime.Font = new System.Drawing.Font("Andalus", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTime.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTime.Location = new System.Drawing.Point(222, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(195, 57);
            this.lblTime.TabIndex = 11;
            this.lblTime.Text = "مواقيت الصلاة";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.BackColor = System.Drawing.Color.Transparent;
            this.lblMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMain.Font = new System.Drawing.Font("Andalus", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblMain.Location = new System.Drawing.Point(12, 9);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(216, 58);
            this.lblMain.TabIndex = 10;
            this.lblMain.Text = "الصفحة الرئيسية";
            this.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMain.Click += new System.EventHandler(this.lblMain_Click);
            // 
            // lblCurrentTimetxt
            // 
            this.lblCurrentTimetxt.AutoSize = true;
            this.lblCurrentTimetxt.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentTimetxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCurrentTimetxt.Font = new System.Drawing.Font("Arabic Typesetting", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTimetxt.ForeColor = System.Drawing.Color.Black;
            this.lblCurrentTimetxt.Location = new System.Drawing.Point(12, 112);
            this.lblCurrentTimetxt.Name = "lblCurrentTimetxt";
            this.lblCurrentTimetxt.Size = new System.Drawing.Size(169, 55);
            this.lblCurrentTimetxt.TabIndex = 16;
            this.lblCurrentTimetxt.Text = "الوقت الأن :";
            this.lblCurrentTimetxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClockNow
            // 
            this.lblClockNow.AutoSize = true;
            this.lblClockNow.Font = new System.Drawing.Font("Baskerville Old Face", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClockNow.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblClockNow.Location = new System.Drawing.Point(181, 121);
            this.lblClockNow.Name = "lblClockNow";
            this.lblClockNow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblClockNow.Size = new System.Drawing.Size(118, 36);
            this.lblClockNow.TabIndex = 17;
            this.lblClockNow.Text = "9:25:34";
            this.lblClockNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblNextPrayText
            // 
            this.lblNextPrayText.AutoSize = true;
            this.lblNextPrayText.BackColor = System.Drawing.Color.Transparent;
            this.lblNextPrayText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNextPrayText.Font = new System.Drawing.Font("Arabic Typesetting", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextPrayText.ForeColor = System.Drawing.Color.Black;
            this.lblNextPrayText.Location = new System.Drawing.Point(389, 112);
            this.lblNextPrayText.Name = "lblNextPrayText";
            this.lblNextPrayText.Size = new System.Drawing.Size(183, 55);
            this.lblNextPrayText.TabIndex = 18;
            this.lblNextPrayText.Text = "الأذان القادم :";
            this.lblNextPrayText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNextPray
            // 
            this.lblNextPray.AutoSize = true;
            this.lblNextPray.BackColor = System.Drawing.Color.Transparent;
            this.lblNextPray.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNextPray.Font = new System.Drawing.Font("Arabic Typesetting", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextPray.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblNextPray.Location = new System.Drawing.Point(560, 112);
            this.lblNextPray.Name = "lblNextPray";
            this.lblNextPray.Size = new System.Drawing.Size(84, 55);
            this.lblNextPray.TabIndex = 19;
            this.lblNextPray.Tag = "1";
            this.lblNextPray.Text = "الظهر";
            this.lblNextPray.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReamingTimeTxt
            // 
            this.lblReamingTimeTxt.AutoSize = true;
            this.lblReamingTimeTxt.BackColor = System.Drawing.Color.Transparent;
            this.lblReamingTimeTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReamingTimeTxt.Font = new System.Drawing.Font("Arabic Typesetting", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReamingTimeTxt.ForeColor = System.Drawing.Color.Black;
            this.lblReamingTimeTxt.Location = new System.Drawing.Point(12, 187);
            this.lblReamingTimeTxt.Name = "lblReamingTimeTxt";
            this.lblReamingTimeTxt.Size = new System.Drawing.Size(252, 55);
            this.lblReamingTimeTxt.TabIndex = 20;
            this.lblReamingTimeTxt.Text = "الوقت المتبقي لأذان ";
            this.lblReamingTimeTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRemaining
            // 
            this.lblRemaining.AutoSize = true;
            this.lblRemaining.Font = new System.Drawing.Font("Baskerville Old Face", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemaining.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblRemaining.Location = new System.Drawing.Point(336, 193);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRemaining.Size = new System.Drawing.Size(168, 36);
            this.lblRemaining.TabIndex = 21;
            this.lblRemaining.Text = "_________";
            this.lblRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Uighur", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(33, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 37);
            this.label6.TabIndex = 24;
            this.label6.Text = "الفجر";
            // 
            // lblfagr
            // 
            this.lblfagr.AutoSize = true;
            this.lblfagr.Font = new System.Drawing.Font("Baskerville Old Face", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfagr.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblfagr.Location = new System.Drawing.Point(23, 400);
            this.lblfagr.Name = "lblfagr";
            this.lblfagr.Size = new System.Drawing.Size(77, 26);
            this.lblfagr.TabIndex = 25;
            this.lblfagr.Text = "_____";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Uighur", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(108, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 37);
            this.label7.TabIndex = 27;
            this.label7.Text = "الشروق";
            // 
            // lblSunRise
            // 
            this.lblSunRise.AutoSize = true;
            this.lblSunRise.Font = new System.Drawing.Font("Baskerville Old Face", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSunRise.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblSunRise.Location = new System.Drawing.Point(105, 400);
            this.lblSunRise.Name = "lblSunRise";
            this.lblSunRise.Size = new System.Drawing.Size(77, 26);
            this.lblSunRise.TabIndex = 28;
            this.lblSunRise.Text = "_____";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(307, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 48);
            this.label3.TabIndex = 30;
            this.label3.Text = " ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Uighur", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(199, 373);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 37);
            this.label8.TabIndex = 31;
            this.label8.Text = "الظهر";
            // 
            // lblDhur
            // 
            this.lblDhur.AutoSize = true;
            this.lblDhur.Font = new System.Drawing.Font("Baskerville Old Face", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDhur.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblDhur.Location = new System.Drawing.Point(193, 400);
            this.lblDhur.Name = "lblDhur";
            this.lblDhur.Size = new System.Drawing.Size(77, 26);
            this.lblDhur.TabIndex = 32;
            this.lblDhur.Text = "_____";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Uighur", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(276, 373);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 37);
            this.label9.TabIndex = 34;
            this.label9.Text = "العصر";
            // 
            // lblAsr
            // 
            this.lblAsr.AutoSize = true;
            this.lblAsr.Font = new System.Drawing.Font("Baskerville Old Face", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsr.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblAsr.Location = new System.Drawing.Point(276, 400);
            this.lblAsr.Name = "lblAsr";
            this.lblAsr.Size = new System.Drawing.Size(77, 26);
            this.lblAsr.TabIndex = 35;
            this.lblAsr.Text = "_____";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Uighur", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(357, 373);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 37);
            this.label10.TabIndex = 37;
            this.label10.Text = "المغرب";
            // 
            // lblMaghrub
            // 
            this.lblMaghrub.AutoSize = true;
            this.lblMaghrub.Font = new System.Drawing.Font("Baskerville Old Face", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaghrub.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblMaghrub.Location = new System.Drawing.Point(359, 400);
            this.lblMaghrub.Name = "lblMaghrub";
            this.lblMaghrub.Size = new System.Drawing.Size(77, 26);
            this.lblMaghrub.TabIndex = 38;
            this.lblMaghrub.Text = "_____";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Uighur", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(446, 373);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 37);
            this.label11.TabIndex = 40;
            this.label11.Text = "العشاء";
            // 
            // lblIsha
            // 
            this.lblIsha.AutoSize = true;
            this.lblIsha.Font = new System.Drawing.Font("Baskerville Old Face", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsha.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblIsha.Location = new System.Drawing.Point(445, 400);
            this.lblIsha.Name = "lblIsha";
            this.lblIsha.Size = new System.Drawing.Size(77, 26);
            this.lblIsha.TabIndex = 41;
            this.lblIsha.Text = "_____";
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.BackColor = System.Drawing.Color.Transparent;
            this.lblNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNext.Font = new System.Drawing.Font("Arabic Typesetting", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNext.ForeColor = System.Drawing.Color.Black;
            this.lblNext.Location = new System.Drawing.Point(242, 187);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(104, 55);
            this.lblNext.TabIndex = 42;
            this.lblNext.Text = "الظهر :";
            this.lblNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "موعد الصلاه";
            this.notifyIcon1.BalloonTipTitle = "االأذان";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_BalloonTipClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Islamic_app.Properties.Resources.FagrSun;
            this.pictureBox2.Location = new System.Drawing.Point(19, 307);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Islamic_app.Properties.Resources.Moon;
            this.pictureBox7.Location = new System.Drawing.Point(450, 310);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(63, 57);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 39;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Islamic_app.Properties.Resources.maghrib_Sun;
            this.pictureBox6.Location = new System.Drawing.Point(352, 307);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(76, 63);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 36;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Islamic_app.Properties.Resources.sunrise;
            this.pictureBox5.Location = new System.Drawing.Point(265, 310);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(81, 60);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 33;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Islamic_app.Properties.Resources.AfternonoonSun;
            this.pictureBox4.Location = new System.Drawing.Point(188, 310);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(76, 66);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 29;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Islamic_app.Properties.Resources.Sun_photo;
            this.pictureBox3.Location = new System.Drawing.Point(97, 295);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(96, 89);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Islamic_app.Properties.Resources.Makka_Image;
            this.pictureBox1.Location = new System.Drawing.Point(587, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(385, 372);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::Islamic_app.Properties.Resources.exit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(913, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(59, 48);
            this.btnExit.TabIndex = 15;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(984, 484);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblNext);
            this.Controls.Add(this.lblIsha);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.lblMaghrub);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.lblAsr);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.lblDhur);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lblSunRise);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblfagr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblNextPrayText);
            this.Controls.Add(this.lblNextPray);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRemaining);
            this.Controls.Add(this.lblReamingTimeTxt);
            this.Controls.Add(this.lblClockNow);
            this.Controls.Add(this.lblCurrentTimetxt);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblquran);
            this.Controls.Add(this.lblAzkar);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frmTime";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.TimeForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TimeForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblquran;
        private System.Windows.Forms.Label lblAzkar;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label lblCurrentTimetxt;
        private System.Windows.Forms.Label lblClockNow;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblNextPrayText;
        private System.Windows.Forms.Label lblNextPray;
        private System.Windows.Forms.Label lblReamingTimeTxt;
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblfagr;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSunRise;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDhur;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblAsr;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblMaghrub;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblIsha;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}