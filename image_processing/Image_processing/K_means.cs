using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Image_processing
{
    class K_means
    {
        public unsafe static void Function(byte* p, int[,,] rgb, int offset)
        {
            //initialize center
            int[,] center = new int[Global.k, 2];
            Random ran = new Random(Guid.NewGuid().GetHashCode());

            for(int t = 0; t < Global.k; t++)
            {
                center[t, 0] = ran.Next(Global.img.Width);
                center[t, 1] = ran.Next(Global.img.Height);
            }

            //start
            int[,] center_rgb = new int[Global.k, 3];
            int[,] map = new int[Global.img.Width, Global.img.Height];

            for (int i = 0; i < 10; i++)
            {
                //get center RGB
                for (int t = 0; t < Global.k; t++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        center_rgb[t, c] = rgb[center[t, 0], center[t, 1], c];
                    }
                }

                //compute each pixel distance to each center and find the closest center
                double[] cen_dis = new double[Global.k];
                int[,] sum = new int[Global.k, 3];
                int[] quantity = new int[Global.k];

                for (int y = 0; y < Global.img.Height; y++)
                {
                    for (int x = 0; x < Global.img.Width; x++)
                    {
                        double min = 999999999;
                        for (int t = 0; t < Global.k; t++)
                        {
                            cen_dis[t] = Math.Sqrt(
                                                Math.Pow(rgb[x, y, 0] - center_rgb[t, 0], 2.0) +
                                                Math.Pow(rgb[x, y, 1] - center_rgb[t, 1], 2.0) +
                                                Math.Pow(rgb[x, y, 2] - center_rgb[t, 2], 2.0));

                            if (cen_dis[t] < min)
                            {
                                min = cen_dis[t];
                                map[x, y] = t;
                            }
                        }

                        for (int c = 0; c < 3; c++)
                        {
                            sum[map[x, y], c] += rgb[x, y, c];
                        }
                        quantity[map[x, y]]++;
                    }
                }

                //find new center RGB
                for (int t = 0; t < Global.k; t++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        center_rgb[t, c] = sum[t, c] / quantity[t];
                    }
                }
            }

            for (int y = 0; y < Global.img.Height; y++)
            {
                for (int x = 0; x < Global.img.Width; x++)
                {
                    p[2] = (byte)center_rgb[map[x, y], 0];
                    p[1] = (byte)center_rgb[map[x, y], 1];
                    p[0] = (byte)center_rgb[map[x, y], 2];

                    p += 3;
                }
                p += offset;
            }
        }
    }
}
