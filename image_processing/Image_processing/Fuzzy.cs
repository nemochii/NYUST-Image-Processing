using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Image_processing
{
    class Fuzzy
    {
        public unsafe static void Function(byte* p, int[,,] rgb, int offset)
        {
            p += Global.img.Width * 3 + offset;

            if (Global.chose_fuzzy == "Medium")
            {
                int[] r = new int[9];
                int[] g = new int[9];
                int[] b = new int[9];

                for (int y = 1; y < Global.img.Height - 1; y++)
                {
                    p += 3;
                    for (int x = 1; x < Global.img.Width - 1; x++)
                    {
                        int pos = 0;

                        for (int i = -1; i < 2; i++)
                        {
                            for (int t = -1; t < 2; t++)
                            {
                                //int px = (x + t) >= Global.img.Width ? x : x + i;
                                //int py = (y + i) >= Global.img.Height ? y : y + t;

                                r[pos] = rgb[x + t, y + i, 0];
                                g[pos] = rgb[x + t, y + i, 1];
                                b[pos] = rgb[x + t, y + i, 2];

                                pos++;
                            }
                        }

                        Array.Sort(r);
                        Array.Sort(g);
                        Array.Sort(b);

                        p[2] = (byte)r[4];
                        p[1] = (byte)g[4];
                        p[0] = (byte)b[4];
                        p += 3;
                    }
                    p += 3;
                    p += offset;
                }
            }

            if (Global.chose_fuzzy == "Average")
            {
                for (int y = 1; y < Global.img.Height - 1; y++)
                {
                    p += 3;
                    for (int x = 1; x < Global.img.Width - 1; x++)
                    {
                        int mr = 0, mg = 0, mb = 0;

                        for (int my = -1; my < 2; my++)
                        {
                            for (int mx = -1; mx < 2; mx++)
                            {
                                //int px = (x + mx) >= Global.img.Width ? x : x + mx;
                                //int py = (y + my) >= Global.img.Height ? y : y + my;

                                mr += rgb[x + mx, y + my, 0];
                                mg += rgb[x + mx, y + my, 1];
                                mb += rgb[x + mx, y + my, 2];
                            }
                        }
                        p[2] = (byte)(mr / 9);
                        p[1] = (byte)(mg / 9);
                        p[0] = (byte)(mb / 9);
                        p += 3;
                    }
                    p += 3;
                    p += offset;
                }
            }

            if (Global.chose_fuzzy == "Priority")
            {
                int[] m = new int[9] { 1, 3, 1, 3, 9, 3, 1, 3, 1 };

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
                        p[2] = (byte)(mr / 25);
                        p[1] = (byte)(mg / 25);
                        p[0] = (byte)(mb / 25);
                        p += 3;
                    }
                    p += 3;
                    p += offset;
                }
            }

            p += Global.img.Width * 3 + offset;
        }
    }
}
