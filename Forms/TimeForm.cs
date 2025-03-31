using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.CompilerServices;
using System.Data.SqlTypes;
using WMPLib;
using System.Diagnostics.Eventing.Reader;
using QuranPlayer;


namespace Islamic_app
{
    public partial class frmTime : Form
    {
        design design = new design();
        public frmTime()
        {
            InitializeComponent();
            design.CustomizeForm(this);
            design.ApplyTheme(lblTime, lblAzkar, lblquran, lblMain, this);
            GetPraysTime();

        }

        TimeSpan remainingTime;
        int Hours,Minutes,Seconds;      
        string[] TimeOfPrays;
        DateTime[] Prays = new DateTime[6];
        

        WindowsMediaPlayer WMP = new WindowsMediaPlayer();
       
        private void TimeForPrayNotify()
        {
            
                WMP.URL = "038.mp3.mp3";
                WMP.controls.play();
          
           

            if (lblNextPray.Tag.ToString() == "1")
            {

                notifyIcon1.ShowBalloonTip(5000, "موعد الاذان", "حان الأن موعد صلاة الظهر", ToolTipIcon.Info);

            }
            else if(lblNextPray.Tag.ToString() == "2")
            {
                
                notifyIcon1.ShowBalloonTip(5000, "موعد الاذان", "حان الأن موعد صلاة العصر", ToolTipIcon.Info);
            }
            else if (lblNextPray.Tag.ToString() == "3")
            {
              
                notifyIcon1.ShowBalloonTip(5000, "موعد الاذان", "حان الأن موعد صلاة المغرب", ToolTipIcon.Info);
            }
            else if (lblNextPray.Tag.ToString() == "4")
            {
               
                notifyIcon1.ShowBalloonTip(5000, "موعد الاذان", "حان الأن موعد صلاة العشاء", ToolTipIcon.Info);
            }
            else
            {
                
                notifyIcon1.ShowBalloonTip(5000, "موعد الاذان", "حان الأن موعد صلاة الفجر", ToolTipIcon.Info);

            }

            
            

        }

        private TimeSpan GetTimeDifference(DateTime targetTime, DateTime currentTime)
        {
             if (lblNextPray.Tag.ToString() == "1")
            {
                targetTime = targetTime.AddDays(1);
            }
                return targetTime - currentTime;
        }


        private void GetNextPrayName(DateTime[] prayerTimes, DateTime currentTime)
        {
            for (int i = 0; i < prayerTimes.Length; i++)
            {
                if (currentTime < prayerTimes[i])
                {
                    string[] prayerNames = { "الفجر", "الظهر", "العصر", "المغرب", "العشاء" };
                    lblNext.Text = $"{prayerNames[i]}:";
                    lblNextPray.Text = prayerNames[i];
                    lblNextPray.Tag = (i).ToString();

                    // Update timer variables
                    Hours = prayerTimes[i].Hour;
                    Minutes = prayerTimes[i].Minute;
                    Seconds = prayerTimes[i].Second;
                    return;
                }
            }

            // If no prayers are left today, set the next day's Fajr
            lblNext.Text = "الفجر :";
            lblNextPray.Text = "الفجر";
            lblNextPray.Tag = "1";

            // Set timer to next day's Fajr
            Hours = prayerTimes[0].Hour;
            Minutes = prayerTimes[0].Minute;
            Seconds = prayerTimes[0].Second;
            
        }

        private void GetPraysTime()
        {
            PrayTime prayTime = new PrayTime();

            prayTime.setCalcMethod(5);
            prayTime.setAsrMethod(0);

            double CityLat = 30.9852;
            double CityLong = 31.2155;

            var dt = DateTime.Now;
            var tz = TimeZone.CurrentTimeZone.GetUtcOffset(dt).Hours;

            TimeOfPrays = prayTime.getDatePrayerTimes(dt.Year, dt.Month, dt.Day, CityLat, CityLong, tz);

            lblfagr.Text = TimeOfPrays[0];
            lblSunRise.Text = TimeOfPrays[1];
            lblDhur.Text = TimeOfPrays[2];
            lblAsr.Text = TimeOfPrays[3];
            lblMaghrub.Text = TimeOfPrays[4];
            lblIsha.Text = TimeOfPrays[6];

            
            Prays[0] = DateTime.Parse(TimeOfPrays[0]); // Fajr
            for (int i = 1; i < 4; i++)
            {
                Prays[i] = DateTime.Parse(TimeOfPrays[i + 1]); // Dhur, Asr, Maghrib
            }
            Prays[4] = DateTime.Parse(TimeOfPrays[6]); // Isha

            GetNextPrayName(Prays, dt);
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblMain_Click(object sender, EventArgs e)
        {
          
            Application.OpenForms[0].Show();
            this.Close();
            
            
        }

        private void TimeForm_Load(object sender, EventArgs e)
        {
            
            DateTime dt = DateTime.Now;
            lblClockNow.Text = dt.ToString("hh:mm:ss tt");
            remainingTime = GetTimeDifference(new DateTime(dt.Year, dt.Month, dt.Day, Hours, Minutes, Seconds), dt);
            lblRemaining.Text = $"{remainingTime.Hours}:{remainingTime.Minutes}:{remainingTime.Seconds}";

        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            WMP.controls.stop();
        }

        private void lblAzkar_Click(object sender, EventArgs e)
        {
            AzkarForm frmAzkar = new AzkarForm();
            frmAzkar.Show();
            this.Close();
        }

        
        private void lblquran_Click(object sender, EventArgs e)
        {
            QuranForm.Instance.Show() ;
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
                         
            remainingTime = GetTimeDifference(new DateTime(now.Year, now.Month, now.Day, Hours, Minutes, Seconds), now);
            

            // If prayer time is reached
            if (remainingTime.TotalSeconds <= 1)
            {
                TimeForPrayNotify(); // Notify about the prayer
                GetNextPrayName(Prays, now); // Refresh prayer times and update target time

                remainingTime = GetTimeDifference(new DateTime(now.Year, now.Month, now.Day, Hours, Minutes, Seconds), now);

            }

            // Update countdown display
            lblClockNow.Text = now.ToString("hh:mm:ss tt");
            lblRemaining.Text = $"{remainingTime.Hours}:{remainingTime.Minutes}:{remainingTime.Seconds}";
        }


        private void TimeForm_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 2);
            pen.StartCap = LineCap.RoundAnchor;
            pen.EndCap = LineCap.RoundAnchor;
            e.Graphics.DrawLine(pen, 0, 250, this.Width, 250);
        }
    }
}

