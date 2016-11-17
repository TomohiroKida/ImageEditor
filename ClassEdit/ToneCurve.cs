using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditClass
{
    public static class ToneCurve
    {
        // テンプレート
        public static int Template(int x)
        {
            return x;
        }

        // S字
        public static int S_Shaped(int x)
        {
            return (int)(255 / (1 + Math.Exp(-x + 127)));
        }

        // サイン
        public static int Sin(int x)
        {
            return (int)(255 * Math.Sin((Math.PI / 2) * (x / 255)));
        }

        // コサイン
        public static int Cos(int x)
        {
            return (int)(255 * Math.Cos((Math.PI / 2) * (x / 255)));
        }
    }
}
