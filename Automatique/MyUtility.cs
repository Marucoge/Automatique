using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Automatique
{
     class MyUtility
    {
    }


    public static class ControlInitializer
    {
        public static void ButtonInitialize(Button button, string text = "HogeButton", int positionX = 0, int positionY = 0, int width = 75, int height = 23)
        {
            button.Text = text;
            button.Location = new Point(positionX, positionY);
            button.Width = width;
            button.Height = height;

            DarkenButtonThemes(button);
        }

        private static void DarkenButtonThemes(Button button)
        {
            button.BackColor = Color.FromArgb(255, 40, 40, 40);
            button.ForeColor = Color.FromArgb(255, 180, 180, 180);
        }

        public static void FormInitialize(Form form, string text = "HogeForm", int width = 300, int height = 300)
        {
            form.Text = text;
            form.Width = width;
            form.Height = height;

            DarkenFormThemes(form);
        }

        private static void DarkenFormThemes(Form form)
        {
            form.BackColor = Color.FromArgb(255, 40, 40, 40);
            form.ForeColor = Color.FromArgb(255, 180, 180, 180);
        }
    }




    public static class KeysToSend
    {
        public static string Backspace { get; set; }
        public static string Break { get; set; }
        public static string CapsLock { get; set; }
        public static string Delete { get; set; }
        public static string DownArrow { get; set; }
        public static string End { get; set; }
        public static string Enter { get; set; }
        public static string Esc { get; set; }
        public static string Help { get; set; } // Helpキーってなんだ？
        public static string Home { get; set; }
        public static string Insert { get; set; }
        public static string LeftArrow { get; set; }
        public static string NumLock { get; set; }
        public static string PageDown { get; set; }
        public static string PageUp { get; set; }
        public static string PrintScreen { get; set; }
        public static string RightArrow { get; set; }
        public static string ScrollLock { get; set; }
        public static string Tab { get; set; }
        public static string UpArrow { get; set; }

        // staticクラスのコンストラクタはprivate?public?
        static KeysToSend()
        {
            Backspace = "{BACKSPACE}";
            Break = "{BREAK}";
            CapsLock = "{CAPSLOCK}";
            Delete = "{DELETE}";
            DownArrow = "{DOWN}";
            End = "{END}";
            Enter = "{ENTER}";
            Esc = "{ESC}";
            Help = "{HELP}";
            Home = "{HOME}";
            Insert = "{INSERT}";
            LeftArrow = "{LEFT}";
            NumLock = "{NUMLOCK}";
            PageDown = "{PGDN}";
            PageUp = "{PGUP}";
            PrintScreen = "{PRTSC}";    // (reserved for future use)と書いてある
            RightArrow = "{RIGHT}";
            ScrollLock = "{SCROLLLOCK}";
            Tab = "{TAB}";
            UpArrow = "{UP}";
        }
    }

    public static class MyMath
    {
        /// <summary>
        /// 受け取ったintの桁数を調べる。現在負の数には対応してない。
        /// </summary>
        public static int IntDigits(int number)
        {
            if (number < 0) { return 0; }

            // int は十桁まで扱えるようだ。
            // 処理速度や独立性(?)を考えなければ、10のn乗と記述するやり方のほうが読みやすいコードになる。
            if (number < 10) { return 1; }
            if (number < 100) { return 2; }
            if (number < 1000) { return 3; }
            if (number < 10000) { return 4; }
            if (number < 100000) { return 5; }
            if (number < 1000000) { return 6; }
            if (number < 10000000) { return 7; }
            if (number < 100000000) { return 8; }
            if (number < 1000000000) { return 9; }
            
            return 10;  // intならもう十桁しか残ってないはず。
        }
    }


    public static class FormUtility
    {
        public static bool IsFormAlreadyOpen(Form form)
        {
            if (form == null || form.IsDisposed) { return false; }
            else { return true; }
        }
    }
}
