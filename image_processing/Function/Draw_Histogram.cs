using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Image_processing
{
    class Draw_Histogram
    {
        public static void Function(Bitmap image, Bitmap[] originH, PictureBox[] picturearray)
        {
            BitmapData bpdata = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            IntPtr imgp = bpdata.Scan0;
            int[,,] rgb = new int[image.Width, image.Height, 3];

            int offset = bpdata.Stride - image.Width * 3;
            //int[] maxrgb = new int[3];
            int maxrgb = 0;
            int[,] countrgb = new int[3, 256];

            unsafe
            {
                byte* p = (byte*)imgp;

                for (int y = 0; y < image.Height; y++)
                {
                    for (int x = 0; x < image.Width; x++)
                    {
                        rgb[x, y, 2] = p[0];
                        countrgb[2, rgb[x, y, 2]]++;
                        rgb[x, y, 1] = p[1];
                        countrgb[1, rgb[x, y, 1]]++;
                        rgb[x, y, 0] = p[2];
                        countrgb[0, rgb[x, y, 0]]++;

                        for (int i = 0; i < 3; i++)
                            //maxrgb[i] = countrgb[i, rgb[x, y, i]] > maxrgb[i] ? countrgb[i, rgb[x, y, i]] : maxrgb[i];
                            maxrgb = countrgb[i, rgb[x, y, i]] > maxrgb ? countrgb[i, rgb[x, y, i]] : maxrgb;

                        p += 3;
                    }
                    p += offset;
                }
                p = (byte*)imgp;
            }
            image.UnlockBits(bpdata);

            Pen draw = new Pen(Color.Black);
            
            int x1, y1, x2, y2, y_height;
            for (int t = 0; t < 3; t++)
            {
                Graphics graphics = Graphics.FromImage(originH[t]);

                //equalization
                double ratex = (picturearray[t].Width * 1.0) / (255 * 1.0);
                double ratey = (picturearray[t].Height * 1.0) / (maxrgb * 1.0);
                for (int i = 0; i <= picturearray[t].Width; i++)
                {
                    x1 = i;
                    x2 = x1;
                    y1 = picturearray[t].Height;
                    y_height = Convert.ToInt32(countrgb[t, Convert.ToInt32(i / ratex)] * ratey);
                    y2 = picturearray[t].Height - y_height;
                    graphics.DrawLine(draw, x1, y1, x2, y2);
                }
                picturearray[t].Image = originH[t];
                picturearray[t].Refresh();
            }
        }
    }
}
