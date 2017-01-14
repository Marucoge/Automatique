using System;
using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Diagnostics.Debug;

namespace Automatique
{
    public partial class StartForm : Form
    {
        public List<string> AutoControlPlan;
        public static StartForm StartWindow { get; private set; }
        public AutomatiqueListPanel listPanel;

        public StartForm()
        {
            InitializeComponent(); // はじめから書いてあるメソッド。デザイナと関係しているらしい。
            InitializeStartForm();
        }

        private void InitializeStartForm()
        {
            AutoControlPlan = new List<string>();
            ControlInitializer.FormInitialize(this, "Automatique", 600, 480);
            this.Controls.Add(new SettingsButton());
            StartWindow = this;

            listPanel = new AutomatiqueListPanel();
            this.Controls.Add(listPanel);

            ImplementationButton runButton = new ImplementationButton();
            Controls.Add(runButton);
        }


        public void AddAndShowAutoControls(string _keycode)
        {
            AutoControlPlan.Add(_keycode);
            listPanel.UpdatePanel(AutoControlPlan);
        }



        public void UpdateListPanel()
        {
            listPanel.UpdatePanel(AutoControlPlan);
        }
    }
    
    
}
