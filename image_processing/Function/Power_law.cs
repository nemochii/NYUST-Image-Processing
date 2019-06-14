using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Image_processing
{
    class Power_law
    {
        public unsafe static void Function(byte* p, int[,,] rgb, int offset)
        {
            for (int y = 0; y < Global.img.Height; y++)
            {
                for (int x = 0; x < Global.img.Width; x++)
                {
                    p[2] = (byte)(Global.c * Math.Pow(rgb[x, y, 0], Global.pow));
                    p[1] = (byte)(Global.c * Math.Pow(rgb[x, y, 1], Global.pow));
                    p[0] = (byte)(Global.c * Math.Pow(rgb[x, y, 2], Global.pow));

                    p += 3;
                }
                p += offset;
            }
        }
    }
}
