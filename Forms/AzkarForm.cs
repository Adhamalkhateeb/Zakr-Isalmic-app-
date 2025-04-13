using Islamic_app.Forms;
using QuranPlayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Islamic_app
{
  
    public partial class AzkarForm : Form
    {
        design design = new design();
        string[] Ahadis;
        public AzkarForm()
        {
            InitializeComponent();
            design.ApplyTheme(lblAzkar, lblMain, lblquran, lblTime,this);
            design.CustomizeForm(this);

            try
            {
                Ahadis = FileManager.ReadAllLines("ahdis.txt");
            }
            catch (Exception ex)
            {
                txtAhadis.Text = $"Error loading Ahadis: {ex.Message}";
                Ahadis = Array.Empty<string>();
            }
        }



       
        private void frmAzkar_Load(object sender, EventArgs e)
        {
            try
            {
                if (Ahadis.Length == 0)
                {
                    txtAhadis.Text = "No Ahadis found in the file.";
                    return;
                }

                Random rnd = new Random();
                txtAhadis.Text = Ahadis[rnd.Next(0, Ahadis.Length)];
            }
            catch (Exception ex)
            {
                txtAhadis.Text = $"An error occurred: {ex.Message}";
            }

        }



        private void btnExit_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {
            frmTime fTime = new frmTime();
            fTime.Show();
            this.Close();
        }


   
        private void frmAzkar_Paint(object sender, PaintEventArgs e)
        {
            Pen pen1 = new Pen(Color.Black, 2);
            pen1.StartCap = LineCap.Round;
            pen1.EndCap = LineCap.Round;

            e.Graphics.DrawLine(pen1, 100,150, this.Width -100, 150);
            e.Graphics.DrawLine(pen1, 100, 266, this.Width -100, 266);
        }

      
       

  

        private void pictureBox_MouseEnter(object sender, EventArgs e)
        {
           ((PictureBox)sender).Parent.BackColor = Color.DarkGray;
            ((PictureBox)sender).Parent.Size = new Size(250, 80);
            
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {

            ((PictureBox)sender).Parent.BackColor = Color.SlateGray;
            ((PictureBox)sender).Parent.Size = new Size(242, 76);
        }

     
        private void label_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).Parent.BackColor = Color.DarkGray;
            ((Label)sender).Parent.Size = new Size(250, 80);
            
        }

        private void Label_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).Parent.BackColor = Color.SlateGray;
            ((Label)sender).Parent.Size = new Size(242, 76);
            

        }

        private void pnl_MouseEnter(object sender, EventArgs e)
        {
            ((Panel)sender).BackColor = Color.DarkGray;
            ((Panel)sender).Size = new Size(250, 80);
        }

        private void pnl_MouseLeave(object sender, EventArgs e)
        {
            ((Panel)sender).BackColor = Color.SlateGray;
            ((Panel)sender).Size = new Size(242, 76);


        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            try
            {


                // Check if the file has content
                if (Ahadis.Length == 0)
                {
                    txtAhadis.Text = "No Ahadis found in the file.";
                    return;
                }

                // Pick a random line
                Random rnd = new Random();
                txtAhadis.Text = Ahadis[rnd.Next(0, Ahadis.Length)];
            }
            catch (FileNotFoundException)
            {
                txtAhadis.Text = "The file 'ahdis.txt' was not found.";
            }
            catch (Exception ex)
            {
                txtAhadis.Text = $"An error occurred: {ex.Message}";
            }
        }
        private void openAzkarSabahForm()
        {
            frmAzkarSabah Sabah = new frmAzkarSabah();
            Sabah.ShowDialog();
        }

        private void openAzkarmasa2Form()
        {
            frmAzkarMasa2 Masa2 = new frmAzkarMasa2();
            Masa2.ShowDialog();
        }

        private void OpenSleepingAzkarForm()
        {
            SleepingAzkarForm sleepingAzkarForm = new SleepingAzkarForm();
            sleepingAzkarForm.ShowDialog();
        }

        private void OpenPrayingAzkarForm()
        {
            PrayingAzkarForm praying = new PrayingAzkarForm();
            praying.ShowDialog();
        }


        private void OpenMosqueAzkarForm()
        {
            MosqueAzkar mosqueAzkar = new MosqueAzkar();
            mosqueAzkar.ShowDialog();
        }

        private void OpenWakingUpAzkarForm()
        {
            WakingUpAzkarForm wakingUpAzkarForm = new WakingUpAzkarForm();
            wakingUpAzkarForm.ShowDialog();

        }


        private void lblAzkarSabah_Click(object sender, EventArgs e)
        {
            openAzkarSabahForm();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openAzkarSabahForm();
        }

        private void pnlAzkarSabah_Click(object sender, EventArgs e)
        {
            openAzkarSabahForm();
        }

        private void lblMain_Click_1(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }

        private void lblNightAzkar_Click(object sender, EventArgs e)
        {
            openAzkarmasa2Form();
        }

        private void picMoon_Click(object sender, EventArgs e)
        {
            openAzkarmasa2Form();
        }

        private void pnlAzkarMasa2_Click(object sender, EventArgs e)
        {
            openAzkarmasa2Form();
        }

        private void lblSleepAzkar_Click(object sender, EventArgs e)
        {
            OpenSleepingAzkarForm();
        }

        private void picSleep_Click(object sender, EventArgs e)
        {
            OpenSleepingAzkarForm();
        }

     



        private void lblPrayAzkar_Click(object sender, EventArgs e)
        {
            OpenPrayingAzkarForm();
        }

        private void picPray_Click(object sender, EventArgs e)
        {
            OpenPrayingAzkarForm();
        }

        private void pnlAzkarNom_Click(object sender, EventArgs e)
        {
            OpenSleepingAzkarForm();
        }

        private void pnlPrayAzkar_Click(object sender, EventArgs e)
        {
            OpenPrayingAzkarForm();
        }

        private void lblMosqueAzkar_Click(object sender, EventArgs e)
        {
            OpenMosqueAzkarForm();
        }

        private void picMosque_Click(object sender, EventArgs e)
        {
            OpenMosqueAzkarForm();
        }

        private void pnlMosqueAzkar_Click(object sender, EventArgs e)
        {
            OpenMosqueAzkarForm();
        }

        private void lblWakingAzkar_Click(object sender, EventArgs e)
        {
            OpenWakingUpAzkarForm();
        }

        private void picAlarm_Click(object sender, EventArgs e)
        {
            OpenWakingUpAzkarForm();
        }

        private void pnlWakingAzkar_Click(object sender, EventArgs e)
        {
            OpenWakingUpAzkarForm();
        }

        
        private void lblquran_Click(object sender, EventArgs e)
        {
            QuranForm.Instance.Show();
            this.Close();
        }
    }
}
