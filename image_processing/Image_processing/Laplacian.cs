using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Image_processing
{
    class Laplacian
    {
        public unsafe static void Function(byte* p, int[,,] rgb, int offset)
        {
            int[] m = new int[9];

            switch (Global.chose_laplacian)
            {
                case "Matrix_1":
                    m = new int[9] { -1, -1, -1, -1, 8, -1, -1, -1, -1 };
                    break;
                case "Matrix_2":
                    m = new int[9] { 0, -1, 0, -1, 4, -1, 0, -1, 0 };
                    break;
                case "Matrix_3":
                    m = new int[9] { 1, -2, 1, -2, 4, -2, 1, -2, -1 };
                    break;
            }

            p += Global.img.Width * 3 + offset;

            for (int y = 1; y < Global.img.Height - 1; y++)
            {
                p += 3;
                for (int x = 1; x < Global.img.Width - 1; x++)
                {
                    int mr = 0, mg = 0, mb = 0;
                    int pos = 0;

                    for (int my = -1; my < 2; my++)
                    {
                        for (int mx = -1; mx < 2; mx++)
                        {
                            //int px = (x + mx) >= Global.img.Width ? x : x + mx;
                            //int py = (y + my) >= Global.img.Height ? y : y + my;

                            mr += rgb[x + mx, y + my, 0] * m[pos];
                            mg += rgb[x + mx, y + my, 1] * m[pos];
                            mb += rgb[x + mx, y + my, 2] * m[pos];

                            pos++;
                        }
                    }

                    int big(int i)
                    {
                        if (i > 255) { i = 255; }
                        else if (i < 0) { i = 0; }
                        return i;
                    }

                    p[2] = (byte)big(mr);
                    p[1] = (byte)big(mg);
                    p[0] = (byte)big(mb);

                    p += 3;
                }
                p += 3;
                p += offset;
            }
        }
    }
}
