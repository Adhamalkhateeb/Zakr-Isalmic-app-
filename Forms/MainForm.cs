using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using QuranPlayer;

namespace Islamic_app
{
    public partial class FrmMain : Form
    {

        design design = new design();
        
        public FrmMain()
        {
        

            InitializeComponent();
            design.ApplyTheme(lblMain, lblAzkar, lblquran,lblTime,this);
            design.CustomizeForm(this);
            label5.ForeColor = Color.DimGray;
            label6.Text = "مرحبًا بك في برنامج ذكر  \r\n رفيقك اليومي لذكر الله وتقوية صلتك به.  \r\nاجعل وقتك عامرًا بالطاعات، وذكّر قلبك وروحك بأن الذكر نور وهداية.  \r\nنسأل الله أن يكون هذا البرنامج معينًا لك على الخير، وسببًا لنيل رضاه.  \r\nوفقك الله وجعل يومك مباركًا.  \r\n";
            label6.Location = new Point(39, 248);
       
        }


        private void FrmMain_Paint(object sender, PaintEventArgs e)
        {

            Pen pen2 = new Pen(Color.Black, 3);
            e.Graphics.DrawLine(pen2, 200, 230, 950, 230);
            e.Graphics.DrawLine(pen2, 200, 400, 950, 400);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void lblTime_Click(object sender, EventArgs e)
        {
            frmTime tform = new frmTime();
            this.Hide();
            tform.Show();

        }


        private void lblAzkar_Click(object sender, EventArgs e)
        {
            AzkarForm frmAzkar = new AzkarForm();
            this.Hide();
            frmAzkar.Show();

        }

        
     
        private void lblquran_Click(object sender, EventArgs e)
        {
            QuranForm.Instance.Show();  
             this.Hide();
              
        }
    }
}