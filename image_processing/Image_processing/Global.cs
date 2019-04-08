using System.Drawing;
using System.Drawing.Imaging;

namespace Image_processing
{
    class Global
    {
        public static Bitmap img = new Bitmap(1, 1);
        public static Bitmap R_img = new Bitmap(1, 1);
        public static Bitmap G_img = new Bitmap(1, 1);
        public static Bitmap B_img = new Bitmap(1, 1);
        public static string chose_laplacian, chose_fuzzy;
        public static int k;
        public static BitmapData p_bpdata;

        public static void Zoom_exception() { img.UnlockBits(p_bpdata); }
    }
}
