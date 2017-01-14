using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Diagnostics.Debug;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Automatique
{
    public class AutomatiqueClicker
    {
        public AutomatiqueClicker()
        {

        }

        private void AutomatiqueClick(int positionX, int positionY)
        {
            MouseSimulator.MoveAbsolutely(positionX, positionY);
            MouseSimulator.LeftClick();
        }
        
    }


}
