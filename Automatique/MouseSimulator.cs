using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;

namespace Automatique
{
    /// <summary>
    /// Simulate behaviours of the mouse (using Win32 API)
    /// </summary>
    public static class MouseSimulator
    {
        #region mouse_eventについて
        // dwは double word のことか？
        //
        // ###  mouse_event って何...  ###
        // 第一引数はマウスの動作を指定する。ここでは下に定数として宣言されているものを渡す。
        // 第二引数、第三引数はそれぞれ、MOUSEEVENTF_MOVEのときのx, y方向移動量。
        // 第四引数は MOUSEEVENTF_WHEEL のときのホイール回転量。一回のホイール？は120になる。
        // 第五引数は、"マウスイベントに関連付けられた 32 ビットの追加情報を指定する。 GetMessageExtraInfo関数を呼び出すとこの値を取得できる。 しかし、SetMessageExtraInfo関数を使わない限り0なので、普段は0でよい。"
        #endregion
        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        #region 定数の宣言。
        // Constants for the mouse_input() API function
        // 0xほにゃららとは16進数を表記するときの接頭辞。というかこれ列挙型じゃだめなのか？
        private const int MOUSEEVENTF_MOVE = 0x0001;
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const int MOUSEEVENTF_LEFTUP = 0x0004;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const int MOUSEEVENTF_RIGHTUP = 0x0010;
        private const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        private const int MOUSEEVENTF_MIDDLEUP = 0x0040;
        private const int MOUSEEVENTF_ABSOLUTE = 0x8000;
        private const int MOUSEEVENTF_WHEEL = 0x0800;
        #endregion

        #region コピペ元にはあったが使いづらいのでコメントアウトした関数たち。
        // Similates movement of the mouse. Parameters specify changes in relative position. Positive values indicate movement right or down.
        //        public static void MoveRelatively(int xDelta, int yDelta)   {    mouse_event(MOUSEEVENTF_MOVE, xDelta, yDelta, 0, 0);   }

        // Simulates~. Parameters specify an absolute location, with the top left corner being the origin.
        // 画面左上が(0,0)、画面右下が(65535,65535)になるらしい。使いづらそうなのでコメントアウト。
        //          public static void MoveTo(int x, int y)   {   mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, x, y , 0, 0);   }


        //// Simulates a click-and-release action of the left mouse button at its current position.
        //public static void LeftClick()
        //{
        //    mouse_event(MOUSEEVENTF_LEFTDOWN, Control.MousePosition.X, Control.MousePosition.Y, 0, 0);
        //    mouse_event(MOUSEEVENTF_LEFTUP, Control.MousePosition.X, Control.MousePosition.Y, 0, 0);
        //}    
        #endregion

        /// <summary>
        /// Move the cursor to the absolute position.
        /// </summary>
        /// <param name="positionX"></param>
        /// <param name="positionY"></param>
        public static void MoveAbsolutely(int positionX, int positionY)
        {
            Cursor.Position = new Point(positionX, positionY);
        }

        /// <summary>
        /// Press left mouse button at the place where the cursor is currently at.
        /// </summary>
        public static void LeftClick()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN, Cursor.Position.X, Cursor.Position.Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, Cursor.Position.X, Cursor.Position.Y, 0, 0);
        }

        /// <summary>
        /// Press right mouse button at the place where the cursor is currently at.
        /// </summary>
        public static void RightClick()
        {
            mouse_event(MOUSEEVENTF_RIGHTDOWN, Control.MousePosition.X, Control.MousePosition.Y, 0, 0);
            mouse_event(MOUSEEVENTF_RIGHTUP, Control.MousePosition.X, Control.MousePosition.Y, 0, 0);
        }

        /// <summary>
        /// Press middle mouse button (wheel click) at the place where the cursor is currently at.
        /// </summary>
        public static void MiddleClick()
        {
            mouse_event(MOUSEEVENTF_MIDDLEDOWN, Control.MousePosition.X, Control.MousePosition.Y, 0, 0);
            mouse_event(MOUSEEVENTF_MIDDLEUP, Control.MousePosition.X, Control.MousePosition.Y, 0, 0);
        }

        /// <summary>
        /// Scroll down at the place where the cursor is currently at.
        /// </summary>
        /// <param name="steps"></param>
        /// <param name="scrollAmountPerOneStep"></param>
        public static void WheelDown(int steps, int scrollAmountPerOneStep = -120)
        {
            mouse_event(MOUSEEVENTF_WHEEL, 0, 0, (scrollAmountPerOneStep*steps) , 0);
        }

        /// <summary>
        ///  Scroll up at the place where the cursor is currently at.
        /// </summary>
        /// <param name="steps"></param>
        /// <param name="scrollAmountPerOneStep"></param>
        public static void WheelUp(int steps, int scrollAmountPerOneStep = 120)
        {
            mouse_event(MOUSEEVENTF_WHEEL, 0, 0, (scrollAmountPerOneStep * steps), 0);
        }

    }
}
