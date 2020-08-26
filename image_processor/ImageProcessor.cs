using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Threading.Tasks;

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

        Parallel.ForEach(filenames, (myFile) =>
        {

            Bitmap image = new Bitmap(myFile);
            var extension = Path.GetExtension(myFile);
            var fileName = Path.GetFileNameWithoutExtension(myFile);
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
        });
    }
    /// <summary>
    /// Method that grayscale an image
    /// </summary>
    /// <param name="filenames">files to operate for grayscale</param>
    public static void Grayscale(string[] filenames)
    {

        Parallel.ForEach(filenames, (myFile) =>
        {

            Bitmap image = new Bitmap(myFile);
            var extension = Path.GetExtension(myFile);
            var fileName = Path.GetFileNameWithoutExtension(myFile);
            fileName += "_grayscale" + extension;
            Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);
            System.Drawing.Imaging.BitmapData imageData =
            image.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite,
            image.PixelFormat);

            IntPtr pointer = imageData.Scan0;

            var bitmapBytes = Math.Abs(imageData.Stride) * image.Height;
            var rgbValues = new byte[bitmapBytes];

            System.Runtime.InteropServices.Marshal.Copy(pointer, rgbValues, 0, bitmapBytes);

            for (int counter = 0; counter < rgbValues.Length; counter += 3)
            {
                rgbValues[counter] = (byte)((rgbValues[counter] + rgbValues[counter + 1] + rgbValues[counter + 2]) / 2);
            }


            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, pointer, bitmapBytes);
            image.UnlockBits(imageData);

            image.Save($"{fileName}");
        });
    }
}
