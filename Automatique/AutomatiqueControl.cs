using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Automatique
{
    public enum AutomatiqueControlType { Keyboard, LeftClick, RightClick, MiddleClick, Scroll, Wait}

    /// <summary>
    /// 自動実行するキーや待機時間などを保持するクラス。このクラスでリスト自動実行リストをつくる。
    /// </summary>
    class AutomatiqueControl
    {
        private AutomatiqueControlType controlType;
        private int interval;
        private string key;
        private Point clickPosition;

        public AutomatiqueControl(AutomatiqueControlType type, int intervalToNext = 200, string keyToSend = "", int clickPositionX=0, int clickPositionY = 0)
        {
            controlType = type;
            this.interval = intervalToNext;
            key = keyToSend;
            clickPosition = new Point(clickPositionX, clickPositionY);
        }
    }
}
