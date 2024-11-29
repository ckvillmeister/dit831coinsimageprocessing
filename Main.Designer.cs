namespace Coins
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ofdImage = new OpenFileDialog();
            btnUploadImage = new Button();
            txtFilename = new TextBox();
            pbImage = new PictureBox();
            btnGrayScale = new Button();
            tbBrightness = new TrackBar();
            tbContrast = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            btnCount = new Button();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbBrightness).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbContrast).BeginInit();
            SuspendLayout();
            // 
            // ofdImage
            // 
            ofdImage.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            // 
            // btnUploadImage
            // 
            btnUploadImage.Location = new Point(425, 12);
            btnUploadImage.Name = "btnUploadImage";
            btnUploadImage.Size = new Size(118, 32);
            btnUploadImage.TabIndex = 0;
            btnUploadImage.Text = "Upload Image";
            btnUploadImage.UseVisualStyleBackColor = true;
            btnUploadImage.Click += btnUploadImage_Click;
            // 
            // txtFilename
            // 
            txtFilename.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFilename.Location = new Point(12, 16);
            txtFilename.Name = "txtFilename";
            txtFilename.Size = new Size(407, 25);
            txtFilename.TabIndex = 1;
            // 
            // pbImage
            // 
            pbImage.Location = new Point(12, 50);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(531, 679);
            pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbImage.TabIndex = 2;
            pbImage.TabStop = false;
            // 
            // btnGrayScale
            // 
            btnGrayScale.Location = new Point(667, 244);
            btnGrayScale.Name = "btnGrayScale";
            btnGrayScale.Size = new Size(118, 32);
            btnGrayScale.TabIndex = 3;
            btnGrayScale.Text = "Gray Scale";
            btnGrayScale.UseVisualStyleBackColor = true;
            btnGrayScale.Click += btnGrayScale_Click;
            // 
            // tbBrightness
            // 
            tbBrightness.Location = new Point(561, 90);
            tbBrightness.Maximum = 100;
            tbBrightness.Minimum = -100;
            tbBrightness.Name = "tbBrightness";
            tbBrightness.Size = new Size(331, 45);
            tbBrightness.TabIndex = 4;
            tbBrightness.Scroll += tbBrightness_Scroll;
            // 
            // tbContrast
            // 
            tbContrast.Location = new Point(561, 174);
            tbContrast.Maximum = 100;
            tbContrast.Minimum = -100;
            tbContrast.Name = "tbContrast";
            tbContrast.Size = new Size(331, 45);
            tbContrast.TabIndex = 5;
            tbContrast.Scroll += tbContrast_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(695, 72);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 6;
            label1.Text = "Brightness";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(700, 156);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 7;
            label2.Text = "Contrast";
            // 
            // btnCount
            // 
            btnCount.Location = new Point(549, 12);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(118, 32);
            btnCount.TabIndex = 8;
            btnCount.Text = "Count";
            btnCount.UseVisualStyleBackColor = true;
            btnCount.Click += btnCount_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 742);
            Controls.Add(btnCount);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbContrast);
            Controls.Add(tbBrightness);
            Controls.Add(btnGrayScale);
            Controls.Add(pbImage);
            Controls.Add(txtFilename);
            Controls.Add(btnUploadImage);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Coins Chuchu";
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbBrightness).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbContrast).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog ofdImage;
        private Button btnUploadImage;
        private TextBox txtFilename;
        private PictureBox pbImage;
        private Button btnGrayScale;
        private TrackBar tbBrightness;
        private TrackBar tbContrast;
        private Label label1;
        private Label label2;
        private Button btnCount;
    }
}
