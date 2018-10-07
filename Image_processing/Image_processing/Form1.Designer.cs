namespace Image_processing
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Open = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.origin_picture = new System.Windows.Forms.PictureBox();
            this.processed_picture = new System.Windows.Forms.PictureBox();
            this.origin_pixel = new System.Windows.Forms.Label();
            this.processing_pixel = new System.Windows.Forms.Label();
            this.origin = new System.Windows.Forms.Button();
            this.width = new System.Windows.Forms.TextBox();
            this.height = new System.Windows.Forms.TextBox();
            this.resize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.origin_R = new System.Windows.Forms.PictureBox();
            this.origin_G = new System.Windows.Forms.PictureBox();
            this.origin_B = new System.Windows.Forms.PictureBox();
            this.processed_B = new System.Windows.Forms.PictureBox();
            this.processed_G = new System.Windows.Forms.PictureBox();
            this.processed_R = new System.Windows.Forms.PictureBox();
            this.grayscale = new System.Windows.Forms.Button();
            this.invert = new System.Windows.Forms.Button();
            this.detial = new System.Windows.Forms.Label();
            this.show_detial = new System.Windows.Forms.Button();
            this.retro = new System.Windows.Forms.Button();
            this.medium = new System.Windows.Forms.Button();
            this.average = new System.Windows.Forms.Button();
            this.priority = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.origin_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processed_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.origin_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.origin_G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.origin_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processed_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processed_G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processed_R)).BeginInit();
            this.SuspendLayout();
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(40, 32);
            this.Open.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(99, 40);
            this.Open.TabIndex = 0;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(145, 32);
            this.Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(99, 40);
            this.Save.TabIndex = 1;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // origin_picture
            // 
            this.origin_picture.Location = new System.Drawing.Point(40, 138);
            this.origin_picture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.origin_picture.Name = "origin_picture";
            this.origin_picture.Size = new System.Drawing.Size(463, 468);
            this.origin_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.origin_picture.TabIndex = 2;
            this.origin_picture.TabStop = false;
            // 
            // processed_picture
            // 
            this.processed_picture.Location = new System.Drawing.Point(552, 138);
            this.processed_picture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.processed_picture.Name = "processed_picture";
            this.processed_picture.Size = new System.Drawing.Size(463, 468);
            this.processed_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.processed_picture.TabIndex = 3;
            this.processed_picture.TabStop = false;
            // 
            // origin_pixel
            // 
            this.origin_pixel.Location = new System.Drawing.Point(403, 112);
            this.origin_pixel.Name = "origin_pixel";
            this.origin_pixel.Size = new System.Drawing.Size(100, 22);
            this.origin_pixel.TabIndex = 4;
            this.origin_pixel.Text = "0x0";
            this.origin_pixel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // processing_pixel
            // 
            this.processing_pixel.Location = new System.Drawing.Point(915, 112);
            this.processing_pixel.Name = "processing_pixel";
            this.processing_pixel.Size = new System.Drawing.Size(100, 22);
            this.processing_pixel.TabIndex = 5;
            this.processing_pixel.Text = "0x0";
            this.processing_pixel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // origin
            // 
            this.origin.Location = new System.Drawing.Point(251, 32);
            this.origin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.origin.Name = "origin";
            this.origin.Size = new System.Drawing.Size(99, 40);
            this.origin.TabIndex = 6;
            this.origin.Text = "Origin";
            this.origin.UseVisualStyleBackColor = true;
            this.origin.Click += new System.EventHandler(this.origin_Click);
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(1281, 32);
            this.width.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(111, 25);
            this.width.TabIndex = 7;
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(1281, 64);
            this.height.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(111, 25);
            this.height.TabIndex = 8;
            // 
            // resize
            // 
            this.resize.Location = new System.Drawing.Point(1408, 32);
            this.resize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resize.Name = "resize";
            this.resize.Size = new System.Drawing.Size(59, 56);
            this.resize.TabIndex = 9;
            this.resize.Text = "Resize";
            this.resize.UseVisualStyleBackColor = true;
            this.resize.Click += new System.EventHandler(this.resize_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(1175, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Width";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(1175, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Height";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // origin_R
            // 
            this.origin_R.Location = new System.Drawing.Point(40, 626);
            this.origin_R.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.origin_R.Name = "origin_R";
            this.origin_R.Size = new System.Drawing.Size(139, 111);
            this.origin_R.TabIndex = 12;
            this.origin_R.TabStop = false;
            // 
            // origin_G
            // 
            this.origin_G.Location = new System.Drawing.Point(203, 626);
            this.origin_G.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.origin_G.Name = "origin_G";
            this.origin_G.Size = new System.Drawing.Size(139, 111);
            this.origin_G.TabIndex = 13;
            this.origin_G.TabStop = false;
            // 
            // origin_B
            // 
            this.origin_B.Location = new System.Drawing.Point(365, 626);
            this.origin_B.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.origin_B.Name = "origin_B";
            this.origin_B.Size = new System.Drawing.Size(139, 111);
            this.origin_B.TabIndex = 14;
            this.origin_B.TabStop = false;
            // 
            // processed_B
            // 
            this.processed_B.Location = new System.Drawing.Point(877, 626);
            this.processed_B.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.processed_B.Name = "processed_B";
            this.processed_B.Size = new System.Drawing.Size(139, 111);
            this.processed_B.TabIndex = 17;
            this.processed_B.TabStop = false;
            // 
            // processed_G
            // 
            this.processed_G.Location = new System.Drawing.Point(715, 626);
            this.processed_G.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.processed_G.Name = "processed_G";
            this.processed_G.Size = new System.Drawing.Size(139, 111);
            this.processed_G.TabIndex = 16;
            this.processed_G.TabStop = false;
            // 
            // processed_R
            // 
            this.processed_R.Location = new System.Drawing.Point(552, 626);
            this.processed_R.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.processed_R.Name = "processed_R";
            this.processed_R.Size = new System.Drawing.Size(139, 111);
            this.processed_R.TabIndex = 15;
            this.processed_R.TabStop = false;
            // 
            // grayscale
            // 
            this.grayscale.Location = new System.Drawing.Point(355, 32);
            this.grayscale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grayscale.Name = "grayscale";
            this.grayscale.Size = new System.Drawing.Size(99, 40);
            this.grayscale.TabIndex = 18;
            this.grayscale.Text = "Grayscale";
            this.grayscale.UseVisualStyleBackColor = true;
            this.grayscale.Click += new System.EventHandler(this.grayscale_Click);
            // 
            // invert
            // 
            this.invert.Location = new System.Drawing.Point(459, 32);
            this.invert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.invert.Name = "invert";
            this.invert.Size = new System.Drawing.Size(99, 40);
            this.invert.TabIndex = 19;
            this.invert.Text = "Invert";
            this.invert.UseVisualStyleBackColor = true;
            this.invert.Click += new System.EventHandler(this.invert_Click);
            // 
            // detial
            // 
            this.detial.Location = new System.Drawing.Point(1056, 382);
            this.detial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.detial.Name = "detial";
            this.detial.Size = new System.Drawing.Size(461, 355);
            this.detial.TabIndex = 20;
            // 
            // show_detial
            // 
            this.show_detial.Location = new System.Drawing.Point(1059, 350);
            this.show_detial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.show_detial.Name = "show_detial";
            this.show_detial.Size = new System.Drawing.Size(100, 29);
            this.show_detial.TabIndex = 21;
            this.show_detial.Text = "show_detial";
            this.show_detial.UseVisualStyleBackColor = true;
            this.show_detial.Click += new System.EventHandler(this.show_detial_Click);
            // 
            // retro
            // 
            this.retro.Location = new System.Drawing.Point(667, 32);
            this.retro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.retro.Name = "retro";
            this.retro.Size = new System.Drawing.Size(99, 40);
            this.retro.TabIndex = 23;
            this.retro.Text = "Retro";
            this.retro.UseVisualStyleBackColor = true;
            this.retro.Click += new System.EventHandler(this.retro_Click);
            // 
            // medium
            // 
            this.medium.Location = new System.Drawing.Point(564, 14);
            this.medium.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.medium.Name = "medium";
            this.medium.Size = new System.Drawing.Size(99, 40);
            this.medium.TabIndex = 22;
            this.medium.Text = "中值模糊化";
            this.medium.UseVisualStyleBackColor = true;
            this.medium.Click += new System.EventHandler(this.medium_Click);
            // 
            // average
            // 
            this.average.Location = new System.Drawing.Point(564, 54);
            this.average.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.average.Name = "average";
            this.average.Size = new System.Drawing.Size(99, 40);
            this.average.TabIndex = 24;
            this.average.Text = "平均模糊化";
            this.average.UseVisualStyleBackColor = true;
            this.average.Click += new System.EventHandler(this.average_Click);
            // 
            // priority
            // 
            this.priority.Location = new System.Drawing.Point(564, 94);
            this.priority.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priority.Name = "priority";
            this.priority.Size = new System.Drawing.Size(99, 40);
            this.priority.TabIndex = 25;
            this.priority.Text = "權重模糊化";
            this.priority.UseVisualStyleBackColor = true;
            this.priority.Click += new System.EventHandler(this.priority_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 762);
            this.Controls.Add(this.priority);
            this.Controls.Add(this.average);
            this.Controls.Add(this.retro);
            this.Controls.Add(this.medium);
            this.Controls.Add(this.show_detial);
            this.Controls.Add(this.detial);
            this.Controls.Add(this.invert);
            this.Controls.Add(this.grayscale);
            this.Controls.Add(this.processed_B);
            this.Controls.Add(this.processed_G);
            this.Controls.Add(this.processed_R);
            this.Controls.Add(this.origin_B);
            this.Controls.Add(this.origin_G);
            this.Controls.Add(this.origin_R);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resize);
            this.Controls.Add(this.height);
            this.Controls.Add(this.width);
            this.Controls.Add(this.origin);
            this.Controls.Add(this.processing_pixel);
            this.Controls.Add(this.origin_pixel);
            this.Controls.Add(this.processed_picture);
            this.Controls.Add(this.origin_picture);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Open);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "UI";
            ((System.ComponentModel.ISupportInitialize)(this.origin_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processed_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.origin_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.origin_G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.origin_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processed_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processed_G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processed_R)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.PictureBox origin_picture;
        private System.Windows.Forms.PictureBox processed_picture;
        private System.Windows.Forms.Label origin_pixel;
        private System.Windows.Forms.Label processing_pixel;
        private System.Windows.Forms.Button origin;
        private System.Windows.Forms.TextBox width;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.Button resize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox origin_R;
        private System.Windows.Forms.PictureBox origin_G;
        private System.Windows.Forms.PictureBox origin_B;
        private System.Windows.Forms.PictureBox processed_B;
        private System.Windows.Forms.PictureBox processed_G;
        private System.Windows.Forms.PictureBox processed_R;
        private System.Windows.Forms.Button grayscale;
        private System.Windows.Forms.Button invert;
        private System.Windows.Forms.Label detial;
        private System.Windows.Forms.Button show_detial;
        private System.Windows.Forms.Button retro;
        private System.Windows.Forms.Button medium;
        private System.Windows.Forms.Button average;
        private System.Windows.Forms.Button priority;
    }
}

