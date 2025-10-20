using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAM2_Project_Desktop
{
    public partial class Pantalla1 : Form
    {
        public Pantalla1()
        {
            InitializeComponent();

            ButtonLogin.FlatStyle = FlatStyle.Flat;
            ButtonLogin.FlatAppearance.BorderSize = 1;

            pictureBox3.Image = Properties.Resources.back;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;


            pictureBox3.Paint += pictureBox3_Paint;
        }

        private void pictureBox3_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString(
                "Welcome",
                new Font("Montserrat", 60, FontStyle.Bold | FontStyle.Italic),
                Brushes.White,
                new PointF(150, 360));
            e.Graphics.DrawString(
                "Sign in to continue",
                new Font("Montserrat", 15, FontStyle.Italic),
                Brushes.White,
                new PointF(180, 480));

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            
            string correctUsername = "admin";
            string correctPassword = "123456";

            if (username == correctUsername & password == correctPassword) 
            {
                MessageBox.Show("correct")
        }
    }
}

