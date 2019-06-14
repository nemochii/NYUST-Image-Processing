using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Image_processing
{
    class Sobel
    {
        public unsafe static void Function(byte* p, int[,,] rgb, int offset)
        {
            int[] hs = new int[9] { -1, -2, -1, 0, 0, 0, 1, 2, 1 };
            int[] vs = new int[9] { -1, 0, 1, -2, 0, 2, -1, 0, 1 };

            p += Global.img.Width * 3 + offset;

            for (int y = 1; y < Global.img.Height - 1; y++)
            {
                p += 3;
                for (int x = 1; x < Global.img.Width - 1; x++)
                {
                    int vr = 0, vg = 0, vb = 0, hr = 0, hg = 0, hb = 0;
                    int pos = 0;

                    for (int my = -1; my < 2; my++)
                    {
                        for (int mx = -1; mx < 2; mx++)
                        {
                            //int px = (x + mx) >= Global.img.Width ? x : x + mx;
                            //int py = (y + my) >= Global.img.Height ? y : y + my;

                            vr += rgb[x + mx, y + my, 0] * vs[pos];
                            vg += rgb[x + mx, y + my, 1] * vs[pos];
                            vb += rgb[x + mx, y + my, 2] * vs[pos];

                            hr += rgb[x + mx, y + my, 0] * hs[pos];
                            hg += rgb[x + mx, y + my, 1] * hs[pos];
                            hb += rgb[x + mx, y + my, 2] * hs[pos];

                            pos++;
                        }
                    }

                    p[2] = Math.Sqrt(vr * vr + hr * hr) > 255 ? (byte)255 : (byte)Math.Sqrt(vr * vr + hr * hr);
                    p[1] = Math.Sqrt(vg * vg + hg * hg) > 255 ? (byte)255 : (byte)Math.Sqrt(vg * vg + hg * hg);
                    p[0] = Math.Sqrt(vb * vb + hb * hb) > 255 ? (byte)255 : (byte)Math.Sqrt(vb * vb + hb * hb);

                    p += 3;
                }
                p += 3;
                p += offset;
            }
        }
    }
}
