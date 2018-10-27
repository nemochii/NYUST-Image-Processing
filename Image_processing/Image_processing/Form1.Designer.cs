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
            this.sobel = new System.Windows.Forms.Button();
            this.laplacian = new System.Windows.Forms.Button();
            this.comboBox_laplacian = new System.Windows.Forms.ComboBox();
            this.fuzzy = new System.Windows.Forms.Button();
            this.comboBox1_fuzzy = new System.Windows.Forms.ComboBox();
            this.sharpen = new System.Windows.Forms.Button();
            this.H_E = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.k_means = new System.Windows.Forms.Button();
            this.previous = new System.Windows.Forms.Button();
            this.k_number = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.origin_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processed_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.origin_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.origin_G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.origin_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processed_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processed_G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processed_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(40, 54);
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
            this.Save.Location = new System.Drawing.Point(145, 54);
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
            this.origin.Location = new System.Drawing.Point(251, 54);
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
            this.origin_R.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.origin_R.Location = new System.Drawing.Point(40, 626);
            this.origin_R.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.origin_R.Name = "origin_R";
            this.origin_R.Size = new System.Drawing.Size(139, 111);
            this.origin_R.TabIndex = 12;
            this.origin_R.TabStop = false;
            // 
            // origin_G
            // 
            this.origin_G.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.origin_G.Location = new System.Drawing.Point(203, 626);
            this.origin_G.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.origin_G.Name = "origin_G";
            this.origin_G.Size = new System.Drawing.Size(139, 111);
            this.origin_G.TabIndex = 13;
            this.origin_G.TabStop = false;
            // 
            // origin_B
            // 
            this.origin_B.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.origin_B.Location = new System.Drawing.Point(365, 626);
            this.origin_B.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.origin_B.Name = "origin_B";
            this.origin_B.Size = new System.Drawing.Size(139, 111);
            this.origin_B.TabIndex = 14;
            this.origin_B.TabStop = false;
            // 
            // processed_B
            // 
            this.processed_B.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.processed_B.Location = new System.Drawing.Point(877, 626);
            this.processed_B.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.processed_B.Name = "processed_B";
            this.processed_B.Size = new System.Drawing.Size(139, 111);
            this.processed_B.TabIndex = 17;
            this.processed_B.TabStop = false;
            // 
            // processed_G
            // 
            this.processed_G.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.processed_G.Location = new System.Drawing.Point(715, 626);
            this.processed_G.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.processed_G.Name = "processed_G";
            this.processed_G.Size = new System.Drawing.Size(139, 111);
            this.processed_G.TabIndex = 16;
            this.processed_G.TabStop = false;
            // 
            // processed_R
            // 
            this.processed_R.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.processed_R.Location = new System.Drawing.Point(552, 626);
            this.processed_R.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.processed_R.Name = "processed_R";
            this.processed_R.Size = new System.Drawing.Size(139, 111);
            this.processed_R.TabIndex = 15;
            this.processed_R.TabStop = false;
            // 
            // grayscale
            // 
            this.grayscale.Location = new System.Drawing.Point(355, 54);
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
            this.invert.Location = new System.Drawing.Point(459, 54);
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
            this.show_detial.Location = new System.Drawing.Point(1059, 348);
            this.show_detial.Margin = new System.Windows.Forms.Padding(5);
            this.show_detial.Name = "show_detial";
            this.show_detial.Size = new System.Drawing.Size(100, 29);
            this.show_detial.TabIndex = 21;
            this.show_detial.Text = "show_detial";
            this.show_detial.UseVisualStyleBackColor = true;
            this.show_detial.Click += new System.EventHandler(this.show_detial_Click);
            // 
            // retro
            // 
            this.retro.Location = new System.Drawing.Point(564, 54);
            this.retro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.retro.Name = "retro";
            this.retro.Size = new System.Drawing.Size(99, 40);
            this.retro.TabIndex = 23;
            this.retro.Text = "Retro";
            this.retro.UseVisualStyleBackColor = true;
            this.retro.Click += new System.EventHandler(this.retro_Click);
            // 
            // sobel
            // 
            this.sobel.Location = new System.Drawing.Point(668, 55);
            this.sobel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sobel.Name = "sobel";
            this.sobel.Size = new System.Drawing.Size(99, 40);
            this.sobel.TabIndex = 26;
            this.sobel.Text = "Sobel";
            this.sobel.UseVisualStyleBackColor = true;
            this.sobel.Click += new System.EventHandler(this.sobel_Click);
            // 
            // laplacian
            // 
            this.laplacian.Location = new System.Drawing.Point(1368, 136);
            this.laplacian.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laplacian.Name = "laplacian";
            this.laplacian.Size = new System.Drawing.Size(99, 25);
            this.laplacian.TabIndex = 27;
            this.laplacian.Text = "Laplacian";
            this.laplacian.UseVisualStyleBackColor = true;
            this.laplacian.Click += new System.EventHandler(this.laplacian_Click);
            // 
            // comboBox_laplacian
            // 
            this.comboBox_laplacian.AutoCompleteCustomSource.AddRange(new string[] {
            "Matrix_1",
            "Matrix_2",
            "Matrix_3"});
            this.comboBox_laplacian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_laplacian.FormattingEnabled = true;
            this.comboBox_laplacian.Items.AddRange(new object[] {
            "Matrix_1",
            "Matrix_2",
            "Matrix_3"});
            this.comboBox_laplacian.Location = new System.Drawing.Point(1233, 138);
            this.comboBox_laplacian.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_laplacian.Name = "comboBox_laplacian";
            this.comboBox_laplacian.Size = new System.Drawing.Size(111, 23);
            this.comboBox_laplacian.TabIndex = 28;
            // 
            // fuzzy
            // 
            this.fuzzy.Location = new System.Drawing.Point(1368, 182);
            this.fuzzy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fuzzy.Name = "fuzzy";
            this.fuzzy.Size = new System.Drawing.Size(99, 25);
            this.fuzzy.TabIndex = 29;
            this.fuzzy.Text = "Fuzzy";
            this.fuzzy.UseVisualStyleBackColor = true;
            this.fuzzy.Click += new System.EventHandler(this.fuzzy_Click);
            // 
            // comboBox1_fuzzy
            // 
            this.comboBox1_fuzzy.AutoCompleteCustomSource.AddRange(new string[] {
            "Medium",
            "Average",
            "Priority"});
            this.comboBox1_fuzzy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1_fuzzy.FormattingEnabled = true;
            this.comboBox1_fuzzy.Items.AddRange(new object[] {
            "Medium",
            "Average",
            "Priority"});
            this.comboBox1_fuzzy.Location = new System.Drawing.Point(1233, 185);
            this.comboBox1_fuzzy.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1_fuzzy.Name = "comboBox1_fuzzy";
            this.comboBox1_fuzzy.Size = new System.Drawing.Size(111, 23);
            this.comboBox1_fuzzy.TabIndex = 30;
            // 
            // sharpen
            // 
            this.sharpen.Location = new System.Drawing.Point(772, 55);
            this.sharpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sharpen.Name = "sharpen";
            this.sharpen.Size = new System.Drawing.Size(99, 40);
            this.sharpen.TabIndex = 31;
            this.sharpen.Text = "Sharpen";
            this.sharpen.UseVisualStyleBackColor = true;
            this.sharpen.Click += new System.EventHandler(this.sharpen_Click);
            // 
            // H_E
            // 
            this.H_E.Location = new System.Drawing.Point(876, 54);
            this.H_E.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.H_E.Name = "H_E";
            this.H_E.Size = new System.Drawing.Size(99, 40);
            this.H_E.TabIndex = 32;
            this.H_E.Text = "H_E";
            this.H_E.UseVisualStyleBackColor = true;
            this.H_E.Click += new System.EventHandler(this.H_E_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Location = new System.Drawing.Point(40, 742);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 15);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Red;
            this.pictureBox2.Location = new System.Drawing.Point(552, 742);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(139, 15);
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Green;
            this.pictureBox3.Location = new System.Drawing.Point(203, 742);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(139, 15);
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Green;
            this.pictureBox4.Location = new System.Drawing.Point(715, 742);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(139, 15);
            this.pictureBox4.TabIndex = 36;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Blue;
            this.pictureBox5.Location = new System.Drawing.Point(365, 742);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(139, 15);
            this.pictureBox5.TabIndex = 37;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Blue;
            this.pictureBox6.Location = new System.Drawing.Point(877, 742);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(139, 15);
            this.pictureBox6.TabIndex = 38;
            this.pictureBox6.TabStop = false;
            // 
            // k_means
            // 
            this.k_means.Location = new System.Drawing.Point(1368, 230);
            this.k_means.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.k_means.Name = "k_means";
            this.k_means.Size = new System.Drawing.Size(99, 27);
            this.k_means.TabIndex = 39;
            this.k_means.Text = "K_means";
            this.k_means.UseVisualStyleBackColor = true;
            this.k_means.Click += new System.EventHandler(this.k_means_Click);
            // 
            // previous
            // 
            this.previous.Location = new System.Drawing.Point(1473, 30);
            this.previous.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(71, 56);
            this.previous.TabIndex = 40;
            this.previous.Text = "Previous";
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // k_number
            // 
            this.k_number.Location = new System.Drawing.Point(1233, 232);
            this.k_number.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.k_number.Name = "k_number";
            this.k_number.Size = new System.Drawing.Size(111, 25);
            this.k_number.TabIndex = 41;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1554, 774);
            this.Controls.Add(this.k_number);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.k_means);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.H_E);
            this.Controls.Add(this.sharpen);
            this.Controls.Add(this.comboBox1_fuzzy);
            this.Controls.Add(this.fuzzy);
            this.Controls.Add(this.comboBox_laplacian);
            this.Controls.Add(this.laplacian);
            this.Controls.Add(this.sobel);
            this.Controls.Add(this.retro);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
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
        private System.Windows.Forms.Button sobel;
        private System.Windows.Forms.Button laplacian;
        private System.Windows.Forms.ComboBox comboBox_laplacian;
        private System.Windows.Forms.Button fuzzy;
        private System.Windows.Forms.ComboBox comboBox1_fuzzy;
        private System.Windows.Forms.Button sharpen;
        private System.Windows.Forms.Button H_E;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button k_means;
        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.TextBox k_number;
    }
}

