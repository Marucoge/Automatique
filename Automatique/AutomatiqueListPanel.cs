using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using static System.Diagnostics.Debug;

namespace Automatique
{
    public class AutomatiqueListPanel : Panel
    {
        public Label AutomatiqueListLabel { get; set; }

        public AutomatiqueListPanel()
        {
            PanelInitialize();
            LabelInitialize();
        }

        private void PanelInitialize()
        {
            BackColor = Color.FromArgb(80, 0, 0, 0);
            AutoScroll = true;
            Location = new Point(20, 70);
            Width = 160;
            Height = 340;
        }

        private void LabelInitialize()
        {
            AutomatiqueListLabel = new Label();
            AutomatiqueListLabel.AutoSize = true;
            AutomatiqueListLabel.BackColor = Color.FromArgb(0, 0, 0, 0);
            AutomatiqueListLabel.Text = "";
            Controls.Add(AutomatiqueListLabel);
        }

        public void UpdatePanel(List<string> decidedList)
        {
            AutomatiqueListLabel.Text = "";

            for (int i=0; i<decidedList.Count; i++)
            {
                string blankSpace = new string(' ', (10 - MyMath.IntDigits(i) ) );
                string line = "#" + i + blankSpace +  decidedList[i] + "\n";
                AutomatiqueListLabel.Text += line;
            }

            AutoScrollPosition = new Point(0, AutomatiqueListLabel.Size.Height);
        }

    }
}
