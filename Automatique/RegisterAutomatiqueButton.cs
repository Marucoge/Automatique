using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Diagnostics.Debug;

namespace Automatique
{
    /// <summary>
    /// SendKeysに渡す文字列をフィールドとして持っていて、ClickでリストにAddするボタン。
    /// </summary>
    class RegisterAutomatiqueButton : Button
    {
        string keycode;

        public RegisterAutomatiqueButton(string keycodeToRegister)
        {
            keycode = keycodeToRegister;
            this.Click += RegisterAutomatiqueButton_Click;
        }

        private void RegisterAutomatiqueButton_Click(object sender, EventArgs e)
        {
            StartForm.StartWindow.AddAndShowAutoControls(keycode);
            DebugRegistration(StartForm.StartWindow.AutoControlPlan);
        }

        // 急いで書いたのであとでかくにん
        private void DebugRegistration(List<string> registration)
        {
            WriteLine("Registered " + keycode);

            for (int i = 0; i < registration.Count; i++)
            {
                WriteLine("List[" + i + "] : " + registration[i]);
            }
        }
    }
}
