using System;
using System.Drawing;

namespace EditClass
{
    /// <summary>
    /// 入力: 2次元配列のカラーデータ
    /// 出力: 変更後のカラーデータ
    /// </summary>
    public static class DoEdit
    {
        // テンプレート
        public static Color[,] Template(Color[,] beforepixel)
        {
            int width = beforepixel.GetLength(0);
            int height = beforepixel.GetLength(1);
            Color[,] repixel = new Color[width, height];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {

                }
            }
            return repixel;
        }

        // グレースケール
        public static Color[,] GrayScale(Color[,] beforepixel)
        {
            int width = beforepixel.GetLength(0);
            int height = beforepixel.GetLength(1);
            Color[,] repixel = new Color[width, height];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Color ori = beforepixel[i, j];

                    int brightness = (int)(ori.GetBrightness() * 255);
                    repixel[i, j] = Color.FromArgb(
                        ori.A,
                        brightness,
                        brightness,
                        brightness);
                }
            }

            return repixel;
        }

        // ネガポジ(RGB)
        public static Color[,] NegaPosi(Color[,] beforepixel)
        {

            int width = beforepixel.GetLength(0);
            int height = beforepixel.GetLength(1);
            Color[,] repixel = new Color[width, height];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Color ori = beforepixel[i, j];
                    repixel[i, j] = Color.FromArgb(
                        ori.A,
                        255 - ori.R,
                        255 - ori.G,
                        255 - ori.B);
                }
            }

            return repixel;
        }

        // トーンカーブ
        public static Color[,] ToneCurve(Color[,] beforepixel, Func<int, int> tonecurveFunc)
        {
            int width = beforepixel.GetLength(0);
            int height = beforepixel.GetLength(1);
            Color[,] repixel = new Color[width, height];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Color ori = beforepixel[i, j];
                    repixel[i, j] = Color.FromArgb(
                        ori.A,
                        tonecurveFunc(ori.R),
                        tonecurveFunc(ori.G),
                        tonecurveFunc(ori.B));
                }
            }
            return repixel;
        }

        // 線形フィルタ
        public static Color[,] LinearFilter(Color[,] beforepixel, float[,] kernel)
        {
            int width = beforepixel.GetLength(0);
            int height = beforepixel.GetLength(1);
            int kw = kernel.GetLength(0);
            int kh = kernel.GetLength(1);
            float r, g, b;

            Color[,] repixel = new Color[width, height];
            for (int i = 1; i < height - 1; i++)
            {
                for (int j = 1; j < width - 1; j++)
                {
                    r = 0;
                    g = 0;
                    b = 0;
                    Color ori = beforepixel[i, j];
                    for (int m = 0; m < kw; m++)
                    {
                        for (int n = 0; n < kh; n++)
                        {
                            r += beforepixel[i + m - 1, j + n - 1].R * kernel[m, n];
                            g += beforepixel[i + m - 1, j + n - 1].G * kernel[m, n];
                            b += beforepixel[i + m - 1, j + n - 1].B * kernel[m, n];
                        }
                    }
                    repixel[i, j] = Color.FromArgb(
                        ori.A,
                        (int)r,
                        (int)g,
                        (int)b);
                }
            }
            return repixel;
        }
    }
}
