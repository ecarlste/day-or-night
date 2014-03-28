
using System.Drawing;

namespace Day_or_Night.util
{
    class ImageConverter
    {
        Image imageToConvert;

        public ImageConverter()
        {
            imageToConvert = null;
        }

        public ImageConverter(string filename)
        {
            imageToConvert = Image.FromFile(filename);
        }

        public void ConvertToText()
        {
            string imageText;


        }
    }
}
