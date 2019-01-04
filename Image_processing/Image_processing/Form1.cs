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
using System.Collections;

namespace Image_processing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox_laplacian.SelectedIndex = comboBox_fuzzy.SelectedIndex = comboBox_morphology.SelectedIndex = 0;
        }

        Bitmap img_origin = new Bitmap(1, 1);
        int origin_width;
        int origin_height;
        Stack up = new Stack();

        public void start_histogtam(int who, Bitmap image)
        {
            Bitmap[] originH = new Bitmap[3];
            PictureBox[] picturearray = new PictureBox[3];

            switch (who)
            {
                case 1:
                    originH[0] = new Bitmap(origin_R.Width, origin_R.Height);
                    originH[1] = new Bitmap(origin_G.Width, origin_G.Height);
                    originH[2] = new Bitmap(origin_B.Width, origin_B.Height);
                    picturearray[0] = origin_R;
                    picturearray[1] = origin_G;
                    picturearray[2] = origin_B;
                    break;
                case 2:
                    originH[0] = new Bitmap(processed_R.Width, processed_R.Height);
                    originH[1] = new Bitmap(processed_G.Width, processed_G.Height);
                    originH[2] = new Bitmap(processed_B.Width, processed_B.Height);
                    picturearray[0] = processed_R;
                    picturearray[1] = processed_G;
                    picturearray[2] = processed_B;
                    break;
            }

            Draw_Histogram.Function(image, originH, picturearray);
        }

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

                start_histogtam(1, img_origin);

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
                start_histogtam(2, img_origin);
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
                start_histogtam(2, Global.img);
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
            int count = 0;
            String s = "";
            detial.Items.Clear();

            for (int x = 0; x < Global.img.Width; x++)
            {
                for (int y = 0; y < Global.img.Height; y++)
                {
                    Color color = Global.img.GetPixel(x, y);
                    s = ++count + ".  " + string.Format("{0:D3}", color.R);
                    detial.Items.Add(s);
                }
            }
            
        }

        private void previous_Click(object sender, EventArgs e)
        {
            if (up.Count == 0) { MessageBox.Show("Now is the first step!"); }
            else
            {
                Global.img = (Bitmap)up.Pop();
                start_histogtam(2, Global.img);
                processed_picture.Image = Global.img;
            }
        }

        public void point_all(int function)
        {
            up.Push(Global.img.Clone());
            BitmapData bpdata = Global.img.LockBits(new Rectangle(0, 0, Global.img.Width, Global.img.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            IntPtr imgp = bpdata.Scan0;
            int[,,] rgb = new int[Global.img.Width, Global.img.Height, 4];
            int[,] countrgb = new int[3, 256];

            int offset = bpdata.Stride - Global.img.Width * 3;

            unsafe
            {
                byte* p = (byte*)imgp;

                for (int y = 0; y < Global.img.Height; y++)
                {
                    for (int x = 0; x < Global.img.Width; x++)
                    {
                        rgb[x, y, 2] = p[0];
                        countrgb[2, rgb[x, y, 2]]++;
                        rgb[x, y, 1] = p[1];
                        countrgb[1, rgb[x, y, 1]]++;
                        rgb[x, y, 0] = p[2];
                        countrgb[0, rgb[x, y, 0]]++;
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
                    case 7:
                        Sharpen.Function(p, rgb, offset, img_origin, bpdata);
                        break;
                    case 8:
                        Histogram_equalization.Function(p, rgb, offset, countrgb);
                        break;
                    case 9:
                        K_means.Function(p, rgb, offset);
                        break;
                    case 10:
                        if (Global.chose_morphology == "Erosion")
                        {
                            Erosion.Function(p, rgb, offset);
                        }
                        else if (Global.chose_morphology == "Dilation")
                        {
                            Dilation.Function(p, rgb, offset);
                        }
                        else if (Global.chose_morphology == "Opening")
                        {
                            Erosion.Function(p, rgb, offset);
                            Dilation.Function(p, rgb, offset);
                        }
                        else
                        {
                            Dilation.Function(p, rgb, offset);
                            Erosion.Function(p, rgb, offset);
                        }
                        break;
                }
                p = (byte*)imgp;
            }
            Global.img.UnlockBits(bpdata);

            start_histogtam(2, Global.img);

            processing_pixel.Text = Global.img.Width + "x" + Global.img.Height;
            processed_picture.Image = Global.img;
        }

        private void grayscale_Click(object sender, EventArgs e)
        {
            point_all(1);
        }

        private void invert_Click(object sender, EventArgs e)
        {
            point_all(2);
        }

        private void retro_Click(object sender, EventArgs e)
        {
            point_all(3);
        }

        private void sobel_Click(object sender, EventArgs e)
        {
            point_all(4);
        }

        private void laplacian_Click(object sender, EventArgs e)
        {
            Global.chose_laplacian = comboBox_laplacian.Text;
            point_all(5);
        }

        private void fuzzy_Click(object sender, EventArgs e)
        {
            Global.chose_fuzzy = comboBox_fuzzy.Text;
            point_all(6);
        }

        private void sharpen_Click(object sender, EventArgs e)
        {
            point_all(7);
        }

        private void H_E_Click(object sender, EventArgs e)
        {
            point_all(8);
        }

        private void k_means_Click(object sender, EventArgs e)
        {
            Global.k = Convert.ToInt32(k_number.Text);
            if (Global.k < 2 || Global.k > 10) { MessageBox.Show("K can't less than 2 or greater than 10!"); }
            else { point_all(9); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Global.chose_morphology = comboBox_morphology.Text;
            point_all(10);
        }
    }
}
