using Islamic_app;
using Islamic_app.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using WMPLib;

namespace QuranPlayer
{
    public partial class QuranForm : Form
    {
        private static QuranForm _instance;
        public static QuranForm Instance => _instance ?? (_instance = new QuranForm());


        design design = new design();
        string[][] QuranSurahsNames = new string[30][];
        private string[] QuranFiles;
        WindowsMediaPlayer wmp = new WindowsMediaPlayer();
        int startingFileNumber = 0;
        string ActiveSurah = "001";

        public QuranForm()
        {
            InitializeComponent();
            design.ApplyTheme(lblquran, lblAzkar, lblMain, lblTime, this);
            design.CustomizeForm(this);

            FileManager.ExtractEmbeddedResources();

            LoadSurahToComboBox();
            LoadQuranFiles();

            wmp.controls.stop();
            

        }

        private void LoadQuranFiles()
        {
            try
            {
                string directoryPath = Path.Combine(FileManager.AppPath, "Surahs");
                QuranFiles = Directory.GetFiles(directoryPath, "*.mp3").OrderBy(f => f).ToArray();

                if (QuranFiles.Length == 0)
                {
                    MessageBox.Show("No Quran files found in the Surahs directory.",
                                  "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Quran files: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSurahToComboBox()
        {
            QuranSurahsNames[0] = new string[] { " الفَاتِحَة ", " البَقَرَة " };
            QuranSurahsNames[1] = new string[] { " البَقَرَة " };
            QuranSurahsNames[2] = new string[] { " البَقَرَة ", " آل عِمرَان " };
            QuranSurahsNames[3] = new string[] { " آل عِمرَان ", " النِّسَاء " };
            QuranSurahsNames[4] = new string[] { " النِّسَاء " };
            QuranSurahsNames[5] = new string[] { " النِّسَاء ", " المَائدة " };
            QuranSurahsNames[6] = new string[] { " المَائدة ", " الأنعَام " };
            QuranSurahsNames[7] = new string[] { " الأنعَام ", " الأعرَاف " };
            QuranSurahsNames[8] = new string[] { " الأعرَاف ", " الأنفَال " };
            QuranSurahsNames[9] = new string[] { " الأنفَال ", " التوبَة " };
            QuranSurahsNames[10] = new string[] { " التوبَة ", " يُونس ", " هُود " };
            QuranSurahsNames[11] = new string[] { " هُود ", " يُوسُف " };
            QuranSurahsNames[12] = new string[] { " يُوسُف ", " الرَّعْد ", " إبراهِيم " };
            QuranSurahsNames[13] = new string[] { " الحِجْر ", " النَّحْل " };
            QuranSurahsNames[14] = new string[] { " الإسْرَاء ", " الكهْف " };
            QuranSurahsNames[15] = new string[] { " الكهْف ", " مَريَم ", " طه " };
            QuranSurahsNames[16] = new string[] { " الأنبيَاء ", " الحَج " };
            QuranSurahsNames[17] = new string[] { " المُؤمنون ", " النُّور ", " الفُرْقان " };
            QuranSurahsNames[18] = new string[] { " الفُرْقان ", " الشُّعَرَاء ", " النَّمْل " };
            QuranSurahsNames[19] = new string[] { " النَّمْل ", " القَصَص ", " العَنكبوت " };
            QuranSurahsNames[20] = new string[] { " العَنكبوت ", " الرُّوم ", " لقمَان " , " السَّجدَة " , " الأحزَاب " };
            QuranSurahsNames[21] = new string[] { " الأحزَاب ", " سَبَأ ", " فَاطِر " , " يس " };
            QuranSurahsNames[22] = new string[] { " يس ", " الصَّافات ", " ص " , " الزُّمَر " };
            QuranSurahsNames[23] = new string[] { " الزُّمَر ", " غَافِر ", " فُصِّلَتْ " };
            QuranSurahsNames[24] = new string[] { " فُصِّلَتْ ", " الشُّورَى ", " الزُّخْرُف ", " الدُّخان ", " الجاثِية " };
            QuranSurahsNames[25] = new string[] { " الأحقاف", " مُحَمّد ", " الفَتْح " , " الحُجُرات " , " ق " , " الذَّاريَات " };
            QuranSurahsNames[26] = new string[] { " الذَّاريَات ", " الطُّور ", " النَّجْم ", " القَمَر ", " الرَّحمن ", " الواقِعَة ", " الحَديد " };
            QuranSurahsNames[27] = new string[] { " المُجادَلة ", " الحَشْر ", " المُمتَحَنة ", " الصَّف ", " الجُّمُعة " , " المُنافِقُون " , " التَّغابُن " ,
                " الطَّلاق " , " التَّحْريم " };
            QuranSurahsNames[28] = new string[] { " المُلْك ", " القَلـَم ", " الحَاقّـَة ", " المَعارِج ", " نُوح ", " الجِنّ ", " المُزَّمّـِل ", " المُدَّثــِّر ",
                " القِيامَة " , " الإنسان " , " المُرسَلات "};
            QuranSurahsNames[29] = new string[] { " النـَّبأ ", " النـّازِعات ", " عَبَس ", " التـَّكْوير ", " الإنفِطار ", " المُطـَفِّفين ", " الإنشِقاق ", " البُروج ",
                " الطّارق " , " الأعلی " , " الغاشيَة ", " الفَجْر " , " البَـلـَد " , " الشــَّمْس ", " اللـَّيل " , " الضُّحی " , " الشَّرْح ",
             " التـِّين " , " العَلـَق " , " القـَدر " ,  " البَيِّنَة " , " الزلزَلة " , " العَادِيات " , " القارِعَة " , " التَكاثـُر " , " العَصْر ",
             " الهُمَزَة " , " الفِيل " , " قـُرَيْش " ,  " المَاعُون " , " الكَوْثَر " , " الكَافِرُون " , " النـَّصر " , " المَسَد " , " الإخْلَاص ", " الفَلَق ",
             " النَّاس "};


            for (int i = 0; i < 30; i++)
            {
                cmbPart.Items.Add($"الجزء {i + 1}");
            }

            cmbPart.SelectedIndex = 0;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            wmp.controls.stop();
            Application.Exit();
        }

        private void lblAzkar_Click(object sender, EventArgs e)
        {
            AzkarForm frmAzkar = new AzkarForm();
            frmAzkar.Show();
            this.Hide();
        }

        private void lblMain_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Hide();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {
            frmTime frmTime = new frmTime();
            frmTime.Show();
            this.Hide  ();
        }



        private void cmbPart_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmbSurah.Items.Clear();

            if (cmbPart.SelectedIndex >= 0 && cmbPart.SelectedIndex < QuranSurahsNames.Length)
            {
                // Load the Surahs for the selected part
                cmbSurah.Items.AddRange(QuranSurahsNames[cmbPart.SelectedIndex]);
            }
        }



        private int GetSurahFileNumber(int partIndex, int surahIndexInPart)
        {
            startingFileNumber = 1;

            for (int i = 0; i < partIndex; i++)
            {
                startingFileNumber += QuranSurahsNames[i].Length;
            }

            startingFileNumber += surahIndexInPart;
            return startingFileNumber;
        }

        private void PlaySurah(string fileName)
        {
            try
            {
                string filePath = FileManager.GetResourcePath("Surahs", fileName);

                if (!File.Exists(filePath))
                {
                    MessageBox.Show($"Surah file not found: {filePath}",
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                wmp.controls.stop();
                wmp.URL = filePath;
                wmp.controls.play();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error playing Surah: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPlay_Click_1(object sender, EventArgs e)
        {


            if (btnPlay.Tag.ToString() == "2")
            {
                wmp.controls.pause();
                btnPlay.BackgroundImage = Resources.square_play_button;
                btnPlay.Tag = "1";
                return;
            }

            int partIndex = cmbPart.SelectedIndex;
            string selectedSurah = cmbSurah.SelectedItem?.ToString();

            if (wmp.playState == WMPPlayState.wmppsPaused && selectedSurah == ActiveSurah)
            {
                wmp.controls.play();
                btnPlay.BackgroundImage = Resources.pause_button;
                btnPlay.Tag = "2";
                return;
            }

            if (string.IsNullOrEmpty(selectedSurah))
            {
                MessageBox.Show("رجائا اختر السورة اولا ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cmbReader.SelectedIndex = 0;
            btnPlay.BackgroundImage = Resources.pause_button;
            btnPlay.Tag = "2";

            int surahIndexInPart = Array.IndexOf(QuranSurahsNames[partIndex], selectedSurah);
            if (surahIndexInPart < 0) return;

            int fileNumber = GetSurahFileNumber(partIndex, surahIndexInPart);
            string fileName = $"{fileNumber:D3}.mp3";
            ActiveSurah = selectedSurah;
            PlaySurah(fileName);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (startingFileNumber < 135)
            {
                cmbReader.SelectedIndex = 0;

                if (startingFileNumber == 0)
                {
                    cmbPart.SelectedIndex = 0;
                    cmbSurah.SelectedIndex = 0;
                }
                else
                {
                    if (cmbSurah.SelectedIndex == cmbSurah.Items.Count - 1)
                    {
                        cmbPart.SelectedIndex++;
                        cmbSurah.SelectedIndex = 0;
                    }
                    else
                    {
                        cmbSurah.SelectedIndex++;
                    }
                }

                ActiveSurah = cmbSurah.SelectedItem.ToString();
                string fileName = $"{startingFileNumber += 1:D3}.mp3";
                PlaySurah(fileName);

                if (btnPlay.Tag.ToString() == "1")
                {
                    btnPlay.Tag = "2";
                    btnPlay.BackgroundImage = Resources.pause_button;
                }
            }
            else
            {
                MessageBox.Show("انت في أخر سورة من القرآن الكريم لا يمكن تشغيل التالي اختر سورة اخري للاستماع",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {

            if (startingFileNumber > 1)
            {
                if (cmbSurah.SelectedIndex == 0)
                {
                    cmbPart.SelectedIndex--;
                    cmbSurah.SelectedIndex = cmbSurah.Items.Count - 1;
                }
                else
                {
                    cmbSurah.SelectedIndex--;
                }

                ActiveSurah = cmbSurah.SelectedItem.ToString();
                string fileName = $"{startingFileNumber -= 1:D3}.mp3";
                PlaySurah(fileName);
            }
            else
            {
                if (string.IsNullOrEmpty(cmbSurah.Text) || string.IsNullOrEmpty(cmbPart.Text))
                {
                    MessageBox.Show("اختر السورة اولا", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("انها السورة الاولي بالقرآن الكريم لا يوجد شيء قبلها اختر سورة اخري للاستماع",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void QuranForm_Load(object sender, EventArgs e)
        {
     
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void SurahTimer_Tick(object sender, EventArgs e)
        {
            if (wmp.playState == WMPPlayState.wmppsPlaying)
            {
                ProbarSurah.Maximum = (int)wmp.controls.currentItem.duration;
                ProbarSurah.Value = (int)wmp.controls.currentPosition;
            }
            ProbarSurah.Value = (int)wmp.controls.currentPosition;


        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            if (btnSound.Tag.ToString() == "1")
            {
                btnSound.BackgroundImage = Resources.mute;
                btnSound.Tag = "2";
                wmp.settings.mute = true;
            }
            else
            {
                btnSound.BackgroundImage = Resources.volume__1_;
                btnSound.Tag = "1";
                wmp.settings.mute = false;
            }
        }
    }
}