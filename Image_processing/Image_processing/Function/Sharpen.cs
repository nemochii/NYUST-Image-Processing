using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace Image_processing
{
    class Sharpen
    {
        public unsafe static void Function(byte* p, int[,,] rgb, int offset, Bitmap origin_img, BitmapData processed_img)
        {
            BitmapData origin_bpdata = origin_img.LockBits(new Rectangle(0, 0, origin_img.Width, origin_img.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            IntPtr origin_p = origin_bpdata.Scan0;
            byte* p_origin = (byte*)origin_p;
            int origin_offset = origin_bpdata.Stride - origin_img.Width * 3;

            Global.chose_laplacian = "Matrix_1";
            Laplacian.Function(p, rgb, offset);
            IntPtr processed_p = processed_img.Scan0;
            p = (byte*)processed_p;

            for (int y = 0; y < Global.img.Height; y++)
            {
                for (int x = 0; x < Global.img.Width; x++)
                {
                    int red = p[2] + p_origin[2];
                    int green = p[1] + p_origin[1];
                    int blue = p[0] + p_origin[0];

                    p[2] = red > 255 ? (byte)255 : (byte)red;
                    p[1] = green > 255 ? (byte)255 : (byte)green;
                    p[0] = blue > 255 ? (byte)255 : (byte)blue;

                    p += 3;
                    p_origin += 3;
                }
                p += offset;
                p_origin += origin_offset;
            }
            origin_img.UnlockBits(origin_bpdata);
        }
    }
}
