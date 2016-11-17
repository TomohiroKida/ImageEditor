using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace BmpClass
{
    public static class DealBmp
    {
        // Bitmapからデータを出力
        public static Color[,] DataFromBmp(Bitmap bmp)
        {
            int width = bmp.Width;
            int height = bmp.Height;
            Color[,] pixelData = new Color[width, height];

            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    pixelData[i, j] = bmp.GetPixel(i, j);
                }
            }

            return pixelData;
        }

        // データからBitmapを出力
        public static Bitmap BmpFromData(Color[,] pixelData)
        {
            int width = pixelData.GetLength(0);
            int height = pixelData.GetLength(1);
            Bitmap saveImg = new Bitmap(width, height);

            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    saveImg.SetPixel(i, j, pixelData[i, j]);
                }
            }

            return saveImg;
        }

        // BmpからImageを出力
        public static Image ImageFromBmp(Bitmap bmp)
        {
            IntPtr ip = bmp.GetHbitmap();
            var img = Image.FromHbitmap(ip);

            return img;
        }
    }
}
