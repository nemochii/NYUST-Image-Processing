﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Image_processing
{
    class Invert
    {
        public unsafe static void Function(byte* p, int[,,] rgb, int offset)
        {
            for (int y = 0; y < Global.img.Height; y++)
            {
                for (int x = 0; x < Global.img.Width; x++)
                {
                    p[2] = (byte)(255 - rgb[x, y, 0]);
                    p[1] = (byte)(255 - rgb[x, y, 1]);
                    p[0] = (byte)(255 - rgb[x, y, 2]);

                    p += 3;
                }
                p += offset;
            }
        }
    }
}
