using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Image_processing
{
    class Grayscale
    {
        public unsafe static void Function(byte *p, int[,,] rgb, int offset, byte * R_p, byte *G_p, byte *B_p, string what)
        {
            double average, max;
            for (int y = 0; y < Global.img.Height; y++)
            {
                for (int x = 0; x < Global.img.Width; x++)
                {
                    if (what == "Weight")
                    {
                        R_p[0] = R_p[1] = R_p[2] = (byte)(p[2] * 0.299);
                        G_p[0] = G_p[1] = G_p[2] = (byte)(p[1] * 0.587);
                        B_p[0] = B_p[1] = B_p[2] = (byte)(p[0] * 0.114);
                        p[0] = p[1] = p[2] = (byte)rgb[x, y, 3];
                    }
                    else if(what == "Average")
                    {
                        average = (p[2] + p[1] + p[0]) / 3;
                        R_p[0] = R_p[1] = R_p[2] = (byte)(p[2] / 3);
                        G_p[0] = G_p[1] = G_p[2] = (byte)(p[1] / 3);
                        B_p[0] = B_p[1] = B_p[2] = (byte)(p[0] / 3);
                        p[0] = p[1] = p[2] = (byte)average;
                    }
                    else
                    {
                        max = Math.Max(p[2], Math.Max(p[1], p[0]));
                        R_p[0] = R_p[1] = R_p[2] = p[2];
                        G_p[0] = G_p[1] = G_p[2] = p[1];
                        B_p[0] = B_p[1] = B_p[2] = p[0];
                        p[0] = p[1] = p[2] = (byte)max;
                    }

                    p += 3;
                    R_p += 3;
                    G_p += 3;
                    B_p += 3;
                }
                p += offset;
                R_p += offset;
                G_p += offset;
                B_p += offset;
            }
        }
    }
}
