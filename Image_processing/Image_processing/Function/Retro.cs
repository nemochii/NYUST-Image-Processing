using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Image_processing
{
    class Retro
    {
        public unsafe static void Function(byte* p, int[,,] rgb, int offset)
        {
            for (int y = 0; y < Global.img.Height; y++)
            {
                for (int x = 0; x < Global.img.Width; x++)
                {
                    p[2] = (rgb[x, y, 0] * 0.393 + rgb[x, y, 1] * 0.769 + rgb[x, y, 2] * 0.189) > 255 ? (byte)255 : (byte)(rgb[x, y, 0] * 0.393 + rgb[x, y, 1] * 0.769 + rgb[x, y, 2] * 0.189);
                    p[1] = (rgb[x, y, 0] * 0.349 + rgb[x, y, 1] * 0.686 + rgb[x, y, 2] * 0.168) > 255 ? (byte)255 : (byte)(rgb[x, y, 0] * 0.349 + rgb[x, y, 1] * 0.686 + rgb[x, y, 2] * 0.168);
                    p[0] = (rgb[x, y, 0] * 0.272 + rgb[x, y, 1] * 0.534 + rgb[x, y, 2] * 0.131) > 255 ? (byte)255 : (byte)(rgb[x, y, 0] * 0.272 + rgb[x, y, 1] * 0.534 + rgb[x, y, 2] * 0.131);

                    p += 3;
                }
                p += offset;
            }
        }
    }
}
