using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DayOrNight.util;

namespace DayOrNight
{
    class Program
    {
        static void Main(string[] args)
        {

            ImageConverter converter = new ImageConverter(
                "D:\\docs\\Documents\\Visual Studio 2012\\Projects\\day-or-night\\images\\test\\img01day.PNG"
                );

            converter.ConvertToText();
        }
    }
}
