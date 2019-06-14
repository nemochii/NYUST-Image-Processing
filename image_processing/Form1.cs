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
            comboBox_laplacian.SelectedIndex = comboBox_fuzzy.SelectedIndex = comboBox_morphology.SelectedIndex = comboBox_zoom.SelectedIndex = comboBox_grayscale.SelectedIndex = 0;
        }

        Bitmap img_origin = new Bitmap(1, 1);
        int origin_width;
        int origin_height;
        Stack up = new Stack();
        
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
                Global.R_img = new Bitmap(img_origin);
                Global.G_img = new Bitmap(img_origin);
                Global.B_img = new Bitmap(img_origin);

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
                int rewidth = int.Parse(width.Text);
                int reheight = int.Parse(height.Text);

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

        private void morphology_Click(object sender, EventArgs e)
        {
            point_all(10);
        }

        private void Imgresize_Click(object sender, EventArgs e)
        {
            point_all(11);
        }

        private void Specified_size_Click(object sender, EventArgs e)
        {
            point_all(12);
        }

        private void log_Click(object sender, EventArgs e)
        {
            point_all(13);
        }

        private void power_law_Click(object sender, EventArgs e)
        {
            Global.pow = Convert.ToSingle(pow_number.Text);
            Global.c = Convert.ToInt32(c_number.Text);
            point_all(14);
        }
    }
}
