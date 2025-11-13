using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DAM2_Project_Desktop
{
    public partial class Pantalla1 : Form
    {
        private Size originalFormSize;


        private Dictionary<Control, Rectangle> originalRects = new Dictionary<Control, Rectangle>();
        private Dictionary<Control, float> originalFonts = new Dictionary<Control, float>();

        public Pantalla1()
        {
            InitializeComponent();

            originalFormSize = this.Size;
            ListadoDatosClasses.importProjects();
            ListadoDatosClasses.exportUsers();
            ListadoDatosClasses.importUsers();


            SaveOriginalControlData(this);

            ButtonLogin.FlatStyle = FlatStyle.Flat;
            ButtonLogin.FlatAppearance.BorderSize = 1;

            pictureBox3.Image = Properties.Resources.back;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Paint += pictureBox3_Paint;

            this.Resize += Pantalla1_Resize;
        }

        private void SaveOriginalControlData(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                originalRects[ctrl] = ctrl.Bounds;
                originalFonts[ctrl] = ctrl.Font.Size;

                if (ctrl.Controls.Count > 0)
                    SaveOriginalControlData(ctrl);
            }
        }

        private void Pantalla1_Resize(object sender, EventArgs e)
        {
            float scaleX = (float)this.Width / originalFormSize.Width;
            float scaleY = (float)this.Height / originalFormSize.Height;

            ScaleAllControls(this, scaleX, scaleY);

            pictureBox3.Invalidate();
        }

        private void ScaleAllControls(Control parent, float scaleX, float scaleY)
        {
            foreach (Control ctrl in parent.Controls)
            {
                Rectangle original = originalRects[ctrl];
                ctrl.Left = (int)(original.Left * scaleX);
                ctrl.Top = (int)(original.Top * scaleY);
                ctrl.Width = (int)(original.Width * scaleX);
                ctrl.Height = (int)(original.Height * scaleY);

                float originalFontSize = originalFonts[ctrl];
                ctrl.Font = new Font(ctrl.Font.FontFamily, originalFontSize * Math.Min(scaleX, scaleY), ctrl.Font.Style);

                if (ctrl.Controls.Count > 0)
                    ScaleAllControls(ctrl, scaleX, scaleY);
            }
        }

        private void pictureBox3_Paint(object sender, PaintEventArgs e)
        {
            float scaleX = (float)this.Width / originalFormSize.Width;
            float scaleY = (float)this.Height / originalFormSize.Height;
            float scale = Math.Min(scaleX, scaleY);

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            e.Graphics.DrawString(
                "Welcome",
                new Font("Montserrat", 60 * scale, FontStyle.Bold | FontStyle.Italic),
                Brushes.White,
                new PointF(150 * scaleX, 360 * scaleY));

            e.Graphics.DrawString(
                "Sign in to continue",
                new Font("Montserrat", 15 * scale, FontStyle.Italic),
                Brushes.White,
                new PointF(180 * scaleX, 480 * scaleY));
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUser.Text.Trim();
            string password = textBoxPass.Text.Trim();

            string correctUsername = "Tasky";
            string correctPassword = "123456";

            if (username == correctUsername && password == correctPassword)
            {
                Pantalla2 pantalla2 = new Pantalla2();
                pantalla2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password!");
                textBoxPass.Clear();
                textBoxUser.Clear();
                textBoxUser.Focus();
            }
        }//hahahhaa

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {

        }
        //jajajaj
    }
}
