using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM2_Project_Desktop
{
    public static class Dimencions
    {
        // Resolución de referencia base para el escalado.
        private const int BASE_WIDTH = 1440;
        private const int BASE_HEIGHT = 1024;

        public static Size Scale(Size originalSize, Size currentFormSize)
        {
            // Usa solo el factor de escala del ancho para mantener la proporción visual
            float scaleFactor = (float)currentFormSize.Width / BASE_WIDTH;

            int newWidth = (int)(originalSize.Width * scaleFactor);
            int newHeight = (int)(originalSize.Height * scaleFactor);

            return new Size(newWidth, newHeight);
        }

        public static Point Scale(Point originalLocation, Size currentFormSize)
        {
            // Reutiliza los factores de escalado.
            float scaleFactorW = (float)currentFormSize.Width / BASE_WIDTH;
            float scaleFactorH = (float)currentFormSize.Height / BASE_HEIGHT;

            // Aplica el escalado a la posición.
            int newX = (int)(originalLocation.X * scaleFactorW);
            int newY = (int)(originalLocation.Y * scaleFactorH);

            return new Point(newX, newY);
        }


        public static Font ScaleFont(Font originalFont, float baseFontSize, Size currentFormSize)
        {
            float scaleFactor = (float)currentFormSize.Width / BASE_WIDTH;
            float newSize = baseFontSize * scaleFactor;

            // Mantiene un tamaño mínimo legible.
            if (newSize < 5f) newSize = 5f;

            // Retorna un nuevo objeto Font.
            return new Font(originalFont.FontFamily, newSize, originalFont.Style);
        }

        public static void ApplyMinimum(Form form)
        {
            form.MinimumSize = new Size(BASE_WIDTH, BASE_HEIGHT);
        }
    }
}