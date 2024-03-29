﻿namespace Image_processing
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
            this.origin_R = new System.Windows.Forms.PictureBox();
            this.origin_G = new System.Windows.Forms.PictureBox();
            this.origin_B = new System.Windows.Forms.PictureBox();
            this.processed_B = new System.Windows.Forms.PictureBox();
            this.processed_G = new System.Windows.Forms.PictureBox();
            this.processed_R = new System.Windows.Forms.PictureBox();
            this.grayscale = new System.Windows.Forms.Button();
            this.invert = new System.Windows.Forms.Button();
            this.show_detial = new System.Windows.Forms.Button();
            this.retro = new System.Windows.Forms.Button();
            this.sobel = new System.Windows.Forms.Button();
            this.laplacian = new System.Windows.Forms.Button();
            this.comboBox_laplacian = new System.Windows.Forms.ComboBox();
            this.fuzzy = new System.Windows.Forms.Button();
            this.comboBox_fuzzy = new System.Windows.Forms.ComboBox();
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
            this.morphology = new System.Windows.Forms.Button();
            this.comboBox_morphology = new System.Windows.Forms.ComboBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.detial = new System.Windows.Forms.ListBox();
            this.Specified_size = new System.Windows.Forms.Button();
            this.comboBox_zoom = new System.Windows.Forms.ComboBox();
            this.Imgresize = new System.Windows.Forms.Button();
            this.img_width = new System.Windows.Forms.TextBox();
            this.img_height = new System.Windows.Forms.TextBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.R_gray = new System.Windows.Forms.PictureBox();
            this.G_gray = new System.Windows.Forms.PictureBox();
            this.B_gray = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_grayscale = new System.Windows.Forms.ComboBox();
            this.log = new System.Windows.Forms.Button();
            this.power_law = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pow_number = new System.Windows.Forms.TextBox();
            this.c_number = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R_gray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.G_gray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_gray)).BeginInit();
            this.SuspendLayout();
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(65, 24);
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
            this.Save.Location = new System.Drawing.Point(169, 22);
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
            this.origin_picture.Location = new System.Drawing.Point(40, 147);
            this.origin_picture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.origin_picture.Name = "origin_picture";
            this.origin_picture.Size = new System.Drawing.Size(463, 468);
            this.origin_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.origin_picture.TabIndex = 2;
            this.origin_picture.TabStop = false;
            // 
            // processed_picture
            // 
            this.processed_picture.Location = new System.Drawing.Point(533, 147);
            this.processed_picture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.processed_picture.Name = "processed_picture";
            this.processed_picture.Size = new System.Drawing.Size(463, 468);
            this.processed_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.processed_picture.TabIndex = 3;
            this.processed_picture.TabStop = false;
            // 
            // origin_pixel
            // 
            this.origin_pixel.Location = new System.Drawing.Point(403, 124);
            this.origin_pixel.Name = "origin_pixel";
            this.origin_pixel.Size = new System.Drawing.Size(100, 21);
            this.origin_pixel.TabIndex = 4;
            this.origin_pixel.Text = "0x0";
            this.origin_pixel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // processing_pixel
            // 
            this.processing_pixel.Location = new System.Drawing.Point(897, 124);
            this.processing_pixel.Name = "processing_pixel";
            this.processing_pixel.Size = new System.Drawing.Size(100, 21);
            this.processing_pixel.TabIndex = 5;
            this.processing_pixel.Text = "0x0";
            this.processing_pixel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // origin
            // 
            this.origin.Location = new System.Drawing.Point(65, 68);
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
            this.width.ForeColor = System.Drawing.Color.Silver;
            this.width.Location = new System.Drawing.Point(1061, 33);
            this.width.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(111, 25);
            this.width.TabIndex = 7;
            this.width.Text = "Width";
            this.width.Enter += new System.EventHandler(this.width_Enter);
            this.width.Leave += new System.EventHandler(this.width_Leave);
            // 
            // height
            // 
            this.height.ForeColor = System.Drawing.Color.Silver;
            this.height.Location = new System.Drawing.Point(1061, 65);
            this.height.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(111, 25);
            this.height.TabIndex = 8;
            this.height.Text = "Height";
            this.height.Enter += new System.EventHandler(this.height_Enter);
            this.height.Leave += new System.EventHandler(this.height_Leave);
            // 
            // resize
            // 
            this.resize.Location = new System.Drawing.Point(1188, 33);
            this.resize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resize.Name = "resize";
            this.resize.Size = new System.Drawing.Size(59, 56);
            this.resize.TabIndex = 9;
            this.resize.Text = "Resize";
            this.resize.UseVisualStyleBackColor = true;
            this.resize.Click += new System.EventHandler(this.resize_Click);
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
            this.processed_B.Location = new System.Drawing.Point(858, 626);
            this.processed_B.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.processed_B.Name = "processed_B";
            this.processed_B.Size = new System.Drawing.Size(139, 111);
            this.processed_B.TabIndex = 17;
            this.processed_B.TabStop = false;
            // 
            // processed_G
            // 
            this.processed_G.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.processed_G.Location = new System.Drawing.Point(696, 626);
            this.processed_G.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.processed_G.Name = "processed_G";
            this.processed_G.Size = new System.Drawing.Size(139, 111);
            this.processed_G.TabIndex = 16;
            this.processed_G.TabStop = false;
            // 
            // processed_R
            // 
            this.processed_R.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.processed_R.Location = new System.Drawing.Point(533, 626);
            this.processed_R.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.processed_R.Name = "processed_R";
            this.processed_R.Size = new System.Drawing.Size(139, 111);
            this.processed_R.TabIndex = 15;
            this.processed_R.TabStop = false;
            // 
            // grayscale
            // 
            this.grayscale.Location = new System.Drawing.Point(566, 24);
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
            this.invert.Location = new System.Drawing.Point(566, 69);
            this.invert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.invert.Name = "invert";
            this.invert.Size = new System.Drawing.Size(99, 40);
            this.invert.TabIndex = 19;
            this.invert.Text = "Invert";
            this.invert.UseVisualStyleBackColor = true;
            this.invert.Click += new System.EventHandler(this.invert_Click);
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
            this.retro.Location = new System.Drawing.Point(670, 24);
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
            this.sobel.Location = new System.Drawing.Point(670, 69);
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
            this.laplacian.Location = new System.Drawing.Point(1397, 167);
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
            this.comboBox_laplacian.Location = new System.Drawing.Point(1264, 169);
            this.comboBox_laplacian.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_laplacian.Name = "comboBox_laplacian";
            this.comboBox_laplacian.Size = new System.Drawing.Size(111, 23);
            this.comboBox_laplacian.TabIndex = 28;
            // 
            // fuzzy
            // 
            this.fuzzy.Location = new System.Drawing.Point(1397, 214);
            this.fuzzy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fuzzy.Name = "fuzzy";
            this.fuzzy.Size = new System.Drawing.Size(99, 25);
            this.fuzzy.TabIndex = 29;
            this.fuzzy.Text = "Fuzzy";
            this.fuzzy.UseVisualStyleBackColor = true;
            this.fuzzy.Click += new System.EventHandler(this.fuzzy_Click);
            // 
            // comboBox_fuzzy
            // 
            this.comboBox_fuzzy.AutoCompleteCustomSource.AddRange(new string[] {
            "Medium",
            "Average",
            "Priority"});
            this.comboBox_fuzzy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_fuzzy.FormattingEnabled = true;
            this.comboBox_fuzzy.Items.AddRange(new object[] {
            "Medium",
            "Average",
            "Priority"});
            this.comboBox_fuzzy.Location = new System.Drawing.Point(1264, 216);
            this.comboBox_fuzzy.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_fuzzy.Name = "comboBox_fuzzy";
            this.comboBox_fuzzy.Size = new System.Drawing.Size(111, 23);
            this.comboBox_fuzzy.TabIndex = 30;
            // 
            // sharpen
            // 
            this.sharpen.Location = new System.Drawing.Point(774, 22);
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
            this.H_E.Location = new System.Drawing.Point(774, 68);
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
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 15);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Red;
            this.pictureBox2.Location = new System.Drawing.Point(533, 742);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(139, 15);
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Green;
            this.pictureBox3.Location = new System.Drawing.Point(203, 742);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(139, 15);
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Green;
            this.pictureBox4.Location = new System.Drawing.Point(696, 742);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(139, 15);
            this.pictureBox4.TabIndex = 36;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Blue;
            this.pictureBox5.Location = new System.Drawing.Point(365, 742);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(139, 15);
            this.pictureBox5.TabIndex = 37;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Blue;
            this.pictureBox6.Location = new System.Drawing.Point(858, 742);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(139, 15);
            this.pictureBox6.TabIndex = 38;
            this.pictureBox6.TabStop = false;
            // 
            // k_means
            // 
            this.k_means.Location = new System.Drawing.Point(1397, 261);
            this.k_means.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.k_means.Name = "k_means";
            this.k_means.Size = new System.Drawing.Size(99, 28);
            this.k_means.TabIndex = 39;
            this.k_means.Text = "K_means";
            this.k_means.UseVisualStyleBackColor = true;
            this.k_means.Click += new System.EventHandler(this.k_means_Click);
            // 
            // previous
            // 
            this.previous.Location = new System.Drawing.Point(169, 68);
            this.previous.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(99, 40);
            this.previous.TabIndex = 40;
            this.previous.Text = "Previous";
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // k_number
            // 
            this.k_number.ForeColor = System.Drawing.Color.Silver;
            this.k_number.Location = new System.Drawing.Point(1264, 264);
            this.k_number.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.k_number.Name = "k_number";
            this.k_number.Size = new System.Drawing.Size(111, 25);
            this.k_number.TabIndex = 41;
            this.k_number.Text = "K";
            this.k_number.Enter += new System.EventHandler(this.k_number_Enter);
            this.k_number.Leave += new System.EventHandler(this.k_number_Leave);
            // 
            // morphology
            // 
            this.morphology.Location = new System.Drawing.Point(1397, 309);
            this.morphology.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.morphology.Name = "morphology";
            this.morphology.Size = new System.Drawing.Size(99, 28);
            this.morphology.TabIndex = 43;
            this.morphology.Text = "Morphology";
            this.morphology.UseVisualStyleBackColor = true;
            this.morphology.Click += new System.EventHandler(this.morphology_Click);
            // 
            // comboBox_morphology
            // 
            this.comboBox_morphology.AutoCompleteCustomSource.AddRange(new string[] {
            "Erosin",
            "Dilation",
            "Opening",
            "Closing"});
            this.comboBox_morphology.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_morphology.FormattingEnabled = true;
            this.comboBox_morphology.Items.AddRange(new object[] {
            "Erosion",
            "Dilation",
            "Opening",
            "Closing"});
            this.comboBox_morphology.Location = new System.Drawing.Point(1264, 311);
            this.comboBox_morphology.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_morphology.Name = "comboBox_morphology";
            this.comboBox_morphology.Size = new System.Drawing.Size(111, 23);
            this.comboBox_morphology.TabIndex = 44;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBox7.Location = new System.Drawing.Point(40, 15);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(264, 106);
            this.pictureBox7.TabIndex = 45;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pictureBox8.Location = new System.Drawing.Point(541, 15);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(456, 105);
            this.pictureBox8.TabIndex = 46;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pictureBox9.Location = new System.Drawing.Point(1037, 16);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(232, 104);
            this.pictureBox9.TabIndex = 47;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox10.Location = new System.Drawing.Point(1239, 153);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(280, 210);
            this.pictureBox10.TabIndex = 48;
            this.pictureBox10.TabStop = false;
            // 
            // detial
            // 
            this.detial.FormattingEnabled = true;
            this.detial.ItemHeight = 15;
            this.detial.Location = new System.Drawing.Point(1059, 388);
            this.detial.Margin = new System.Windows.Forms.Padding(4);
            this.detial.Name = "detial";
            this.detial.Size = new System.Drawing.Size(460, 349);
            this.detial.TabIndex = 49;
            // 
            // Specified_size
            // 
            this.Specified_size.Location = new System.Drawing.Point(1427, 34);
            this.Specified_size.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Specified_size.Name = "Specified_size";
            this.Specified_size.Size = new System.Drawing.Size(75, 56);
            this.Specified_size.TabIndex = 50;
            this.Specified_size.Text = "Specified Size";
            this.Specified_size.UseVisualStyleBackColor = true;
            this.Specified_size.Click += new System.EventHandler(this.Specified_size_Click);
            // 
            // comboBox_zoom
            // 
            this.comboBox_zoom.AutoCompleteCustomSource.AddRange(new string[] {
            "0.5x Zoom",
            "0.2x Zoom",
            "2x Zoom",
            "5x Zoom"});
            this.comboBox_zoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_zoom.FormattingEnabled = true;
            this.comboBox_zoom.Items.AddRange(new object[] {
            "0.5x Zoom",
            "0.2x Zoom",
            "2x Zoom",
            "5x Zoom"});
            this.comboBox_zoom.Location = new System.Drawing.Point(1299, 110);
            this.comboBox_zoom.Name = "comboBox_zoom";
            this.comboBox_zoom.Size = new System.Drawing.Size(111, 23);
            this.comboBox_zoom.TabIndex = 51;
            // 
            // Imgresize
            // 
            this.Imgresize.Location = new System.Drawing.Point(1424, 110);
            this.Imgresize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Imgresize.Name = "Imgresize";
            this.Imgresize.Size = new System.Drawing.Size(78, 25);
            this.Imgresize.TabIndex = 52;
            this.Imgresize.Text = "Img Resize";
            this.Imgresize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Imgresize.UseVisualStyleBackColor = true;
            this.Imgresize.Click += new System.EventHandler(this.Imgresize_Click);
            // 
            // img_width
            // 
            this.img_width.ForeColor = System.Drawing.Color.Silver;
            this.img_width.Location = new System.Drawing.Point(1299, 31);
            this.img_width.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.img_width.Name = "img_width";
            this.img_width.Size = new System.Drawing.Size(111, 25);
            this.img_width.TabIndex = 55;
            this.img_width.Text = "Width";
            this.img_width.Enter += new System.EventHandler(this.img_width_Enter);
            this.img_width.Leave += new System.EventHandler(this.img_width_Leave);
            // 
            // img_height
            // 
            this.img_height.ForeColor = System.Drawing.Color.Silver;
            this.img_height.Location = new System.Drawing.Point(1299, 67);
            this.img_height.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.img_height.Name = "img_height";
            this.img_height.Size = new System.Drawing.Size(111, 25);
            this.img_height.TabIndex = 56;
            this.img_height.Text = "Height";
            this.img_height.Enter += new System.EventHandler(this.img_height_Enter);
            this.img_height.Leave += new System.EventHandler(this.img_height_Leave);
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox11.Location = new System.Drawing.Point(1277, 16);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(243, 129);
            this.pictureBox11.TabIndex = 57;
            this.pictureBox11.TabStop = false;
            // 
            // R_gray
            // 
            this.R_gray.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.R_gray.Location = new System.Drawing.Point(533, 775);
            this.R_gray.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.R_gray.Name = "R_gray";
            this.R_gray.Size = new System.Drawing.Size(139, 111);
            this.R_gray.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.R_gray.TabIndex = 58;
            this.R_gray.TabStop = false;
            // 
            // G_gray
            // 
            this.G_gray.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.G_gray.Location = new System.Drawing.Point(696, 775);
            this.G_gray.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.G_gray.Name = "G_gray";
            this.G_gray.Size = new System.Drawing.Size(139, 111);
            this.G_gray.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.G_gray.TabIndex = 59;
            this.G_gray.TabStop = false;
            // 
            // B_gray
            // 
            this.B_gray.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.B_gray.Location = new System.Drawing.Point(857, 775);
            this.B_gray.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B_gray.Name = "B_gray";
            this.B_gray.Size = new System.Drawing.Size(139, 111);
            this.B_gray.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.B_gray.TabIndex = 60;
            this.B_gray.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(578, 888);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 61;
            this.label1.Text = "R_gray";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(737, 888);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 62;
            this.label2.Text = "G_gray";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(905, 888);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 63;
            this.label3.Text = "B_gray";
            // 
            // comboBox_grayscale
            // 
            this.comboBox_grayscale.AutoCompleteCustomSource.AddRange(new string[] {
            "Weight",
            "Average",
            "Maximum"});
            this.comboBox_grayscale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_grayscale.FormattingEnabled = true;
            this.comboBox_grayscale.Items.AddRange(new object[] {
            "Weight",
            "Average",
            "Maximum"});
            this.comboBox_grayscale.Location = new System.Drawing.Point(422, 24);
            this.comboBox_grayscale.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_grayscale.Name = "comboBox_grayscale";
            this.comboBox_grayscale.Size = new System.Drawing.Size(111, 23);
            this.comboBox_grayscale.TabIndex = 64;
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(879, 22);
            this.log.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(99, 40);
            this.log.TabIndex = 65;
            this.log.Text = "Log";
            this.log.UseVisualStyleBackColor = true;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // power_law
            // 
            this.power_law.Location = new System.Drawing.Point(1173, 167);
            this.power_law.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.power_law.Name = "power_law";
            this.power_law.Size = new System.Drawing.Size(59, 56);
            this.power_law.TabIndex = 66;
            this.power_law.Text = "Power law";
            this.power_law.UseVisualStyleBackColor = true;
            this.power_law.Click += new System.EventHandler(this.power_law_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(879, 68);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 40);
            this.button1.TabIndex = 67;
            this.button1.Text = "Reserved";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pow_number
            // 
            this.pow_number.ForeColor = System.Drawing.Color.Silver;
            this.pow_number.Location = new System.Drawing.Point(1059, 167);
            this.pow_number.Name = "pow_number";
            this.pow_number.Size = new System.Drawing.Size(111, 25);
            this.pow_number.TabIndex = 68;
            this.pow_number.Text = "Pow";
            this.pow_number.Enter += new System.EventHandler(this.pow_number_Enter);
            this.pow_number.Leave += new System.EventHandler(this.pow_number_Leave);
            // 
            // c_number
            // 
            this.c_number.ForeColor = System.Drawing.Color.Silver;
            this.c_number.Location = new System.Drawing.Point(1059, 198);
            this.c_number.Name = "c_number";
            this.c_number.Size = new System.Drawing.Size(111, 25);
            this.c_number.TabIndex = 69;
            this.c_number.Text = "C";
            this.c_number.Enter += new System.EventHandler(this.c_number_Enter);
            this.c_number.Leave += new System.EventHandler(this.c_number_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1541, 915);
            this.Controls.Add(this.c_number);
            this.Controls.Add(this.pow_number);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.power_law);
            this.Controls.Add(this.log);
            this.Controls.Add(this.comboBox_grayscale);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B_gray);
            this.Controls.Add(this.G_gray);
            this.Controls.Add(this.R_gray);
            this.Controls.Add(this.img_height);
            this.Controls.Add(this.img_width);
            this.Controls.Add(this.Imgresize);
            this.Controls.Add(this.comboBox_zoom);
            this.Controls.Add(this.Specified_size);
            this.Controls.Add(this.detial);
            this.Controls.Add(this.comboBox_morphology);
            this.Controls.Add(this.morphology);
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
            this.Controls.Add(this.comboBox_fuzzy);
            this.Controls.Add(this.fuzzy);
            this.Controls.Add(this.comboBox_laplacian);
            this.Controls.Add(this.laplacian);
            this.Controls.Add(this.sobel);
            this.Controls.Add(this.retro);
            this.Controls.Add(this.show_detial);
            this.Controls.Add(this.invert);
            this.Controls.Add(this.grayscale);
            this.Controls.Add(this.processed_B);
            this.Controls.Add(this.processed_G);
            this.Controls.Add(this.processed_R);
            this.Controls.Add(this.origin_B);
            this.Controls.Add(this.origin_G);
            this.Controls.Add(this.origin_R);
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
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox11);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R_gray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.G_gray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_gray)).EndInit();
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
        private System.Windows.Forms.PictureBox origin_R;
        private System.Windows.Forms.PictureBox origin_G;
        private System.Windows.Forms.PictureBox origin_B;
        private System.Windows.Forms.PictureBox processed_B;
        private System.Windows.Forms.PictureBox processed_G;
        private System.Windows.Forms.PictureBox processed_R;
        private System.Windows.Forms.Button grayscale;
        private System.Windows.Forms.Button invert;
        private System.Windows.Forms.Button show_detial;
        private System.Windows.Forms.Button retro;
        private System.Windows.Forms.Button sobel;
        private System.Windows.Forms.Button laplacian;
        private System.Windows.Forms.ComboBox comboBox_laplacian;
        private System.Windows.Forms.Button fuzzy;
        private System.Windows.Forms.ComboBox comboBox_fuzzy;
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
        private System.Windows.Forms.Button morphology;
        private System.Windows.Forms.ComboBox comboBox_morphology;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.ListBox detial;
        private System.Windows.Forms.Button Specified_size;
        private System.Windows.Forms.ComboBox comboBox_zoom;
        private System.Windows.Forms.Button Imgresize;
        private System.Windows.Forms.TextBox img_width;
        private System.Windows.Forms.TextBox img_height;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox R_gray;
        private System.Windows.Forms.PictureBox G_gray;
        private System.Windows.Forms.PictureBox B_gray;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_grayscale;
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.Button power_law;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox pow_number;
        private System.Windows.Forms.TextBox c_number;
    }
}

