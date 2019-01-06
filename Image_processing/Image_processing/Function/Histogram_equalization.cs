using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Image_processing
{
    class Histogram_equalization
    {
        public unsafe static void Function(byte* p, int[,,] rgb, int offset, int[,] countrgb) 
        {
            int[,] accrgb = new int[3, 256];
            int[,] Frgb = new int[3, 256];
            int allpixel = Global.img.Width * Global.img.Height;

            for (int t = 0; t < 3; t++)
            {
                for (int i = 0; i < 256; i++)
                {
                    //compute accumulation
                    if (i != 0) { accrgb[t, i] = accrgb[t, i - 1] + countrgb[t, i]; }
                    else { accrgb[t, 0] = countrgb[t, 0]; }

                    //compute F(x) and then equalization
                    Frgb[t, i] = (byte)(255 * accrgb[t, i] / allpixel);
                }
            }

            for(int y = 0; y < Global.img.Height; y++)
            {
                for(int x = 0; x < Global.img.Width; x++)
                {
                    p[2] = (byte)Frgb[0, p[2]];
                    p[1] = (byte)Frgb[1, p[1]];
                    p[0] = (byte)Frgb[2, p[0]];

                    p += 3;
                }
                p += offset;
            }
        }
    }
}
