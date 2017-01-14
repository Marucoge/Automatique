using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Diagnostics.Debug;

namespace Automatique
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();  // はじめから書いてあるメソッド。デザイナと関係しているらしい。
            InitializeSettingForm();
            CreateRegisterButtons();
        }

        private void InitializeSettingForm()
        {
            ControlInitializer.FormInitialize(this, "Settings", 600, 480);
            
            DoneButton doneButton = new DoneButton();
            Controls.Add(doneButton);
            DeleteAllButton deleteAllButton = new DeleteAllButton();
            Controls.Add(deleteAllButton);
            DeleteLastRegistrationButton deleteButton = new DeleteLastRegistrationButton();
            Controls.Add(deleteButton);

            CursorPositionDisplayPanel cursorPositionPanel = new CursorPositionDisplayPanel();
            Controls.Add(cursorPositionPanel);
        }

   

        private void CreateRegisterButtons()
        {
            CreateRegisterButton("TAB", KeysToSend.Tab, 20, 20);
            CreateRegisterButton("Left",KeysToSend.LeftArrow, 20, 50);
        }

        private void CreateRegisterButton(string text, string keycode, int positionX, int positionY)
        {
            RegisterAutomatiqueButton registerButton = new RegisterAutomatiqueButton(keycode);
            ControlInitializer.ButtonInitialize(registerButton, text, positionX, positionY, 90, 24);
            this.Controls.Add(registerButton);
        }

        


    }
}
