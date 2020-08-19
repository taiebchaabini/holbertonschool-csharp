using System;
using System.Drawing;
using System.Threading.Tasks; 
using System.Drawing.Imaging;

/// <summary>
/// Creates an image processing that takes a list of images and creates new images from them based on the method
/// </summary>
class ImageProcessor
{
    /// <summary>
    /// Method that inverts an image’s color
    /// </summary>
    /// <param name="filenames">files to operate for inverts.</param>
    public static void Inverse(string[] filenames)
    {

        Parallel.For(0, filenames.Length, delegate (int i)
        {
            Bitmap image = new Bitmap(filenames[i]);
            var fileName = filenames[i].Replace("images/", "").Replace(".jpg", "_inverse.jpg");

            Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);
            System.Drawing.Imaging.BitmapData imageData =
            image.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite,
            image.PixelFormat);
            
            IntPtr pointer = imageData.Scan0;

            var bitmapBytes  = Math.Abs(imageData.Stride) * image.Height;
            var rgbValues = new byte[bitmapBytes];

            System.Runtime.InteropServices.Marshal.Copy(pointer, rgbValues, 0, bitmapBytes);
            
            for (int counter = 2; counter < rgbValues.Length; counter += 1){
                rgbValues[counter] = (byte)~rgbValues[counter];
            }


            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, pointer, bitmapBytes);
            image.UnlockBits(imageData);

            /*
            for (int y = 0; (y <= (image.Height - 1)); y++)
            {
                for (int x = 0; (x <= (image.Width - 1)); x++)
                {
                    // Get current pixel
                    Color invert = image.GetPixel(x, y);
                    // Revert pixels
                    invert = Color.FromArgb(255 - invert.A, 255 - invert.R, 255 - invert.G, 255 - invert.B);
                    // Set reverted pixel
                    image.SetPixel(x, y, invert);
                }
            }
            */
            image.Save($"{fileName}");


        });
    }
}
