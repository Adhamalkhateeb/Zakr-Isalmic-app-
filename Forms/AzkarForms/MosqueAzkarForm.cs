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
    public partial class MosqueAzkar : Form
    {
        private List<Button> _btnRepeats;
        private List<Panel> _panels;
        private clsAzkar _azkar;
        public MosqueAzkar()
        {
            InitializeComponent();

            _btnRepeats = new List<Button>
            {
               btnRepeats1,btnRepeats2, btnRepeats3
            };

            _panels = new List<Panel>
            {
                pnl1, pnl2, pnl3
            };

            TextBox[] textBoxes = new TextBox[]
            {
                txt1, txt2, txt3
            };

            _azkar = new clsAzkar(textBoxes, _panels, _btnRepeats, this);
            _azkar.ActivateTextBoxForClick();
        }

        private void MosqueAzkar_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;
        }

        private Pen CreatePen()
        {
            return new Pen(Color.Black, 2) { StartCap = System.Drawing.Drawing2D.LineCap.Triangle, EndCap = System.Drawing.Drawing2D.LineCap.Triangle };
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MosqueAzkar_Paint(object sender, PaintEventArgs e)
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
    }
}
