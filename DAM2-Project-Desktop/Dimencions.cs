using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM2_Project_Desktop
{
    public static class Dimencions
    {
        public static int MinWidth { get; } = 1440;
        public static int MinHeight { get; } = 1024;

        public static void ApplyMinimum(Form form)
        {
            form.MinimumSize = new Size(MinWidth, MinHeight);
        }
///lol



        public static Size Scale(Size originalSize, Size currentFormSize)
        {
            float widthRatio = currentFormSize.Width / (float)MinWidth;
            float heightRatio = currentFormSize.Height / (float)MinHeight;
            return new Size((int)(originalSize.Width * widthRatio), (int)(originalSize.Height * heightRatio));
        }
    }
}