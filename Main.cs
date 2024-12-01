using ImageProcess2;
//using Emgu.CV;
//using Emgu.CV.CvEnum;
//using Emgu.CV.Structure;
//using Emgu.CV.Reg;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing;

using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.DataFormats;
using System.Runtime.InteropServices;
using System.Dynamic;

namespace Coins
{
    public partial class Main : Form
    {
        private Bitmap img;

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
            }
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            var coinValues = new Dictionary<string, double>
            {
                { "five_cents", 0.05 },
                { "ten_cents", 0.10 },
                { "twentyfive_cents", 0.25 },
                { "one_peso", 1.00 },
                { "five_peso", 5.00 }
            };

            var coinSizes = new Dictionary<string, (double MinRadius, double MaxRadius)>
            {
                { "five_cents", (25.0, 30.9) },
                { "ten_cents", (31.0, 33.0) },
                { "twentyfive_cents", (35.0, 38.0) },
                { "one_peso", (42.0, 45.0) },
                { "five_peso", (48.0, 50.0) }
            };

            Mat src = Cv2.ImRead(txtFilename.Text);
            Mat gray = new Mat();
            Cv2.CvtColor(src, gray, ColorConversionCodes.BGR2GRAY);
            Cv2.GaussianBlur(gray, gray, new OpenCvSharp.Size(5, 5), 2, 2);

            Mat binary = new Mat();
            Cv2.Threshold(gray, binary, 0, 255, ThresholdTypes.BinaryInv | ThresholdTypes.Otsu);

            Mat morph = new Mat();
            Mat kernel = Cv2.GetStructuringElement(MorphShapes.Ellipse, new OpenCvSharp.Size(5, 5));
            Cv2.MorphologyEx(binary, morph, MorphTypes.Close, kernel);

            Mat smoothed = new Mat();
            Cv2.MorphologyEx(morph, smoothed, MorphTypes.Open, kernel);
            Cv2.FindContours(smoothed, out OpenCvSharp.Point[][] contours, out HierarchyIndex[] hierarchy, RetrievalModes.External, ContourApproximationModes.ApproxSimple);

            double totalValue = 0.0;

            for (int i = 0; i < contours.Length; i++)
            {
                var contour = contours[i];
                var rect = Cv2.BoundingRect(contour);
                float radius = rect.Width / 2f;
                string label = "";
                string coinType = coinSizes.FirstOrDefault(cs => radius >= cs.Value.MinRadius && radius <= cs.Value.MaxRadius).Key;

                if (coinValues.ContainsKey(coinType))
                {
                    label = "Value: " + coinValues[coinType];
                    totalValue += coinValues[coinType];                    
                }

                Cv2.DrawContours(src, contours, i, Scalar.Black, -1);
                Cv2.PutText(src, label, new OpenCvSharp.Point(rect.X, rect.Y - 10), HersheyFonts.HersheySimplex, 0.5, Scalar.Blue, 1);
            }

            pbImage.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(src);
            
            MessageBox.Show($"Total value of coins: {totalValue:C}");
        }



    }


}
