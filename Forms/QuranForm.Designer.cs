namespace QuranPlayer
{
    partial class QuranForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuranForm));
            this.lblquran = new System.Windows.Forms.Label();
            this.lblAzkar = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblMain = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbReader = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSurah = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPart = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ProbarSurah = new System.Windows.Forms.ProgressBar();
            this.SurahTimer = new System.Windows.Forms.Timer(this.components);
            this.btnSound = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblquran
            // 
            this.lblquran.AutoSize = true;
            this.lblquran.BackColor = System.Drawing.Color.Transparent;
            this.lblquran.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblquran.Font = new System.Drawing.Font("Andalus", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquran.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblquran.Location = new System.Drawing.Point(560, 9);
            this.lblquran.Name = "lblquran";
            this.lblquran.Size = new System.Drawing.Size(234, 72);
            this.lblquran.TabIndex = 31;
            this.lblquran.Text = "القران الكريم";
            this.lblquran.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblAzkar.Size = new System.Drawing.Size(149, 72);
            this.lblAzkar.TabIndex = 29;
            this.lblAzkar.Text = "الاذكار";
            this.lblAzkar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAzkar.Click += new System.EventHandler(this.lblAzkar_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTime.Font = new System.Drawing.Font("Andalus", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTime.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTime.Location = new System.Drawing.Point(222, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(241, 72);
            this.lblTime.TabIndex = 28;
            this.lblTime.Text = "مواقيت الصلاة";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
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
            this.lblMain.Size = new System.Drawing.Size(263, 72);
            this.lblMain.TabIndex = 27;
            this.lblMain.Text = "الصفحة الرئيسية";
            this.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMain.Click += new System.EventHandler(this.lblMain_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cmbReader);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbSurah);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbPart);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(757, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 393);
            this.panel1.TabIndex = 33;
            // 
            // cmbReader
            // 
            this.cmbReader.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbReader.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbReader.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cmbReader.DropDownHeight = 100;
            this.cmbReader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReader.DropDownWidth = 200;
            this.cmbReader.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReader.ForeColor = System.Drawing.Color.Black;
            this.cmbReader.FormattingEnabled = true;
            this.cmbReader.IntegralHeight = false;
            this.cmbReader.ItemHeight = 31;
            this.cmbReader.Items.AddRange(new object[] {
            "  الشيخ مشاري راشد "});
            this.cmbReader.Location = new System.Drawing.Point(3, 341);
            this.cmbReader.MaxDropDownItems = 30;
            this.cmbReader.Name = "cmbReader";
            this.cmbReader.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbReader.Size = new System.Drawing.Size(198, 39);
            this.cmbReader.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 39);
            this.label3.TabIndex = 41;
            this.label3.Text = "اختر القارئ :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 39);
            this.label2.TabIndex = 40;
            this.label2.Text = "اختر السورة :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbSurah
            // 
            this.cmbSurah.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSurah.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSurah.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cmbSurah.DropDownHeight = 100;
            this.cmbSurah.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSurah.DropDownWidth = 200;
            this.cmbSurah.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbSurah.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSurah.ForeColor = System.Drawing.Color.Black;
            this.cmbSurah.FormattingEnabled = true;
            this.cmbSurah.IntegralHeight = false;
            this.cmbSurah.ItemHeight = 31;
            this.cmbSurah.Location = new System.Drawing.Point(2, 252);
            this.cmbSurah.MaxDropDownItems = 30;
            this.cmbSurah.Name = "cmbSurah";
            this.cmbSurah.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbSurah.Size = new System.Drawing.Size(198, 39);
            this.cmbSurah.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 39);
            this.label1.TabIndex = 38;
            this.label1.Text = "اختر الجزء :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbPart
            // 
            this.cmbPart.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cmbPart.DropDownHeight = 100;
            this.cmbPart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPart.DropDownWidth = 200;
            this.cmbPart.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPart.ForeColor = System.Drawing.Color.Black;
            this.cmbPart.IntegralHeight = false;
            this.cmbPart.ItemHeight = 31;
            this.cmbPart.Items.AddRange(new object[] {
            "  الجزء الاول  ",
            "  الجزء الثاني",
            "  الجزء الثالث",
            "  الجزء الرابع",
            "  الجزء الخامس",
            "  الجزء السادس",
            "  الجزء السابع",
            "  الجزء الثامن",
            "  الجزء التاسع",
            "  الجزء العاشر",
            "  الجزء الحادي عشر",
            "  الجزء الثاني عشر",
            "  الجزء الثالث عشر ",
            "  الجزء الرابع عشر",
            "  الجزء الخامس عشر  ",
            "  الجزء السادس عشر",
            "  الجزء السابع عشر",
            "  الجزء الثامن عشر",
            "  الجزء التاسع عشر",
            "  الجزء العشرون",
            "  الجزء الواحد و العشرين",
            "  الجزء الثاني و العشرين",
            "  الجزء الثالث و العشرين",
            "  الجزء الرابع و العشرين",
            "  الجزء الخامس و العشرين",
            "  الجزء السادس و العشرين",
            "  الجزء السابع و العشرين",
            "  الجزء الثامن و العشرين",
            "  الجزء التاسع و العشرين",
            "  الجزء الثلاثون"});
            this.cmbPart.Location = new System.Drawing.Point(3, 163);
            this.cmbPart.MaxDropDownItems = 9;
            this.cmbPart.Name = "cmbPart";
            this.cmbPart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbPart.Size = new System.Drawing.Size(198, 39);
            this.cmbPart.TabIndex = 35;
            this.cmbPart.SelectedIndexChanged += new System.EventHandler(this.cmbPart_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 110);
            this.panel2.TabIndex = 33;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Islamic_app.Properties.Resources.QuranFormLogo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // ProbarSurah
            // 
            this.ProbarSurah.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ProbarSurah.Location = new System.Drawing.Point(189, 422);
            this.ProbarSurah.Name = "ProbarSurah";
            this.ProbarSurah.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProbarSurah.Size = new System.Drawing.Size(385, 10);
            this.ProbarSurah.Step = 1;
            this.ProbarSurah.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProbarSurah.TabIndex = 38;
            this.ProbarSurah.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // SurahTimer
            // 
            this.SurahTimer.Enabled = true;
            this.SurahTimer.Tick += new System.EventHandler(this.SurahTimer_Tick);
            // 
            // btnSound
            // 
            this.btnSound.BackgroundImage = global::Islamic_app.Properties.Resources.volume__1_;
            this.btnSound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSound.FlatAppearance.BorderSize = 0;
            this.btnSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSound.Location = new System.Drawing.Point(22, 434);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(47, 38);
            this.btnSound.TabIndex = 39;
            this.btnSound.Tag = "1";
            this.btnSound.UseVisualStyleBackColor = true;
            this.btnSound.Click += new System.EventHandler(this.btnSound_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackgroundImage = global::Islamic_app.Properties.Resources.Left_arrow;
            this.btnPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Location = new System.Drawing.Point(450, 333);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(51, 52);
            this.btnPrev.TabIndex = 37;
            this.btnPrev.Tag = "1";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackgroundImage = global::Islamic_app.Properties.Resources.Right_arrow;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(260, 333);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(66, 52);
            this.btnNext.TabIndex = 36;
            this.btnNext.Tag = "1";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImage = global::Islamic_app.Properties.Resources.square_play_button;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Location = new System.Drawing.Point(345, 321);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(83, 77);
            this.btnPlay.TabIndex = 35;
            this.btnPlay.Tag = "1";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Islamic_app.Properties.Resources.QuranFormLogo;
            this.pictureBox2.Location = new System.Drawing.Point(250, 108);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(260, 179);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::Islamic_app.Properties.Resources.exit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(913, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(59, 48);
            this.btnExit.TabIndex = 32;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // QuranForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(984, 484);
            this.ControlBox = false;
            this.Controls.Add(this.btnSound);
            this.Controls.Add(this.ProbarSurah);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblquran);
            this.Controls.Add(this.lblAzkar);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "QuranForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.QuranForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblquran;
        private System.Windows.Forms.Label lblAzkar;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbPart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSurah;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbReader;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.ProgressBar ProbarSurah;
        private System.Windows.Forms.Timer SurahTimer;
        private System.Windows.Forms.Button btnSound;
    }
}