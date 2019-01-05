using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Image_processing
{
    partial class Form1
    {
        private void width_Enter(object sender, EventArgs e)
        {
            if (width.Text == "Width")
            {
                width.Text = "";
                width.ForeColor = Color.Black;
            }
        }

        private void width_Leave(object sender, EventArgs e)
        {
            if (width.Text == "")
            {
                width.Text = "Width";
                width.ForeColor = Color.Silver;
            }
        }

        private void height_Enter(object sender, EventArgs e)
        {
            if (height.Text == "Height")
            {
                height.Text = "";
                height.ForeColor = Color.Black;
            }
        }

        private void height_Leave(object sender, EventArgs e)
        {
            if (height.Text == "")
            {
                height.Text = "Height";
                height.ForeColor = Color.Silver;
            }
        }

        private void img_width_Enter(object sender, EventArgs e)
        {
            if (img_width.Text == "Width")
            {
                img_width.Text = "";
                img_width.ForeColor = Color.Black;
            }
        }

        private void img_width_Leave(object sender, EventArgs e)
        {
            if (img_width.Text == "")
            {
                img_width.Text = "Width";
                img_width.ForeColor = Color.Silver;
            }
        }

        private void img_height_Enter(object sender, EventArgs e)
        {
            if (img_height.Text == "Height")
            {
                img_height.Text = "";
                img_height.ForeColor = Color.Black;
            }
        }

        private void img_height_Leave(object sender, EventArgs e)
        {
            if (img_height.Text == "")
            {
                img_height.Text = "Height";
                img_height.ForeColor = Color.Silver;
            }
        }

        private void k_number_Enter(object sender, EventArgs e)
        {
            if (k_number.Text == "K")
            {
                k_number.Text = "";
                k_number.ForeColor = Color.Black;
            }
        }

        private void k_number_Leave(object sender, EventArgs e)
        {
            if (k_number.Text == "")
            {
                k_number.Text = "K";
                k_number.ForeColor = Color.Silver;
            }
        }
    }
}
