using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Diagnostics.Debug;
using System.Drawing;

namespace Automatique
{
    /// <summary>
    ///  マウスカーソルの座標を表示するパネル。System.~ 以外に依存しているクラスは無し。
    /// </summary>
    public class CursorPositionDisplayPanel : Panel
    {
        #region
        private Label label;
        private string labelDefaultText;
        private string switchDefaultText;
        private Timer timer;
        private Button timerPowerSwitch;
        #endregion

        public CursorPositionDisplayPanel()
        {
            labelDefaultText = "<= To register auto-click, \n press this button.";
            switchDefaultText = "Click";

            Location = new Point(20, 400);
            Width = 260;
            Height = 36;
            BackColor = Color.FromArgb(80, 0, 0, 0);

            InitializeTimerSwitch();
            InitializeLabel();
            
            timer = new Timer();
            timer.Interval = 500;
            timer.Tick += Timer_Tick;
        }

        private void InitializeTimerSwitch()
        {
            timerPowerSwitch = new Button();
            timerPowerSwitch.Text = switchDefaultText;
            timerPowerSwitch.BackColor = Color.FromArgb(255, 60, 60, 60);
            timerPowerSwitch.ForeColor = Color.FromArgb(255, 200, 200, 200);
            timerPowerSwitch.Width = 100;
            timerPowerSwitch.Height = 20;
            timerPowerSwitch.Location = new Point(0, 0);
            timerPowerSwitch.Click += TimerPowerSwitch_Click;
            Controls.Add(timerPowerSwitch);
        }

        private void TimerPowerSwitch_Click(object sender, EventArgs e)
        {
            timer.Enabled = !timer.Enabled;

            if (timer.Enabled)
            {
                timerPowerSwitch.Text = "Press Enter";
            } else {
                label.Text = labelDefaultText;
                timerPowerSwitch.Text = switchDefaultText;
                RegisterClick();
            }
        }

        private void RegisterClick()
        {

        }

        private void InitializeLabel()
        {
            label = new Label();
            label.Location = new Point(timerPowerSwitch.Width, 0);
            label.AutoSize = true;
            label.Text = labelDefaultText;
            label.BackColor = Color.FromArgb(100, 0, 0, 0);
            Controls.Add(label);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            string description = "Your cursor is at...";
            string displayX = "X : " + Cursor.Position.X.ToString();
            string displayY = "Y : " + Cursor.Position.Y.ToString();
            label.Text = description + "\n" + displayX + "\n" + displayY;
        }
    }
}
