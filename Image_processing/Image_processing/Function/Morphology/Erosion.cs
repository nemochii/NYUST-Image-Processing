using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Image_processing
{
    class Erosion
    {
        public unsafe static void Function(byte *p, int[,,] rgb, int offset)
        {
            int[] Erosion_Mask = new int[9]{0,1,0
                                           ,1,1,1
                                           ,0,1,0};
            int[] Erosion_Flag = new int[9] {0,0,0,
                                             0,0,0
                                            ,0,0,0};
            int[,] Erosion_result = new int[Global.img.Width, Global.img. Height];

            int Erosion_total()
            {
                int sum = 0;
                for (int i = 0; i < Erosion_Mask.Length; i++)
                {
                    sum += Erosion_Mask[i];
                }
                return sum;
            }

            int temp;
            int time;
            for (int y = 0; y < Global.img.Height; y++)
            {
                for (int x = 0; x < Global.img.Width; x++)
                {
                    Array.Clear(Erosion_Flag, 0, Erosion_Flag.Length);
                    if (y > 0 && x > 0 && y < Global.img.Height - 1 && x < Global.img.Width - 1)
                    {
                        temp = 0;
                        time = 0;
                        for (int j = y - 1; j < y + 2; j++)
                        {
                            for (int i = x - 1; i < x + 2; i++)
                            {
                                if (rgb[i, j, 3] * Erosion_Mask[temp] > 0)
                                {
                                    time++;
                                }
                                temp++;
                            }
                        }
                        if (time == Erosion_total())
                        {
                            Erosion_result[x, y] = rgb[x, y, 3];
                        }
                        else
                        {
                            Erosion_result[x, y] = 0;
                        }
                    }
                    else
                    {
                        Erosion_result[x, y] = rgb[x, y, 3];
                    }
                }
            }

            for (int y = 0; y < Global.img.Height; y++)
            {
                for (int x = 0; x < Global.img.Width; x++)
                {
                    p[2] = p[1] = p[0] = (byte)Erosion_result[x, y];

                    p += 3;
                }
                p += offset;
            }
        }
    }
}
