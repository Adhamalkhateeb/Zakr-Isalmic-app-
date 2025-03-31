using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Islamic_app
{
    internal class clsAzkar
    {
        private TextBox[] _txtBoxesOfAzkar;
        private List<Panel> _PnlsOfAzkar;
        private List<Button> _BtnsOfRepeatTime;
        private Form _form;

        public clsAzkar(TextBox[] txtBoxesOfAzkar, List<Panel> pnlsOfAzkar, List<Button> btnsOfRepeatTime, Form form)
        {
            _txtBoxesOfAzkar = txtBoxesOfAzkar;
            _PnlsOfAzkar = pnlsOfAzkar;
            _BtnsOfRepeatTime = btnsOfRepeatTime;
            _form = form;
        }

        private void CloseFormIfAllPanelsHidden()
        {
            if (_PnlsOfAzkar.All(p => !p.Visible))
            {
                _form.Close();
            }
        }

        private void UpdateFormLinesPaint(Panel current, int now)
        {
            current.Visible = false;
            int shiftAmount = current.Height + 27;

            var panelsToShift = _PnlsOfAzkar.Skip(now + 1).Where(p => p.Visible);
            foreach (var panel in panelsToShift)
            {
                panel.Top -= shiftAmount;
            }

            CloseFormIfAllPanelsHidden();
        }

        public void DecreaseRepeatTimeCounter(Button button, Panel panel, int index)
        {
            if (int.TryParse(button.Text, out int count) && count > 0)
            {
                button.Text = (--count).ToString();

                if (count == 0)
                {
                    UpdateFormLinesPaint(panel, index);
                }
                button.Focus();
            }
        }

        public void ActivateTextBoxForClick()
        {
            for (int i = 0; i < _txtBoxesOfAzkar.Length; i++)
            {
                int index = i;
                _txtBoxesOfAzkar[i].MouseClick += (s, e) => DecreaseRepeatTimeCounter(_BtnsOfRepeatTime[index], _PnlsOfAzkar[index], index);
            }
        }

    }
}
