using ImageProcess2;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Coins
{
    public partial class Main : Form
    {
        private Bitmap img;
        private Image<Bgr, byte> loadedImage;

        public Main()
        {
            InitializeComponent();
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            ofdImage = new OpenFileDialog();
            ofdImage.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";

            if (ofdImage.ShowDialog() == DialogResult.OK)
            {
                txtFilename.Text = ofdImage.FileName;
                this.img = new Bitmap(ofdImage.FileName);
                pbImage.Image = this.img;
                loadedImage = new Image<Bgr, byte>(ofdImage.FileName);
            }
        }

        private void btnGrayScale_Click(object sender, EventArgs e)
        {
            ImageProcess2.BitmapFilter.GrayScale(this.img);
            pbImage.Image = this.img;
        }

        private void tbContrast_Scroll(object sender, EventArgs e)
        {
            ImageProcess2.BitmapFilter.Contrast(this.img, (sbyte)tbContrast.Value);
            pbImage.Image = this.img;
        }

        private void tbBrightness_Scroll(object sender, EventArgs e)
        {
            ImageProcess2.BitmapFilter.Brightness(this.img, tbBrightness.Value);
            pbImage.Image = this.img;
        }

        public byte[] ToByteArray(Image image, ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                return ms.ToArray();
            }
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            Image<Bgr, byte> a = this.ToByteArray(img);
            
            //Image<Bgr, byte> grayImage = new Image<Bgr, byte>(newImage.Width);
            //Image<Gray, byte> grayImage = loadedImage.Convert<Gray, byte>();

            // Apply Gaussian Blur to reduce noise
            //grayImage = grayImage.SmoothGaussian(9);

            // Detect circles using Hough Transform
            CircleF[] circles = CvInvoke.HoughCircles(
                grayImage,
                HoughModes.Gradient,
                2.0,           // Inverse ratio of the accumulator resolution to the image resolution
                20.0,          // Minimum distance between the centers of the detected circles
                100.0,         // Higher threshold for the Canny edge detector
                50.0,          // Accumulator threshold for the circle centers
                10,            // Minimum radius
                100            // Maximum radius
            );

            // Draw the detected circles
            foreach (var circle in circles)
            {
                loadedImage.Draw(circle, new Bgr(Color.Red), 2); // Draw each circle in red
            }

            // Update the PictureBox with the detected circles
            //pbImage.Image = (Bitmap) loadedImage;

            MessageBox.Show($"Detected {circles.Length} coin(s).");
        }

    }
}
