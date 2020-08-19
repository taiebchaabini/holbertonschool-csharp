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

        for (int i = 0; i < filenames.Length; i++)
        {
            Bitmap image = new Bitmap(filenames[i]);
            var fName = filenames[i].Replace("/", ".").Split(".");
            var extension = "." + fName[fName.Length - 1];
            var fileName = fName[fName.Length - 2];
            fileName += "_inverse" + extension;
            Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);
            System.Drawing.Imaging.BitmapData imageData =
            image.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite,
            image.PixelFormat);

            IntPtr pointer = imageData.Scan0;

            var bitmapBytes = Math.Abs(imageData.Stride) * image.Height;
            var rgbValues = new byte[bitmapBytes];

            System.Runtime.InteropServices.Marshal.Copy(pointer, rgbValues, 0, bitmapBytes);

            for (int counter = 0; counter < rgbValues.Length; counter += 1)
            {
                rgbValues[counter] = (byte)(255 - rgbValues[counter]);
            }


            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, pointer, bitmapBytes);
            image.UnlockBits(imageData);

            image.Save($"{fileName}");
        }
    }
}
