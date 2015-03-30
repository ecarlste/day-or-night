
using System.Drawing;

namespace DayOrNight.util
{
    class ImageConverter
    {
        Bitmap imageToConvert;

        public ImageConverter()
        {
            imageToConvert = null;
        }

        public ImageConverter(string filename)
        {
            imageToConvert = new Bitmap(filename);
        }

        public void ConvertToText()
        {
            string imageText = "";

            Color currentPixel;

            for (int x = 0; x < imageToConvert.Width; x++)
            {
                if (x > 0)
                {
                    imageText += System.Environment.NewLine;
                }

                for (int y = 0; y < imageToConvert.Height; y++)
                {
                    currentPixel = imageToConvert.GetPixel(x, y);

                    if (y > 0)
                    {
                        imageText += " ";
                    }

                    imageText += currentPixel.B + "," + currentPixel.G + "," + currentPixel.R;
                }
            }

            imageText += imageToConvert.GetPixel(0, 0);

        }
    }
}
