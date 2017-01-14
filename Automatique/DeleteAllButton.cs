using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Diagnostics.Debug;

namespace Automatique
{
    class DeleteAllButton : Button
    {
        private YesNoCancelWindow yesOrNoWindow;

        public DeleteAllButton()
        {
            ControlInitializer.ButtonInitialize(this, "Delete All", 500, 400);
            Click += DeleteAllButton_Click;
        }

        private void DeleteAllButton_Click(object sender, EventArgs e)
        {
            WriteLine("DeleteAll Button is pressed");
            ConfirmDeleteAll();
        }

        private void ConfirmDeleteAll()
        {
            if (FormUtility.IsFormAlreadyOpen(yesOrNoWindow)) { return; }

            yesOrNoWindow = new YesNoCancelWindow();
            yesOrNoWindow.YesButt.Click += YesButt_Click;
            yesOrNoWindow.NoButt.Click += NoButt_Click;
            yesOrNoWindow.CancelButt.Click += CancelButt_Click;
            yesOrNoWindow.Show();
        }

        private void CancelButt_Click(object sender, EventArgs e)
        {
            WriteLine("CancelButt is pressed");
            yesOrNoWindow.Close();
        }
        private void NoButt_Click(object sender, EventArgs e)
        {
            WriteLine("NoButt is pressed");
            yesOrNoWindow.Close();
        }
        private void YesButt_Click(object sender, EventArgs e)
        {
            WriteLine("YessButt is pressed");
            StartForm.StartWindow.AutoControlPlan.Clear();  // 確認画面を出したい。
            StartForm.StartWindow.listPanel.UpdatePanel(StartForm.StartWindow.AutoControlPlan);
            yesOrNoWindow.Close();
        }
    }

    class ConfirmationWindow : Form
    {
        public ConfirmationWindow()
        {
            ControlInitializer.FormInitialize(this, "Confirmation", 300, 180);
        }
    }
}
