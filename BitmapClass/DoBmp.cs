using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BmpClass
{
    public static class DoBmp
    {
        // ImageからBitmapを生成し，colorにして，編集を実行
        public static Image Template(Image img)
        {
            var bmp = new Bitmap(img);

            // Edit
            Color[,] pixel = EditClass.DoEdit.Template(DealBmp.DataFromBmp(bmp));

            // data->image
            bmp = DealBmp.BmpFromData(pixel);
            Image reimg = DealBmp.ImageFromBmp(bmp);

            return reimg;
        }

        public static Image DoGrayScale(Image img)
        {
            var bmp = new Bitmap(img);

            // Edit
            Color[,] pixel = EditClass.DoEdit.GrayScale(DealBmp.DataFromBmp(bmp));

            // data->image
            bmp = DealBmp.BmpFromData(pixel);
            Image reimg = DealBmp.ImageFromBmp(bmp);

            return reimg;
        }

        public static Image DoNegaPosi(Image img)
        {
            var bmp = new Bitmap(img);

            // Edit
            Color[,] pixel = EditClass.DoEdit.NegaPosi(DealBmp.DataFromBmp(bmp));

            // data->image
            bmp = DealBmp.BmpFromData(pixel);
            Image reimg = DealBmp.ImageFromBmp(bmp);

            return reimg;
        }

        public static Image DoToneCurve_Cos(Image img)
        {
            var bmp = new Bitmap(img);

            // Edit
            Color[,] pixel = EditClass.DoEdit.ToneCurve(
                DealBmp.DataFromBmp(bmp),
                EditClass.ToneCurve.Cos);

            // data->image
            bmp = DealBmp.BmpFromData(pixel);
            Image reimg = DealBmp.ImageFromBmp(bmp);

            return reimg;
        }

        public static Image DoToneCurve_Sin(Image img)
        {
            var bmp = new Bitmap(img);

            // Edit
            Color[,] pixel = EditClass.DoEdit.ToneCurve(
                DealBmp.DataFromBmp(bmp),
                EditClass.ToneCurve.Sin);

            // data->image
            bmp = DealBmp.BmpFromData(pixel);
            Image reimg = DealBmp.ImageFromBmp(bmp);

            return reimg;
        }

        public static Image DoToneCurve_S_Shaped(Image img)
        {
            var bmp = new Bitmap(img);

            // Edit
            Color[,] pixel = EditClass.DoEdit.ToneCurve(
                DealBmp.DataFromBmp(bmp),
                EditClass.ToneCurve.S_Shaped);

            // data->image
            bmp = DealBmp.BmpFromData(pixel);
            Image reimg = DealBmp.ImageFromBmp(bmp);

            return reimg;
        }

        public static Image DoLinearFilter(Image img)
        {
            var bmp = new Bitmap(img);

            // Edit
            Color[,] pixel = EditClass.DoEdit.LinearFilter(
                DealBmp.DataFromBmp(bmp),
                EditClass.Kernel.OneNine);

            // data->image
            bmp = DealBmp.BmpFromData(pixel);
            Image reimg = DealBmp.ImageFromBmp(bmp);

            return reimg;
        }
    }
}
