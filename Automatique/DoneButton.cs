using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Diagnostics.Debug;

namespace Automatique
{
    public class DoneButton : Button
    {

        public DoneButton()
        {
            ControlInitializer.ButtonInitialize(this, "Done", 300, 400);
            this.Click += DoneButton_Click;
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            WriteLine("DoneButton");
            FindForm().Close();
        }
    }
}
