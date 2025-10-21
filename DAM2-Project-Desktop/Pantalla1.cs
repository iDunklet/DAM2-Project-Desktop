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

            Button1.FlatStyle = FlatStyle.Flat;
            Button1.FlatAppearance.BorderSize = 1;

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
            string username = textBoxUser.Text.Trim();
            string password = textBoxPass.Text.Trim();

            
            string correctUsername = "Tasky";
            string correctPassword = "123456";

            if (username == correctUsername & password == correctPassword) 
            {
                MessageBox.Show("Login successful!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Tasky tasky = new Tasky();
                tasky.Show();
               
                this.Hide();
            }
                else
                {
                MessageBox.Show("Incorrect username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPass.Clear();
                textBoxUser.Clear();
                textBoxUser.Focus(); 
                }
            }

        }
    }


