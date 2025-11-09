using System;
using System.Drawing;
using System.Windows.Forms;

public static class Dimencions
{
    // Dimensiones de diseño base (Formulario completo)
    private const int DESIGN_WIDTH_BASE = 1422;
    private const int DESIGN_HEIGHT_BASE = 1100;
    private const int DESIGN_SIDEBAR_WIDTH = 242;

    // Método para escalar el tamaño de un control.
    public static Size Scale(Size baseSize, Size currentClientSize)
    {
        float ratioW = (float)currentClientSize.Width / DESIGN_WIDTH_BASE;
        float ratioH = (float)currentClientSize.Height / DESIGN_HEIGHT_BASE;

        // Usa el ratio más restrictivo para el escalado proporcional.
        float scaleFactor = Math.Min(ratioW, ratioH);

        int newWidth = (int)(baseSize.Width * scaleFactor);
        int newHeight = (int)(baseSize.Height * scaleFactor);

        return new Size(newWidth, newHeight);
    }

    // Método general para escalar la posición y tamaño de un control (usa minRatio).
    public static void ResizeControl(Control control, Rectangle originalRectangle, Form form, Size originalFormSize)
    {
        float xRatio = (float)form.Width / (float)originalFormSize.Width;
        float yRatio = (float)form.Height / (float)originalFormSize.Height;

        float minRatio = Math.Min(xRatio, yRatio);

        int newX = (int)(originalRectangle.X * minRatio);
        int newY = (int)(originalRectangle.Y * minRatio);

        int newWidth = (int)(originalRectangle.Width * minRatio);
        int newHeight = (int)(originalRectangle.Height * minRatio);

        control.Location = new Point(newX, newY);
        control.Size = new Size(newWidth, newHeight);
    }

    // Método específico para escalar los botones laterales.
    // Usa yRatio para la posición Y (evitando el apilamiento) y centra en X.
    public static void ResizeSidebarButtons(Control[] buttons, Rectangle[] originalRects, int sidebarPanelWidth, Form form)
    {
        Size currentClientSize = form.ClientSize;

        float yRatio = (float)form.Height / DESIGN_HEIGHT_BASE;
        float sidebarXRatio = (float)sidebarPanelWidth / DESIGN_SIDEBAR_WIDTH;

        const int BUTTON_ORIGINAL_WIDTH = 200;

        int buttonScaledWidth = (int)(BUTTON_ORIGINAL_WIDTH * sidebarXRatio);
        int startX = (sidebarPanelWidth / 2) - (buttonScaledWidth / 2);

        for (int i = 0; i < buttons.Length; i++)
        {
            int newWidth = (int)(BUTTON_ORIGINAL_WIDTH * sidebarXRatio);
            int newHeight = (int)(60 * sidebarXRatio);

            buttons[i].Size = new Size(newWidth, newHeight);

            int newY = (int)(originalRects[i].Y * yRatio);

            buttons[i].Location = new Point(startX, newY);
        }
    }
    public static void ApplyMinimum(Form form)
    {
        
    }
     
    public static void ScaleAndCenterHeader(
    PictureBox pictureBoxHeader,
    SplitContainer splitContainer,
    int originalSplitterDistance,
    Form form,
    int formBaseHeight = 1024)
    {
       
        float scaleY = (float)form.ClientSize.Height / formBaseHeight;
        int newSplitterDistance = (int)(originalSplitterDistance * scaleY);
        splitContainer.SplitterDistance = newSplitterDistance;

        Control panelContainer = splitContainer.Panel1;
        int containerHeight = panelContainer.ClientSize.Height;
        int controlHeight = pictureBoxHeader.Height;
        int newY = (containerHeight - controlHeight) / 2;
        if (newY >= 0)
        {
            pictureBoxHeader.Top = newY;
        }
    }


}