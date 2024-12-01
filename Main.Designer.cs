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
            btnCount = new Button();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // ofdImage
            // 
            ofdImage.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            // 
            // btnUploadImage
            // 
            btnUploadImage.Location = new Point(649, 13);
            btnUploadImage.Margin = new Padding(3, 4, 3, 4);
            btnUploadImage.Name = "btnUploadImage";
            btnUploadImage.Size = new Size(184, 43);
            btnUploadImage.TabIndex = 0;
            btnUploadImage.Text = "Upload Image";
            btnUploadImage.UseVisualStyleBackColor = true;
            btnUploadImage.Click += btnUploadImage_Click;
            // 
            // txtFilename
            // 
            txtFilename.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFilename.Location = new Point(14, 21);
            txtFilename.Margin = new Padding(3, 4, 3, 4);
            txtFilename.Name = "txtFilename";
            txtFilename.Size = new Size(607, 29);
            txtFilename.TabIndex = 1;
            // 
            // pbImage
            // 
            pbImage.Location = new Point(14, 67);
            pbImage.Margin = new Padding(3, 4, 3, 4);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(1007, 905);
            pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbImage.TabIndex = 2;
            pbImage.TabStop = false;
            // 
            // btnCount
            // 
            btnCount.Location = new Point(839, 13);
            btnCount.Margin = new Padding(3, 4, 3, 4);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(182, 43);
            btnCount.TabIndex = 8;
            btnCount.Text = "Count";
            btnCount.UseVisualStyleBackColor = true;
            btnCount.Click += btnCount_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 989);
            Controls.Add(btnCount);
            Controls.Add(pbImage);
            Controls.Add(txtFilename);
            Controls.Add(btnUploadImage);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Coins Chuchu";
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog ofdImage;
        private Button btnUploadImage;
        private TextBox txtFilename;
        private PictureBox pbImage;
        private Button btnCount;
    }
}
