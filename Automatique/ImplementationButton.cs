using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Diagnostics.Debug;

namespace Automatique
{
    public class ImplementationButton : Button
    {
        private bool isAutoControlRunning;


        public ImplementationButton()
        {
            isAutoControlRunning = true;
            ControlInitializer.ButtonInitialize(this, "Run", 200, 20, 120, 30);
            Click += ImplementationButton_Click;
        }

        private void ImplementationButton_Click(object sender, EventArgs e)
        {

            WriteLine("ImplementationButton is pressed");
            if (isAutoControlRunning == true) { return; }
            isAutoControlRunning = true;

            RunAutomatique();
        }

        // 自動実行の根幹部分。
        private void RunAutomatique()
        {
            // 入力する文字列、待機時間などを保持するクラスを作成し、そのリストを実行リストとするか。
            
        }
        

    }
}
