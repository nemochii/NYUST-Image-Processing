using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Image_processing
{
    public class AAA
    {
        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "save";
            save.InitialDirectory = @"D:\";
            save.Filter = "All files(*.bmp)|*.*|All files(*.*)|*.*";
            save.RestoreDirectory = true;

            if (save.ShowDialog() == DialogResult.OK)
            {
                img.Save(save.FileName + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp);
            }
        }
    }
}