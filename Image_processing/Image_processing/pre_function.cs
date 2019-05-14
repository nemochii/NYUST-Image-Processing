using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;

namespace Image_processing
{
    partial class Form1
    {
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

        public void point_all(int function)
        {
            up.Push(Global.img.Clone());
            BitmapData bpdata = Global.img.LockBits(new Rectangle(0, 0, Global.img.Width, Global.img.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            IntPtr imgp = bpdata.Scan0;

            BitmapData R_bpdata = Global.R_img.LockBits(new Rectangle(0, 0, Global.img.Width, Global.img.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            IntPtr R_imgp = R_bpdata.Scan0;

            BitmapData G_bpdata = Global.G_img.LockBits(new Rectangle(0, 0, Global.img.Width, Global.img.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            IntPtr G_imgp = G_bpdata.Scan0;

            BitmapData B_bpdata = Global.B_img.LockBits(new Rectangle(0, 0, Global.img.Width, Global.img.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            IntPtr B_imgp = B_bpdata.Scan0;

            int[,,] rgb = new int[Global.img.Width, Global.img.Height, 4];
            int[,] countrgb = new int[3, 256];

            int offset = bpdata.Stride - Global.img.Width * 3;

            Global.p_bpdata = bpdata;
            bool jg = true;
            unsafe
            {
                byte* p = (byte*)imgp;
                byte* R_p = (byte*)R_imgp;
                byte* G_p = (byte*)G_imgp;
                byte* B_p = (byte*)B_imgp;

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
                R_p = (byte*)R_imgp;
                G_p = (byte*)G_imgp;
                B_p = (byte*)B_imgp;

                switch (function)
                {
                    case 1:
                        Grayscale.Function(p, rgb, offset, R_p, G_p, B_p, comboBox_grayscale.Text);
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
                        if (comboBox_morphology.Text == "Erosion")
                        {
                            Erosion.Function(p, rgb, offset);
                        }
                        else if (comboBox_morphology.Text == "Dilation")
                        {
                            Dilation.Function(p, rgb, offset);
                        }
                        else if (comboBox_morphology.Text == "Opening")
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
                    case 11:
                        jg = false;
                        if (comboBox_zoom.Text == "0.5x Zoom")
                        {
                            Img_zoom.Function(p, bpdata.Stride, Global.img.Width / 2, Global.img.Height / 2);
                        }
                        else if (comboBox_zoom.Text == "0.2x Zoom")
                        {
                            Img_zoom.Function(p, bpdata.Stride, Global.img.Width / 5, Global.img.Height / 5);
                        }
                        else if (comboBox_zoom.Text == "2x Zoom")
                        {
                            Img_zoom.Function(p, bpdata.Stride, Global.img.Width * 2, Global.img.Height * 2);
                        }
                        else
                        {
                            Img_zoom.Function(p, bpdata.Stride, Global.img.Width * 5, Global.img.Height * 5);
                        }
                        break;
                    case 12:
                        jg = false;
                        int rewidth = int.Parse(img_width.Text);
                        int reheight = int.Parse(img_height.Text);

                        Img_zoom.Function(p, bpdata.Stride, rewidth, reheight);
                        break;
                    case 13:
                        Log.Function(p, rgb, offset);
                        break;
                    case 14:
                        Power_law.Function(p, rgb, offset);
                        break;
                }
                p = (byte*)imgp;
            }
            if (jg)
            {
                Global.img.UnlockBits(bpdata);
                Global.R_img.UnlockBits(R_bpdata);
                Global.G_img.UnlockBits(G_bpdata);
                Global.B_img.UnlockBits(B_bpdata);
            }

            start_histogtam(2, Global.img);

            processing_pixel.Text = Global.img.Width + "x" + Global.img.Height;
            processed_picture.Image = Global.img;
            R_gray.Image = Global.R_img;
            G_gray.Image = Global.G_img;
            B_gray.Image = Global.B_img;
        }
    }
}
