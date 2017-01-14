using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Diagnostics.Debug;
using System.Windows.Forms;

namespace Automatique
{
    public class YesNoCancelWindow : Form
    {
        #region
        public Button YesButt { get; private set; }
        public Button NoButt { get; private set; }
        public Button CancelButt { get; private set; }
        private  bool darkTheme;
        #endregion

        public YesNoCancelWindow(int width = 300, int height = 120, bool isDarkTheme = true)
        {
            Width = width;
            Height = height;
            darkTheme = isDarkTheme;

            Label label = new Label();
            label.Location = new System.Drawing.Point(100, 8);
            label.Text = "Are you sure?";
            Controls.Add(label);

            YesButt = new Button();
            ButtInitialize(YesButt, "Yes", 70, 24, 20, 38);
            Controls.Add(YesButt);
            NoButt = new Button();
            ButtInitialize(NoButt, "No", 70 ,24, 100, 38);
            Controls.Add(NoButt);
            CancelButt = new Button();
            ButtInitialize(CancelButt, "Cancel", 70, 24, 180, 38);
            Controls.Add(CancelButt);

            if (darkTheme == false) { return; }
            BackColor = System.Drawing.Color.FromArgb(255, 40, 40, 40);
            ForeColor = System.Drawing.Color.FromArgb(255, 180, 180, 180);
        }

        public void ButtInitialize(Button butt, string text, int width = 100, int height = 24, int positionX = 0, int positionY = 0)
        {
            butt.Text = text;
            butt.Width = width;
            butt.Height = height;
            butt.Location = new System.Drawing.Point(positionX, positionY);
            butt.AutoSize = true;

            if(darkTheme == false) { return; }
            butt.BackColor = System.Drawing.Color.FromArgb(255, 40, 40, 40);
            butt.ForeColor = System.Drawing.Color.FromArgb(255, 180, 180, 180);
        }


    }
}
