namespace ImageProcessor
{
    partial class formImageProcessor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.pictureBoxOriginalImage = new System.Windows.Forms.PictureBox();
            this.saveFileDialogImage = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelEditor = new System.Windows.Forms.Label();
            this.pictureBoxNewImage = new System.Windows.Forms.PictureBox();
            this.imgBttn34 = new System.Windows.Forms.Button();
            this.imgBttn44 = new System.Windows.Forms.Button();
            this.imgBttn14 = new System.Windows.Forms.Button();
            this.imgBttn24 = new System.Windows.Forms.Button();
            this.imgBttn33 = new System.Windows.Forms.Button();
            this.imgBttn13 = new System.Windows.Forms.Button();
            this.imgBttn43 = new System.Windows.Forms.Button();
            this.imgBttn23 = new System.Windows.Forms.Button();
            this.imgBttn32 = new System.Windows.Forms.Button();
            this.imgBttn12 = new System.Windows.Forms.Button();
            this.imgBttn31 = new System.Windows.Forms.Button();
            this.imgBttn42 = new System.Windows.Forms.Button();
            this.imgBttn11 = new System.Windows.Forms.Button();
            this.imgBttn41 = new System.Windows.Forms.Button();
            this.imgBttn22 = new System.Windows.Forms.Button();
            this.imgBttn21 = new System.Windows.Forms.Button();
            this.buttonMixer = new System.Windows.Forms.Button();
            this.ButtonCheat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewImage)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpen
            // 
            this.buttonOpen.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonOpen.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.buttonOpen.FlatAppearance.BorderSize = 0;
            this.buttonOpen.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpen.ForeColor = System.Drawing.Color.Khaki;
            this.buttonOpen.Location = new System.Drawing.Point(25, 18);
            this.buttonOpen.Margin = new System.Windows.Forms.Padding(0);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(42, 20);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = false;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            this.buttonOpen.MouseHover += new System.EventHandler(this.buttonReOpen_MouseHover);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.ForeColor = System.Drawing.Color.Khaki;
            this.buttonSave.Location = new System.Drawing.Point(231, 18);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(62, 20);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            this.buttonSave.MouseHover += new System.EventHandler(this.buttonReOpen_MouseHover);
            // 
            // pictureBoxOriginalImage
            // 
            this.pictureBoxOriginalImage.Location = new System.Drawing.Point(12, 35);
            this.pictureBoxOriginalImage.Name = "pictureBoxOriginalImage";
            this.pictureBoxOriginalImage.Size = new System.Drawing.Size(296, 296);
            this.pictureBoxOriginalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxOriginalImage.TabIndex = 2;
            this.pictureBoxOriginalImage.TabStop = false;
            // 
            // saveFileDialogImage
            // 
            this.saveFileDialogImage.Filter = "JPG|*.jpg|BMP|*.bmp|PNG|*.png|GIF|*.gif";
            // 
            // openFileDialogImage
            // 
            this.openFileDialogImage.Filter = "JPG|*.jpg|BMP|*.bmp|PNG|*.png|GIF|*.gif";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.ForeColor = System.Drawing.Color.Khaki;
            this.buttonCancel.Location = new System.Drawing.Point(231, 311);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(62, 20);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            this.buttonCancel.MouseHover += new System.EventHandler(this.buttonReOpen_MouseHover);
            // 
            // labelEditor
            // 
            this.labelEditor.AutoSize = true;
            this.labelEditor.Location = new System.Drawing.Point(74, -4);
            this.labelEditor.Name = "labelEditor";
            this.labelEditor.Size = new System.Drawing.Size(157, 13);
            this.labelEditor.TabIndex = 17;
            this.labelEditor.Text = "g u r k a a n p u z z l e";
            // 
            // pictureBoxNewImage
            // 
            this.pictureBoxNewImage.Location = new System.Drawing.Point(12, 37);
            this.pictureBoxNewImage.Name = "pictureBoxNewImage";
            this.pictureBoxNewImage.Size = new System.Drawing.Size(296, 294);
            this.pictureBoxNewImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxNewImage.TabIndex = 2;
            this.pictureBoxNewImage.TabStop = false;
            // 
            // imgBttn34
            // 
            this.imgBttn34.BackColor = System.Drawing.Color.DarkSlateGray;
            this.imgBttn34.Location = new System.Drawing.Point(223, 178);
            this.imgBttn34.Name = "imgBttn34";
            this.imgBttn34.Size = new System.Drawing.Size(70, 64);
            this.imgBttn34.TabIndex = 18;
            this.imgBttn34.UseVisualStyleBackColor = false;
            this.imgBttn34.Click += new System.EventHandler(this.imgBttn34_Click);
            // 
            // imgBttn44
            // 
            this.imgBttn44.BackColor = System.Drawing.Color.DarkSlateGray;
            this.imgBttn44.Location = new System.Drawing.Point(223, 240);
            this.imgBttn44.Name = "imgBttn44";
            this.imgBttn44.Size = new System.Drawing.Size(70, 64);
            this.imgBttn44.TabIndex = 18;
            this.imgBttn44.UseVisualStyleBackColor = false;
            this.imgBttn44.Click += new System.EventHandler(this.imgBttn44_Click);
            // 
            // imgBttn14
            // 
            this.imgBttn14.BackColor = System.Drawing.Color.DarkSlateGray;
            this.imgBttn14.Location = new System.Drawing.Point(223, 54);
            this.imgBttn14.Name = "imgBttn14";
            this.imgBttn14.Size = new System.Drawing.Size(70, 64);
            this.imgBttn14.TabIndex = 18;
            this.imgBttn14.UseVisualStyleBackColor = false;
            this.imgBttn14.Click += new System.EventHandler(this.imgBttn14_Click);
            // 
            // imgBttn24
            // 
            this.imgBttn24.BackColor = System.Drawing.Color.DarkSlateGray;
            this.imgBttn24.Location = new System.Drawing.Point(223, 116);
            this.imgBttn24.Name = "imgBttn24";
            this.imgBttn24.Size = new System.Drawing.Size(70, 64);
            this.imgBttn24.TabIndex = 18;
            this.imgBttn24.UseVisualStyleBackColor = false;
            this.imgBttn24.Click += new System.EventHandler(this.imgBttn24_Click);
            // 
            // imgBttn33
            // 
            this.imgBttn33.BackColor = System.Drawing.Color.DarkSlateGray;
            this.imgBttn33.Location = new System.Drawing.Point(156, 178);
            this.imgBttn33.Name = "imgBttn33";
            this.imgBttn33.Size = new System.Drawing.Size(70, 64);
            this.imgBttn33.TabIndex = 18;
            this.imgBttn33.UseVisualStyleBackColor = false;
            this.imgBttn33.Click += new System.EventHandler(this.imgBttn33_Click);
            // 
            // imgBttn13
            // 
            this.imgBttn13.BackColor = System.Drawing.Color.DarkSlateGray;
            this.imgBttn13.Location = new System.Drawing.Point(156, 54);
            this.imgBttn13.Name = "imgBttn13";
            this.imgBttn13.Size = new System.Drawing.Size(70, 64);
            this.imgBttn13.TabIndex = 18;
            this.imgBttn13.UseVisualStyleBackColor = false;
            this.imgBttn13.Click += new System.EventHandler(this.imgBttn13_Click);
            // 
            // imgBttn43
            // 
            this.imgBttn43.BackColor = System.Drawing.Color.DarkSlateGray;
            this.imgBttn43.Location = new System.Drawing.Point(156, 240);
            this.imgBttn43.Name = "imgBttn43";
            this.imgBttn43.Size = new System.Drawing.Size(70, 64);
            this.imgBttn43.TabIndex = 18;
            this.imgBttn43.UseVisualStyleBackColor = false;
            this.imgBttn43.Click += new System.EventHandler(this.imgBttn43_Click);
            // 
            // imgBttn23
            // 
            this.imgBttn23.BackColor = System.Drawing.Color.DarkSlateGray;
            this.imgBttn23.Location = new System.Drawing.Point(156, 116);
            this.imgBttn23.Name = "imgBttn23";
            this.imgBttn23.Size = new System.Drawing.Size(70, 64);
            this.imgBttn23.TabIndex = 18;
            this.imgBttn23.UseVisualStyleBackColor = false;
            this.imgBttn23.Click += new System.EventHandler(this.imgBttn23_Click);
            // 
            // imgBttn32
            // 
            this.imgBttn32.BackColor = System.Drawing.Color.DarkSlateGray;
            this.imgBttn32.Location = new System.Drawing.Point(92, 178);
            this.imgBttn32.Name = "imgBttn32";
            this.imgBttn32.Size = new System.Drawing.Size(70, 64);
            this.imgBttn32.TabIndex = 18;
            this.imgBttn32.UseVisualStyleBackColor = false;
            this.imgBttn32.Click += new System.EventHandler(this.imgBttn32_Click);
            // 
            // imgBttn12
            // 
            this.imgBttn12.BackColor = System.Drawing.Color.DarkSlateGray;
            this.imgBttn12.Location = new System.Drawing.Point(92, 54);
            this.imgBttn12.Name = "imgBttn12";
            this.imgBttn12.Size = new System.Drawing.Size(70, 64);
            this.imgBttn12.TabIndex = 18;
            this.imgBttn12.UseVisualStyleBackColor = false;
            this.imgBttn12.Click += new System.EventHandler(this.imgBttn12_Click);
            // 
            // imgBttn31
            // 
            this.imgBttn31.BackColor = System.Drawing.Color.DarkSlateGray;
            this.imgBttn31.Location = new System.Drawing.Point(25, 178);
            this.imgBttn31.Name = "imgBttn31";
            this.imgBttn31.Size = new System.Drawing.Size(70, 64);
            this.imgBttn31.TabIndex = 18;
            this.imgBttn31.UseVisualStyleBackColor = false;
            this.imgBttn31.Click += new System.EventHandler(this.imgBttn31_Click);
            // 
            // imgBttn42
            // 
            this.imgBttn42.BackColor = System.Drawing.Color.DarkSlateGray;
            this.imgBttn42.Location = new System.Drawing.Point(92, 240);
            this.imgBttn42.Name = "imgBttn42";
            this.imgBttn42.Size = new System.Drawing.Size(70, 64);
            this.imgBttn42.TabIndex = 18;
            this.imgBttn42.UseVisualStyleBackColor = false;
            this.imgBttn42.Click += new System.EventHandler(this.imgBttn42_Click);
            // 
            // imgBttn11
            // 
            this.imgBttn11.BackColor = System.Drawing.Color.DarkSlateGray;
            this.imgBttn11.Location = new System.Drawing.Point(25, 54);
            this.imgBttn11.Name = "imgBttn11";
            this.imgBttn11.Size = new System.Drawing.Size(70, 64);
            this.imgBttn11.TabIndex = 18;
            this.imgBttn11.UseVisualStyleBackColor = false;
            this.imgBttn11.Click += new System.EventHandler(this.imgBttn11_Click);
            // 
            // imgBttn41
            // 
            this.imgBttn41.BackColor = System.Drawing.Color.DarkSlateGray;
            this.imgBttn41.Location = new System.Drawing.Point(25, 240);
            this.imgBttn41.Name = "imgBttn41";
            this.imgBttn41.Size = new System.Drawing.Size(70, 64);
            this.imgBttn41.TabIndex = 18;
            this.imgBttn41.UseVisualStyleBackColor = false;
            this.imgBttn41.Click += new System.EventHandler(this.imgBttn41_Click);
            // 
            // imgBttn22
            // 
            this.imgBttn22.BackColor = System.Drawing.Color.DarkSlateGray;
            this.imgBttn22.Location = new System.Drawing.Point(92, 116);
            this.imgBttn22.Name = "imgBttn22";
            this.imgBttn22.Size = new System.Drawing.Size(70, 64);
            this.imgBttn22.TabIndex = 18;
            this.imgBttn22.UseVisualStyleBackColor = false;
            this.imgBttn22.Click += new System.EventHandler(this.imgBttn22_Click);
            // 
            // imgBttn21
            // 
            this.imgBttn21.BackColor = System.Drawing.Color.DarkSlateGray;
            this.imgBttn21.Location = new System.Drawing.Point(25, 116);
            this.imgBttn21.Name = "imgBttn21";
            this.imgBttn21.Size = new System.Drawing.Size(70, 64);
            this.imgBttn21.TabIndex = 18;
            this.imgBttn21.UseVisualStyleBackColor = false;
            this.imgBttn21.Click += new System.EventHandler(this.imgBttn21_Click);
            // 
            // buttonMixer
            // 
            this.buttonMixer.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonMixer.Location = new System.Drawing.Point(158, 17);
            this.buttonMixer.Name = "buttonMixer";
            this.buttonMixer.Size = new System.Drawing.Size(75, 23);
            this.buttonMixer.TabIndex = 19;
            this.buttonMixer.Text = "Mixer";
            this.buttonMixer.UseVisualStyleBackColor = false;
            this.buttonMixer.Click += new System.EventHandler(this.buttonMixer_Click);
            // 
            // ButtonCheat
            // 
            this.ButtonCheat.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ButtonCheat.Location = new System.Drawing.Point(77, 17);
            this.ButtonCheat.Name = "ButtonCheat";
            this.ButtonCheat.Size = new System.Drawing.Size(75, 23);
            this.ButtonCheat.TabIndex = 20;
            this.ButtonCheat.Text = "Cheat";
            this.ButtonCheat.UseVisualStyleBackColor = false;
            this.ButtonCheat.Click += new System.EventHandler(this.ButtonCheat_Click_1);
            // 
            // formImageProcessor
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(319, 343);
            this.ControlBox = false;
            this.Controls.Add(this.ButtonCheat);
            this.Controls.Add(this.buttonMixer);
            this.Controls.Add(this.imgBttn21);
            this.Controls.Add(this.imgBttn23);
            this.Controls.Add(this.imgBttn22);
            this.Controls.Add(this.imgBttn24);
            this.Controls.Add(this.imgBttn41);
            this.Controls.Add(this.imgBttn11);
            this.Controls.Add(this.imgBttn43);
            this.Controls.Add(this.imgBttn42);
            this.Controls.Add(this.imgBttn13);
            this.Controls.Add(this.imgBttn31);
            this.Controls.Add(this.imgBttn44);
            this.Controls.Add(this.imgBttn12);
            this.Controls.Add(this.imgBttn33);
            this.Controls.Add(this.imgBttn32);
            this.Controls.Add(this.imgBttn14);
            this.Controls.Add(this.imgBttn34);
            this.Controls.Add(this.labelEditor);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.pictureBoxNewImage);
            this.Controls.Add(this.pictureBoxOriginalImage);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonOpen);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Khaki;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "formImageProcessor";
            this.Opacity = 0.99D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Processor ";
            this.TransparencyKey = System.Drawing.Color.DarkKhaki;
            this.Load += new System.EventHandler(this.formImageProcessor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginalImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.PictureBox pictureBoxOriginalImage;
        private System.Windows.Forms.SaveFileDialog saveFileDialogImage;
        private System.Windows.Forms.OpenFileDialog openFileDialogImage;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelEditor;
        private System.Windows.Forms.PictureBox pictureBoxNewImage;
        private System.Windows.Forms.Button imgBttn34;
        private System.Windows.Forms.Button imgBttn44;
        private System.Windows.Forms.Button imgBttn14;
        private System.Windows.Forms.Button imgBttn24;
        private System.Windows.Forms.Button imgBttn33;
        private System.Windows.Forms.Button imgBttn13;
        private System.Windows.Forms.Button imgBttn43;
        private System.Windows.Forms.Button imgBttn23;
        private System.Windows.Forms.Button imgBttn32;
        private System.Windows.Forms.Button imgBttn12;
        private System.Windows.Forms.Button imgBttn31;
        private System.Windows.Forms.Button imgBttn42;
        private System.Windows.Forms.Button imgBttn11;
        private System.Windows.Forms.Button imgBttn41;
        private System.Windows.Forms.Button imgBttn22;
        private System.Windows.Forms.Button imgBttn21;
        private System.Windows.Forms.Button buttonMixer;
        private System.Windows.Forms.Button ButtonCheat;
    }
}

