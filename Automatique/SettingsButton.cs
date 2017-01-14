using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Diagnostics.Debug;
using System.Drawing;

namespace Automatique
{
    class SettingsButton : Button
    {
        private SettingsForm settingsForm;

        public SettingsButton()
        {
            ControlInitializer.ButtonInitialize(this, "Settings", 20, 20 , 120, 30);
            this.Click += SettingsButton_Click;
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            WriteLine("settings button");

            if (FormUtility.IsFormAlreadyOpen(settingsForm) == false)
            {
                settingsForm = new SettingsForm();
                settingsForm.Show();
            }
        }


    }
}
