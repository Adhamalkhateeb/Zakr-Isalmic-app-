using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Islamic_app
{
    public partial class frmAzkarMasa2 : Form
    {
        private List<Button> _btnRepeats;
        private List<Panel> _panels;
        private clsAzkar _azkar;
        
        public frmAzkarMasa2()
        {
            InitializeComponent();
           
            _btnRepeats = new List<Button>
            {
               btnRepeats1,btnRepeats32, btnRepeats2, btnRepeats3, btnRepeats4, btnRepeats5,
               btnRepeats6, btnRepeats7, btnRepeats8, btnRepeats9, btnRepeats10,
               btnRepeats11, btnRepeats12, btnRepeats13, btnRepeats14, btnRepeats15,
               btnRepeats16, btnRepeats17, btnRepeats18, btnRepeats19, btnRepeats20,
               btnRepeats21, btnRepeats22, btnRepeats23, btnRepeats24, btnRepeats25,
               btnRepeats26, btnRepeats27, btnRepeats28, btnRepeats29, btnRepeats30
            };

            _panels = new List<Panel>
            {
                pnl1,pnl32, pnl2, pnl3, pnl4, pnl5, pnl6, pnl7, pnl8, pnl9,
                pnl10, pnl11, pnl12, pnl13, pnl14, pnl15, pnl16, pnl17, pnl18, pnl19,
                pnl20, pnl21, pnl22, pnl23, pnl24, pnl25, pnl26, pnl27, pnl28, pnl29,
                pnl30
            };

            TextBox[] textBoxes = new TextBox[]
            {
                txt1,txt32, txt2, txt3, txt4, txt5, txt6, txt7, txt8, txt9, txt10, txt11,
                txt12, txt13, txt14, txt15, txt16, txt17, txt18, txt19, txt20, txt21,
                txt22, txt23, txt24, txt25, txt26, txt27, txt28, txt29,txt30
            };

            _azkar = new clsAzkar(textBoxes, _panels, _btnRepeats, this);
            _azkar.ActivateTextBoxForClick();
        }

        private void frmAzkarMasa2_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Pen CreatePen()
        {
            return new Pen(Color.Black, 2) { StartCap = System.Drawing.Drawing2D.LineCap.Triangle, EndCap = System.Drawing.Drawing2D.LineCap.Triangle };
        }

        private void frmAzkarMasa2_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen1 = CreatePen())
            {
                e.Graphics.DrawLine(pen1, 100, 150, this.Width - 100, 150);

                for (int i = 0; i < _panels.Count; i++)
                {
                    if (_btnRepeats[i].Text != "0" && _panels[i].Visible)
                    {
                        e.Graphics.DrawLine(pen1, 100, 17 + _panels[i].Bottom, this.Width - 100, 17 + _panels[i].Bottom);
                    }
                }
            }
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
