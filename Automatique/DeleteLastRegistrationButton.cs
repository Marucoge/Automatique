using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Diagnostics.Debug;

namespace Automatique
{
    public class DeleteLastRegistrationButton : Button
    {
        public DeleteLastRegistrationButton()
        {
            ControlInitializer.ButtonInitialize(this, "Delete", 400, 400);
            Click += DeleteLastRegistrationButton_Click;
        }

        private void DeleteLastRegistrationButton_Click(object sender, EventArgs e)
        {
            if (StartForm.StartWindow.AutoControlPlan.Count < 1) { return; }

            StartForm.StartWindow.AutoControlPlan.RemoveAt(StartForm.StartWindow.AutoControlPlan.Count - 1);
            StartForm.StartWindow.UpdateListPanel();
        }
    }
}
