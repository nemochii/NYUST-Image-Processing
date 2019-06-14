using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Image_processing
{
    class Dilation
    {
        public unsafe static void Function(byte *p, int[,,] rgb, int offset)
        {
            int[] Dilation_Mask = new int[9]{0,1,0
                                            ,1,1,1
                                            ,0,1,0};
            int[] Dilation_Flag = new int[9] {0,0,0,
                                              0,0,0
                                             ,0,0,0};
            int [,]Dilation_result = new int[Global.img.Width, Global.img.Height];

            int temp = 0;
            int time = 0;
            for (int y = 0; y < Global.img.Height; y++)
            {
                for (int x = 0; x < Global.img.Width; x++)
                {
                    Array.Clear(Dilation_Flag, 0, Dilation_Flag.Length);
                    temp = 0;
                    time = 0;
                    if (y > 0 && x > 0 && y < Global.img.Height - 1 && x < Global.img.Width - 1)
                    {
                        for (int j = y - 1; j < y + 2; j++)
                        {
                            for (int i = x - 1; i < x + 2; i++)
                            {
                                if (rgb[i, j, 3] * Dilation_Mask[temp] > 0)
                                {
                                    time++;
                                }
                                temp++;
                            }
                        }

                        if (time > 0)
                        {
                            Dilation_result[x, y] = 255;
                        }
                        else
                        {
                            Dilation_result[x, y] = rgb[x, y, 3];
                        }
                    }
                    else
                    {
                        Dilation_result[x, y] = rgb[x, y, 3];
                    }
                }
            }

            for (int y = 0; y < Global.img.Height; y++)
            {
                for (int x = 0; x < Global.img.Width; x++)
                {
                    p[2] = p[1] = p[0] = (byte)Dilation_result[x, y];

                    p += 3;
                }
                p += offset;
            }
        }
    }
}
