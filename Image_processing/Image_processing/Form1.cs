using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_processing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static Bitmap img = new Bitmap(1, 1);
        static Bitmap img_origin = new Bitmap(1, 1);
        static int origin_width;
        static int origin_height;

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "open";
            open.InitialDirectory = @"D:\";
            open.Filter = "All files (*.jpg)|*.*|All files (*.*)|*.*|All files(*.bmp)|*.*";
            open.RestoreDirectory = true;

            if(open.ShowDialog() == DialogResult.OK)
            {
                img = new Bitmap(Image.FromFile(open.FileName));
                img = img.Clone(new Rectangle(0, 0, img.Width, img.Height), System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                img_origin = new Bitmap(img);

                origin_width = img.Width;
                origin_height = img.Height;

                origin_picture.Image = img_origin;
                processed_picture.Image = null;
                origin_pixel.Text = img_origin.Width + "x" + img_origin.Height;
                width.Text = img.Width.ToString();
                height.Text = img.Height.ToString();
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "save";
            save.InitialDirectory = @"D:\";
            save.Filter = "All files(*.bmp)|*.*|All files(*.*)|*.*";
            save.RestoreDirectory = true;

            if(save.ShowDialog() == DialogResult.OK)
            {
                img.Save(save.FileName + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp);
            }
        }
        
        private void origin_Click(object sender, EventArgs e)
        {
            try
            {
                img = img_origin;
                processed_picture.Image = img_origin;
                width.Text = img_origin.Width.ToString();
                height.Text = img_origin.Height.ToString();
                processing_pixel.Text = img_origin.Width + "x" + img_origin.Height;
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void resize_Click(object sender, EventArgs e)
        {
            try
            {
                int rewidth = Int32.Parse(width.Text);
                int reheight = Int32.Parse(height.Text);

                img = new Bitmap(img, new Size(rewidth, reheight));
                processed_picture.Image = img;
                processing_pixel.Text = rewidth + "x" + reheight;
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void show_detial_Click(object sender, EventArgs e)
        {
            String s = "";

            for (int x=0; x<img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    Color color = img.GetPixel(x, y);
                    s += string.Format("{0:D3}", color.R) + " ";
                }
                s += "\n";
            }
            detial.Text = s;
        }

        private void invert_Click(object sender, EventArgs e)
        {
            //Bitmap invert = new Bitmap(img.Width, img.Height);

            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    int red = 255 - img.GetPixel(x, y).R;
                    int green = 255 - img.GetPixel(x, y).G;
                    int blue = 255 - img.GetPixel(x, y).B;

                    img.SetPixel(x, y, Color.FromArgb(red, green, blue));
                }
            }

            processed_picture.Image = img;
        }

        private void grayscale_Click(object sender, EventArgs e)
        {
            //Bitmap grayscale = new Bitmap(img.Width, img.Height);

            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    int red = img.GetPixel(x, y).R;
                    int green = img.GetPixel(x, y).G;
                    int blue = img.GetPixel(x, y).B;
                    int gray = (int)(red * 0.299 + green * 0.587 + blue * 0.114);

                    img.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            }

            processed_picture.Image = img;
        }

        private void retro_Click(object sender, EventArgs e)
        {
            //Bitmap retro = new Bitmap(img.Width, img.Height);

            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    int red = img.GetPixel(x, y).R;
                    int green = img.GetPixel(x, y).G;
                    int blue = img.GetPixel(x, y).B;
                    
                    int nred = (int)(0.393 * red + 0.769 * green + 0.189 * blue);
                    int ngreen = (int)(0.349 * red + 0.686 * green + 0.168 * blue);
                    int nblue = (int)(0.272 * red + 0.534 * green + 0.131 * blue);

                    if (nred > 255) { nred = 255;  }
                    if (ngreen > 255) { ngreen = 255;  }

                    img.SetPixel(x, y, Color.FromArgb(nred, ngreen, nblue));
                }
            }

            processed_picture.Image = img;
        }

        private void medium_Click(object sender, EventArgs e)
        {
            int[] r = new int[9];
            int[] g = new int[9];
            int[] b = new int[9];

            for (int x = 1; x < img.Width-1; x++)
            {
                for (int y =1 ; y < img.Height-1; y++)
                {
                    r[0] = img.GetPixel(x - 1, y - 1).R;
                    r[1] = img.GetPixel(x - 1, y).R;
                    r[2] = img.GetPixel(x - 1, y + 1).R;
                    r[3] = img.GetPixel(x, y - 1).R;
                    r[4] = img.GetPixel(x, y).R;
                    r[5] = img.GetPixel(x, y + 1).R;
                    r[6] = img.GetPixel(x + 1, y - 1).R;
                    r[7] = img.GetPixel(x + 1, y).R;
                    r[8] = img.GetPixel(x + 1, y + 1).R;

                    g[0] = img.GetPixel(x - 1, y - 1).G;
                    g[1] = img.GetPixel(x - 1, y).G;
                    g[2] = img.GetPixel(x - 1, y + 1).G;
                    g[3] = img.GetPixel(x, y - 1).G;
                    g[4] = img.GetPixel(x, y).G;
                    g[5] = img.GetPixel(x, y + 1).G;
                    g[6] = img.GetPixel(x + 1, y - 1).G;
                    g[7] = img.GetPixel(x + 1, y).G;
                    g[8] = img.GetPixel(x + 1, y + 1).G;

                    b[0] = img.GetPixel(x - 1, y - 1).B;
                    b[1] = img.GetPixel(x - 1, y).B;
                    b[2] = img.GetPixel(x - 1, y + 1).B;
                    b[3] = img.GetPixel(x, y - 1).B;
                    b[4] = img.GetPixel(x, y).B;
                    b[5] = img.GetPixel(x, y + 1).B;
                    b[6] = img.GetPixel(x + 1, y - 1).B;
                    b[7] = img.GetPixel(x + 1, y).B;
                    b[8] = img.GetPixel(x + 1, y + 1).B;

                    Array.Sort(r);
                    Array.Sort(g);
                    Array.Sort(b);

                    int red = r[4];
                    int green = g[4];
                    int blue = b[4];

                    img.SetPixel(x, y, Color.FromArgb(red, green, blue));
                }
            }

            processed_picture.Image = img;
        }

        private void average_Click(object sender, EventArgs e)
        {
            for (int x = 1; x < img.Width - 1; x++)
            {
                for (int y = 1; y < img.Height - 1; y++)
                {
                    int mr = 0, mg = 0, mb = 0;

                    for (int mx = -1; mx < 2; mx++)
                    {
                        for (int my = -1; my < 2; my++)
                        {
                            Color color = img.GetPixel(x + mx, y + my);
                            int red = color.R;
                            int green = color.G;
                            int blue = color.B;

                            mr += red;
                            mg += green;
                            mb += blue;
                        }
                    }
                    img.SetPixel(x, y, Color.FromArgb(mr / 9, mg / 9, mb / 9));
                }
            }
            processed_picture.Image = img;
        }

        private void priority_Click(object sender, EventArgs e)
        {
            for(int x = 1; x < img.Width-1; x++)
            {
                for(int y = 1; y < img.Height-1; y++)
                {
                    int mr = 0, mg = 0, mb = 0;
                    int[] m = new int[9] { 1, 3, 1, 3, 9, 3, 1, 3, 1 };
                    int pos = 0;

                    for(int mx = -1; mx < 2; mx++)
                    {
                        for(int my = -1; my < 2; my++)
                        {
                            Color color = img.GetPixel(x + mx, y + my);
                            int red = color.R;
                            int green = color.G;
                            int blue = color.B;

                            mr += red * m[pos];
                            mg += green * m[pos];
                            mb += blue * m[pos];
                            pos++;
                        }
                    }
                    img.SetPixel(x, y, Color.FromArgb(mr / 25, mg / 25, mb / 25));
                }
            }
            processed_picture.Image = img;
        }

        private void Sobel_Click(object sender, EventArgs e)
        {
            Bitmap sobel = new Bitmap(img.Width, img.Height);

            for (int x = 1; x < img.Width - 1; x++)
            {
                for (int y = 1; y < img.Height - 1; y++)
                {
                    int vr = 0, vg = 0, vb = 0, hr = 0, hg = 0, hb = 0;
                    int[] hs = new int[9] { -1, -2, -1, 0, 0, 0, 1, 2, 1 };
                    int[] vs = new int[9] { -1, 0, 1, -2, 0, 2, -1, 0, 1 };
                    int pos = 0;

                    for (int mx = -1; mx < 2; mx++)
                    {
                        for (int my = -1; my < 2; my++)
                        {
                            Color color = img.GetPixel(x + mx, y + my);
                            int red = color.R;
                            int green = color.G;
                            int blue = color.B;

                            vr += red * vs[pos];
                            vg += green * vs[pos];
                            vb += blue * vs[pos];

                            hr += red * hs[pos];
                            hg += green * hs[pos];
                            hb += blue * hs[pos];

                            pos++;
                        }
                    }

                    int s_red = (int)Math.Sqrt(vr * vr + hr * hr) > 255 ? 255 : (int)Math.Sqrt(vr * vr + hr * hr);
                    int s_green = (int)Math.Sqrt(vg * vg + hg * hg) > 255 ? 255 : (int)Math.Sqrt(vg * vg + hg * hg);
                    int s_blue = (int)Math.Sqrt(vb * vb + hb * hb) > 255 ? 255 : (int)Math.Sqrt(vb * vb + hb * hb);

                    sobel.SetPixel(x, y, Color.FromArgb(s_red, s_green, s_blue));
                }
            }
            img = sobel;
            processed_picture.Image = img;
        }

        private int big(int i)
        {
            if (i > 255) { i = 255; }
            else if (i < 0) { i = 0; }
            return i;
        }

        private void laplacian_Click(object sender, EventArgs e)
        {
            Bitmap laplacian = new Bitmap(img.Width, img.Height);
            int[] m = new int[9];

            switch (comboBox_laplacian.Text)
            {
                case "1":
                    m = new int[9] { -1, -1, -1, -1, 8, -1, -1, -1, -1 };
                    break;
                case "2":
                    m = new int[9] { 0, -1, 0, -1, 4, -1, 0, -1, 0 };
                    break;
                case "3":
                    m = new int[9] { 1, -2, 1, -2, 4, -2, 1, -2, -1 };
                    break;
            }

            for (int x = 1; x < img.Width - 1; x++)
            {
                for (int y = 1; y < img.Height - 1; y++)
                {
                    int mr = 0, mg = 0, mb = 0;
                    int pos = 0;

                    for (int mx = -1; mx < 2; mx++)
                    {
                        for (int my = -1; my < 2; my++)
                        {
                            Color color = img.GetPixel(x + mx, y + my);
                            int red = color.R;
                            int green = color.G;
                            int blue = color.B;

                            mr += red * m[pos];
                            mg += green * m[pos];
                            mb += blue * m[pos];
                            pos++;
                        }
                    }

                    int rr = big(mr);
                    int gg = big(mg);
                    int bb = big(mb);

                    laplacian.SetPixel(x, y, Color.FromArgb(rr, gg, bb));
                }
            }
            img = laplacian;
            processed_picture.Image = img;
        }
    }
}
