using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Image_processing
{
    class Global
    {
        public static Bitmap img = new Bitmap(1, 1);
        public static string chose_laplacian, chose_fuzzy;
        public static int k;
    }
}
