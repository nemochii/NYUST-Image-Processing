using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Image_processing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox_laplacian.SelectedIndex = comboBox1_fuzzy.SelectedIndex = 0;
        }

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
                img_origin = new Bitmap(Image.FromFile(open.FileName));
                img_origin = img_origin.Clone(new Rectangle(0, 0, img_origin.Width, img_origin.Height), PixelFormat.Format24bppRgb);
                Global.img = new Bitmap(img_origin);

                origin_width = img_origin.Width;
                origin_height = img_origin.Height;

                origin_picture.Image = img_origin;
                processed_picture.Image = null;
                origin_pixel.Text = img_origin.Width + "x" + img_origin.Height;
                width.Text = Global.img.Width.ToString();
                height.Text = Global.img.Height.ToString();
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
                Global.img.Save(save.FileName + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp);
            }
        }
        
        private void origin_Click(object sender, EventArgs e)
        {
            try
            {
                Global.img = img_origin.Clone(new Rectangle(0, 0, img_origin.Width, img_origin.Height), PixelFormat.Format24bppRgb);
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

                Global.img = new Bitmap(Global.img, new Size(rewidth, reheight));
                processed_picture.Image = Global.img;
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

            for (int x = 0; x < Global.img.Width; x++)
            {
                for (int y = 0; y < Global.img.Height; y++)
                {
                    Color color = Global.img.GetPixel(x, y);
                    s += string.Format("{0:D3}", color.R) + " ";
                }
                s += "\n";
            }
            detial.Text = s;
        }

        public static Bitmap point_all(int function)
        {
            BitmapData bpdata = Global.img.LockBits(new Rectangle(0, 0, Global.img.Width, Global.img.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            IntPtr imgp = bpdata.Scan0;
            int[,,] rgb = new int[Global.img.Width, Global.img.Height, 4];

            int offset = bpdata.Stride - Global.img.Width * 3;

            unsafe
            {
                byte* p = (byte*)imgp;

                for (int y = 0; y < Global.img.Height; y++)
                {
                    for (int x = 0; x < Global.img.Width; x++)
                    {
                        rgb[x, y, 2] = p[0];
                        rgb[x, y, 1] = p[1];
                        rgb[x, y, 0] = p[2];
                        rgb[x, y, 3] = (byte)(p[2] * 0.299 + p[1] * 0.587 + p[0] * 0.114);

                        p += 3;
                    }
                    p += offset;
                }
                p = (byte*)imgp;

                switch (function)
                {
                    case 1:
                        Grayscale.Function(p, rgb, offset);
                        break;
                    case 2:
                        Invert.Function(p, rgb, offset);
                        break;
                    case 3:
                        Retro.Function(p, rgb, offset);
                        break;
                    case 4:
                        Sobel.Function(p, rgb, offset);
                        break;
                    case 5:
                        Laplacian.Function(p, rgb, offset);
                        break;
                    case 6:
                        Fuzzy.Function(p, rgb, offset);
                        break;
                }
            }
            Global.img.UnlockBits(bpdata);

            return Global.img;
        }

        private void grayscale_Click(object sender, EventArgs e)
        {
            processed_picture.Image = point_all(1);
            processing_pixel.Text = Global.img.Width + "x" + Global.img.Height;
        }

        private void invert_Click(object sender, EventArgs e)
        {
            processed_picture.Image = point_all(2);
            processing_pixel.Text = Global.img.Width + "x" + Global.img.Height;
        }

        private void retro_Click(object sender, EventArgs e)
        {
            processed_picture.Image = point_all(3);
            processing_pixel.Text = Global.img.Width + "x" + Global.img.Height;
        }

        private void sobel_Click(object sender, EventArgs e)
        {
            processed_picture.Image = point_all(4);
            processing_pixel.Text = Global.img.Width + "x" + Global.img.Height;
        }

        private void laplacian_Click(object sender, EventArgs e)
        {
            Global.chose_laplacian = comboBox_laplacian.Text;
            processed_picture.Image = point_all(5);
            processing_pixel.Text = Global.img.Width + "x" + Global.img.Height;
        }

        private void fuzzy_Click(object sender, EventArgs e)
        {
            Global.chose_fuzzy = comboBox1_fuzzy.Text;
            processed_picture.Image = point_all(6);
            processing_pixel.Text = Global.img.Width + "x" + Global.img.Height;
        }
    }
}
