using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAM2_Project_Desktop
{
    public partial class Tasky : Form
    {
        public Tasky()
        {
            InitializeComponent();
            ActivarEdicionPorDobleClick();
            Dimencions.ApplyMinimum(this);
            this.Resize += Pantalla7_Resize;
        }

        private void Pantalla7_Resize(object sender, EventArgs e)
        {

            button1.Size = Dimencions.Scale(new Size(200, 60), this.ClientSize);
            button2.Size = Dimencions.Scale(new Size(200, 60), this.ClientSize);
            button3.Size = Dimencions.Scale(new Size(200, 60), this.ClientSize);
            button4.Size = Dimencions.Scale(new Size(200, 60), this.ClientSize);
            button5.Size = Dimencions.Scale(new Size(200, 60), this.ClientSize);
            button6.Size = Dimencions.Scale(new Size(200, 60), this.ClientSize);
            button7.Size = Dimencions.Scale(new Size(200, 60), this.ClientSize);

        }

        private void ActivarEdicionPorDobleClick()
        {

            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.ReadOnly = true;
                    textBox.DoubleClick += TextBox_DoubleClick;
                    textBox.Leave += TextBox_Leave;
                }
            }
        }
        private void TextBox_DoubleClick(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                textBox.ReadOnly = false;
                textBox.BorderStyle = BorderStyle.Fixed3D;
                textBox.Focus();
                textBox.SelectAll();
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                textBox.ReadOnly = true;
                textBox.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }


        private void textBoxConfigurarUsuarioName_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
