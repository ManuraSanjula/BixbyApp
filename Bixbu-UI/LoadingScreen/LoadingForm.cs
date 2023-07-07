using System.Drawing.Imaging;
using System.Runtime.InteropServices;


namespace Bixbu_UI.LoadingScreen
{
    public class LoadingForm : Form
    {
        private const int BlurAmount = 10; // Adjust the blur intensity here

        public LoadingForm()
        {
            // Customize loading screen appearance here
            Text = "Loading...";
            Width = 200;
            Height = 100;
            FormBorderStyle = FormBorderStyle.None;
            ShowInTaskbar = false;
            TopMost = true;
            TransparencyKey = Color.Turquoise;

            // Create a screenshot of the desktop as the background image
            using (var screenBitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height))
            {
                using (var g = Graphics.FromImage(screenBitmap))
                {
                    g.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, screenBitmap.Size);
                }

                // Apply a blur effect to the background image
                using (var blurredBitmap = BlurImage(screenBitmap, BlurAmount))
                {
                    BackgroundImage = blurredBitmap;
                }
            }
        }

        private Bitmap BlurImage(Image image, int blurAmount)
        {
            var blurredImage = new Bitmap(image.Width, image.Height);
            using (var g = Graphics.FromImage(blurredImage))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, new Rectangle(0, 0, blurredImage.Width, blurredImage.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel);

                // Apply blur effect using a Gaussian blur filter
                using (var filter = new GaussianBlurFilter(blurAmount))
                {
                    filter.Apply(blurredImage);
                }
            }

            return blurredImage;
        }
    }

    public class GaussianBlurFilter : IDisposable
    {
        private const int BitsPerPixel = 32;
        private const int BytesPerPixel = BitsPerPixel / 8;

        private readonly double sigma;
        private readonly int radius;
        private readonly int size;
        private readonly double[] kernel;

        public GaussianBlurFilter(int radius)
        {
            this.radius = radius;
            sigma = radius / 3.0;
            size = radius * 2 + 1;
            kernel = new double[size];

            CalculateKernel();
        }

        public void Apply(Bitmap image)
        {
            var width = image.Width;
            var height = image.Height;
            var bitmapData = image.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);

            try
            {
                var stride = bitmapData.Stride;

                var scan0 = bitmapData.Scan0;
                var pixelBuffer = new byte[stride * height];
                Marshal.Copy(scan0, pixelBuffer, 0, pixelBuffer.Length);

                var resultBuffer = new byte[pixelBuffer.Length];
                var bytesPerPixel = stride / width;

                for (var y = 0; y < height; y++)
                {
                    var currentLine = y * stride;

                    for (var x = 0; x < width; x++)
                    {
                        var currentPixel = currentLine + x * bytesPerPixel;

                        var red = 0.0;
                        var green = 0.0;
                        var blue = 0.0;
                        var alpha = 0.0;
                        var sum = 0.0;

                        for (var i = -radius; i <= radius; i++)
                        {
                            var neighborPixel = x + i;

                            if (neighborPixel >= 0 && neighborPixel < width)
                            {
                                var neighborIndex = currentLine + neighborPixel * bytesPerPixel;
                                var weight = kernel[i + radius];

                                blue += pixelBuffer[neighborIndex] * weight;
                                green += pixelBuffer[neighborIndex + 1] * weight;
                                red += pixelBuffer[neighborIndex + 2] * weight;
                                alpha += pixelBuffer[neighborIndex + 3] * weight;
                                sum += weight;
                            }
                        }

                        var resultIndex = currentPixel;
                        resultBuffer[resultIndex] = (byte)(blue / sum);
                        resultBuffer[resultIndex + 1] = (byte)(green / sum);
                        resultBuffer[resultIndex + 2] = (byte)(red / sum);
                        resultBuffer[resultIndex + 3] = (byte)(alpha / sum);
                    }
                }

                Marshal.Copy(resultBuffer, 0, scan0, resultBuffer.Length);
            }
            finally
            {
                image.UnlockBits(bitmapData);
            }
        }

        private void CalculateKernel()
        {
            var twoSigmaSquare = 2.0 * sigma * sigma;
            var sigmaRoot = Math.Sqrt(twoSigmaSquare * Math.PI);
            var total = 0.0;
            var halfSize = size / 2;

            for (var i = -halfSize; i <= halfSize; i++)
            {
                var distance = i * i;
                var weight = Math.Exp(-distance / twoSigmaSquare) / sigmaRoot;
                kernel[i + halfSize] = weight;
                total += weight;
            }

            for (var i = 0; i < size; i++)
            {
                kernel[i] /= total;
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
