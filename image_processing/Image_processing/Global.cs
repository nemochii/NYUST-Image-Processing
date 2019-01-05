using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace Image_processing
{
    class Global
    {
        public static Bitmap img = new Bitmap(1, 1);
        public static string chose_laplacian, chose_fuzzy, chose_morphology, chose_zoom;
        public static int k;
        public static BitmapData p_bpdata;

        public static void Zoom_exception() { img.UnlockBits(p_bpdata); }
    }
}
