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
       

        private readonly design design = new design();
        private TimeSpan remainingTime;
        private int Hours, Minutes, Seconds;
        private string[] TimeOfPrays;
        private DateTime[] Prays = new DateTime[6];
        private readonly WindowsMediaPlayer WMP = new WindowsMediaPlayer();
        public frmTime()
        {
            InitializeComponent();
            InitializeForm();
            GetPraysTime();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void InitializeForm()
        {
            design.CustomizeForm(this);
            design.ApplyTheme(lblTime, lblAzkar, lblquran, lblMain, this);

            // Initialize media player
            WMP.settings.volume = 80;
            notifyIcon1.BalloonTipTitle = "موعد الأذان";
        }



        private void TimeForPrayNotify()
        {
            try
            {
                string soundFile = FileManager.GetResourcePath("Sounds", "Azan.mp3");
                if (File.Exists(soundFile))
                {
                    WMP.URL = soundFile;
                    WMP.controls.play();
                }

                string prayerName = GetPrayerNameFromTag();
                notifyIcon1.ShowBalloonTip(5000, "موعد الأذان", $"حان الآن موعد صلاة {prayerName}", ToolTipIcon.Info);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in prayer notification: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetPrayerNameFromTag()
        {
            switch (lblNextPray.Tag.ToString())
            {
                case "1": return "الظهر";
                case "2": return "العصر";
                case "3": return "المغرب";
                case "4": return "العشاء";
                default: return "الفجر";
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
                    UpdatePrayerUI(prayerNames[i], i, prayerTimes[i]);
                    return;
                }
            }

            // If no prayers left today, set to next day's Fajr
            UpdatePrayerUI("الفجر", 0, prayerTimes[0].AddDays(1));
        }

        private void UpdatePrayerUI(string prayerName, int index, DateTime prayerTime)
        {
            lblNext.Text = $"{prayerName}:";
            lblNextPray.Text = prayerName;
            lblNextPray.Tag = index.ToString();

            Hours = prayerTime.Hour;
            Minutes = prayerTime.Minute;
            Seconds = prayerTime.Second;
        }

        private void GetPraysTime()
        {
            try
            {
                PrayTime prayTime = new PrayTime();
                prayTime.setCalcMethod(5);
                prayTime.setAsrMethod(0);

                double CityLat = 30.9852;  // Default coordinates (can be made configurable)
                double CityLong = 31.2155;
                var dt = DateTime.Now;
                var tz = TimeZone.CurrentTimeZone.GetUtcOffset(dt).Hours;

                TimeOfPrays = prayTime.getDatePrayerTimes(dt.Year, dt.Month, dt.Day, CityLat, CityLong, tz);

                // Update UI with prayer times
                lblfagr.Text = TimeOfPrays[0];
                lblSunRise.Text = TimeOfPrays[1];
                lblDhur.Text = TimeOfPrays[2];
                lblAsr.Text = TimeOfPrays[3];
                lblMaghrub.Text = TimeOfPrays[4];
                lblIsha.Text = TimeOfPrays[6];

                // Store prayer times for calculations
                Prays[0] = DateTime.Parse(TimeOfPrays[0]); // Fajr
                for (int i = 1; i < 4; i++)
                {
                    Prays[i] = DateTime.Parse(TimeOfPrays[i + 1]); // Dhur, Asr, Maghrib
                }
                Prays[4] = DateTime.Parse(TimeOfPrays[6]); // Isha

                GetNextPrayName(Prays, dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error calculating prayer times: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e) => Application.Exit();
        

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

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e) => WMP.controls.stop();

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

            if (remainingTime.TotalSeconds <= 1)
            {
                TimeForPrayNotify();
                GetNextPrayName(Prays, now);
                remainingTime = GetTimeDifference(new DateTime(now.Year, now.Month, now.Day, Hours, Minutes, Seconds), now);
            }

            UpdateClockDisplay(now);
        }


        private void UpdateClockDisplay(DateTime now)
        {
            lblClockNow.Text = now.ToString("hh:mm:ss tt");
            lblRemaining.Text = $"{remainingTime.Hours:D2}:{remainingTime.Minutes:D2}:{remainingTime.Seconds:D2}";
        }

        private void TimeForm_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Black, 2))
            {
                pen.StartCap = LineCap.RoundAnchor;
                pen.EndCap = LineCap.RoundAnchor;
                e.Graphics.DrawLine(pen, 0, 250, this.Width, 250);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            WMP.controls.stop();
            WMP.close();
        }
    }
}

