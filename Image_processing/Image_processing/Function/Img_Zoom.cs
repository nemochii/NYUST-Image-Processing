using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace Image_processing
{
    class Img_zoom
    {
        public unsafe static void Function(byte *p, int or_stride, int rewidth, int reheight)
        {
            Rectangle rect = new Rectangle(0, 0, Global.img.Width, Global.img.Height);
            Rectangle newRect = new Rectangle(0, 0, rewidth, reheight);
            double xRatio = (double)rect.Width / newRect.Width;
            double yRatio = (double)rect.Height / newRect.Height;
            Bitmap dstmap = new Bitmap(rewidth, reheight);

            BitmapData bmpData2 = dstmap.LockBits(newRect, ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int offset2 = bmpData2.Stride - rewidth * 3;
            byte* p2 = (byte*)(bmpData2.Scan0);
            for (int i = 0; i < bmpData2.Height; i++)
            {
                double srcY = i * yRatio;
                int IntY = (int)srcY;
                double v = srcY - IntY;
                double v1 = 1.0 - v;

                for (int j = 0; j < bmpData2.Width; j++)
                {
                    double srcX = j * xRatio;
                    int IntX = (int)srcX;
                    double u = srcX - IntX;
                    double u1 = 1.0 - u;

                    int Index00 = IntY * or_stride + IntX * 3;
                    int Index10;
                    if (IntY < Global.img.Height - 1)
                    {
                        Index10 = Index00 + or_stride;
                    }
                    else
                    {
                        Index10 = Index00;
                    }
                    int Index01;
                    int Index11;
                    if (IntX < Global.img.Width - 1)
                    {
                        Index01 = Index00 + 3;
                        Index11 = Index10 + 3;
                    }
                    else
                    {
                        Index01 = Index00;
                        Index11 = Index10;
                    }
                    double temp0 = (v1 * (u * p[Index01] + u1 * p[Index00]) +
                                    v * (u * p[Index11] + u1 * p[Index10]));

                    double temp1 = (v1 * (u * p[Index01 + 1] + u1 * p[Index00 + 1]) +
                                    v * (u * p[Index11 + 1] + u1 * p[Index10 + 1]));

                    double temp2 = (v1 * (u * p[Index01 + 2] + u1 * p[Index00 + 2]) +
                                    v * (u * p[Index11 + 2] + u1 * p[Index10 + 2]));

                    p2[0] = (byte)temp0;
                    p2[1] = (byte)temp1;
                    p2[2] = (byte)temp2;
                    p2 += 3;
                }
                p2 += offset2;
            }
            dstmap.UnlockBits(bmpData2);
            Global.Zoom_exception();
            Global.img = dstmap.Clone(newRect, PixelFormat.Format24bppRgb);
        }
    }
}
