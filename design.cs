using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Islamic_app
{
    internal class design
    {
        

        public  void ApplyTheme(System.Windows.Forms.Label Active, System.Windows.Forms.Label lastActivated, System.Windows.Forms.Label l2,
            System.Windows.Forms.Label l3,Form frm)
        {
            


            

            Active.ForeColor = Color.DarkGray;

            lastActivated.Font = new Font(lastActivated.Font, FontStyle.Regular);


            StyleInteractiveLabel(lastActivated, Color.Black, Color.DarkGray);
            StyleInteractiveLabel(l2, Color.Black, Color.DarkGray);
            StyleInteractiveLabel(l3, Color.Black, Color.DarkGray);
           


            frm.Paint += (s, e) =>
            {
                using (Pen pen = new Pen(Color.Black, 2))
                {
                    e.Graphics.DrawLine(pen, 0, 80, frm.Width, 80); // Top separator
                }
            };


        }

        private void StyleInteractiveLabel(System.Windows.Forms.Label label, Color normalColor, Color hoverColor)
        {
            label.ForeColor = normalColor;
            label.Cursor = Cursors.Hand;
            label.MouseEnter += (s, e) => label.ForeColor = hoverColor;
            label.MouseLeave += (s, e) => label.ForeColor = normalColor;


        }

        public  void CustomizeForm(Form frm)
        {
            frm.FormBorderStyle = FormBorderStyle.None;
            ApplyRoundedCorners(20, frm);

        }



        private void ApplyRoundedCorners(int radius, Form frm)
        {
            var path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(965 - radius, 0, radius, radius, 270, 90);
            path.AddArc(965 - radius, frm.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, frm.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            frm.Region = new Region(path);
        }

       
    }
}