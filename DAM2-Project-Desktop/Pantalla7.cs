using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace DAM2_Project_Desktop
{
    public partial class Pantalla7 : Form
    {
        private Usuarios usuarioEncontrado;



        public Pantalla7(Usuarios usuarioEncontrado)
        {

            InitializeComponent();
            this.usuarioEncontrado = usuarioEncontrado;
            textBoxConfigurarUsuarioName.Text = usuarioEncontrado.nombre;
            textBoxConfigurarUsuarioApellido1.Text = usuarioEncontrado.apellido1;
            textBoxConfigurarUsuarioApellido2.Text = usuarioEncontrado.apellido2;
            textBoxConfigurarUsuarioClase.Text = usuarioEncontrado.classe;
            textBoxConfigurarUsuarioEmail.Text = usuarioEncontrado.email;
            pictureBoxImgPerfil.Image = usuarioEncontrado.imgPerfil;

            ActivarEdicionPorDobleClick();
            Dimencions.ApplyMinimum(this);
            this.Resize += Pantalla7_Resize;


        }

        private void Pantalla7_Resize(object sender, EventArgs e)
        {
            Size currentSize = this.ClientSize;

            // Use the size of splitContainer2.Panel1 for relative positioning in the sidebar
            Size sidebarSize = splitContainer2.Panel1.ClientSize;

            Size sidebarSize2 = splitContainer1.Panel1.ClientSize;

            // Scale and reposition the buttons in splitContainer2.Panel1
            buttonInicio.Size = Dimencions.Scale(new Size(200, 60), currentSize);
            buttonInicio.Location = Dimencions.Scale(new Point(21, 12), currentSize);

            buttonProyectosPrivados.Size = Dimencions.Scale(new Size(200, 60), currentSize);
            buttonProyectosPrivados.Location = Dimencions.Scale(new Point(21, 78), currentSize);

            buttonUsuarios.Size = Dimencions.Scale(new Size(200, 60), currentSize);
            buttonUsuarios.Location = Dimencions.Scale(new Point(21, 144), currentSize);

            buttonImportarJSON.Size = Dimencions.Scale(new Size(200, 60), currentSize);
            buttonImportarJSON.Location = Dimencions.Scale(new Point(21, 210), currentSize);

            buttonExportarJSON.Size = Dimencions.Scale(new Size(200, 60), currentSize);
            buttonExportarJSON.Location = Dimencions.Scale(new Point(21, 276), currentSize);

            // button7 position update
            button7.Size = Dimencions.Scale(new Size(229, 80), currentSize);
            button7.Location = Dimencions.Scale(new Point(24, 1072), currentSize); // Note: This button is likely off-screen initially

            // --- Main Content (splitContainer2.Panel2) Scaling ---
            // Use the full client size (or the Panel2 size if you want to be more precise)

            // Labels (Position and Font Size for responsiveness)
            label10.Font = Dimencions.ScaleFont(label10.Font, 20f, currentSize);
            label10.Location = Dimencions.Scale(new Point(60, 64), currentSize);

            label1.Font = Dimencions.ScaleFont(label1.Font, 20f, currentSize);
            label1.Location = Dimencions.Scale(new Point(349, 130), currentSize);

            label2.Font = Dimencions.ScaleFont(label2.Font, 20f, currentSize);
            label2.Location = Dimencions.Scale(new Point(790, 130), currentSize);

            label3.Font = Dimencions.ScaleFont(label3.Font, 20f, currentSize);
            label3.Location = Dimencions.Scale(new Point(359, 263), currentSize);

            label4.Font = Dimencions.ScaleFont(label4.Font, 20f, currentSize);
            label4.Location = Dimencions.Scale(new Point(790, 263), currentSize);

            label5.Font = Dimencions.ScaleFont(label5.Font, 20f, currentSize);
            label5.Location = Dimencions.Scale(new Point(359, 407), currentSize);

            label6.Font = Dimencions.ScaleFont(label6.Font, 20f, currentSize);
            label6.Location = Dimencions.Scale(new Point(790, 407), currentSize);

            label7.Font = Dimencions.ScaleFont(label7.Font, 20f, currentSize);
            label7.Location = Dimencions.Scale(new Point(60, 553), currentSize);

            label9.Font = Dimencions.ScaleFont(label9.Font, 20f, currentSize);
            label9.Location = Dimencions.Scale(new Point(106, 627), currentSize);

            label8.Font = Dimencions.ScaleFont(label8.Font, 20f, currentSize);
            label8.Location = Dimencions.Scale(new Point(547, 627), currentSize);


            // PictureBox (Profile Image)
            pictureBoxImgPerfil.Size = Dimencions.Scale(new Size(250, 250), currentSize);
            pictureBoxImgPerfil.Location = Dimencions.Scale(new Point(60, 156), currentSize);

            // TextBoxes and DateTimePicker (Size and Position)

            // Name
            textBoxConfigurarUsuarioName.Size = Dimencions.Scale(new Size(343, 41), currentSize);
            textBoxConfigurarUsuarioName.Location = Dimencions.Scale(new Point(359, 183), currentSize);

            // Apellido 1
            textBoxConfigurarUsuarioApellido1.Size = Dimencions.Scale(new Size(343, 41), currentSize);
            textBoxConfigurarUsuarioApellido1.Location = Dimencions.Scale(new Point(790, 183), currentSize);

            // Apellido 2
            textBoxConfigurarUsuarioApellido2.Size = Dimencions.Scale(new Size(343, 41), currentSize);
            textBoxConfigurarUsuarioApellido2.Location = Dimencions.Scale(new Point(359, 317), currentSize);

            // Fecha Nacimiento
            dateTimePickerConfigurarUsuarioFechaNacimiento.Size = Dimencions.Scale(new Size(342, 41), currentSize);
            dateTimePickerConfigurarUsuarioFechaNacimiento.Location = Dimencions.Scale(new Point(790, 317), currentSize);

            // Email
            textBoxConfigurarUsuarioEmail.Size = Dimencions.Scale(new Size(343, 41), currentSize);
            textBoxConfigurarUsuarioEmail.Location = Dimencions.Scale(new Point(359, 461), currentSize);

            // Clase
            textBoxConfigurarUsuarioClase.Size = Dimencions.Scale(new Size(343, 41), currentSize);
            textBoxConfigurarUsuarioClase.Location = Dimencions.Scale(new Point(790, 461), currentSize);

            // New Password
            textBoxConfigurarUsuarioNuevaContrasena.Size = Dimencions.Scale(new Size(300, 41), currentSize);
            textBoxConfigurarUsuarioNuevaContrasena.Location = Dimencions.Scale(new Point(107, 686), currentSize);

            // Confirm Password
            textBoxConfigurarUsuarioConfirmarContrasena.Size = Dimencions.Scale(new Size(300, 41), currentSize);
            textBoxConfigurarUsuarioConfirmarContrasena.Location = Dimencions.Scale(new Point(557, 686), currentSize);

            // Save Button
            buttonConfigurarUsuarioGuardar.Font = Dimencions.ScaleFont(buttonConfigurarUsuarioGuardar.Font, 18f, currentSize);
            buttonConfigurarUsuarioGuardar.Size = Dimencions.Scale(new Size(232, 68), currentSize);
            buttonConfigurarUsuarioGuardar.Location = Dimencions.Scale(new Point(401, 773), currentSize);

            // PictureBoxTasky (Header)
            pictureBoxTasky.Size = Dimencions.Scale(new Size(300, 94), sidebarSize2);
            pictureBoxTasky.Location = Dimencions.Scale(new Point(-1, -1), currentSize);
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

        private void buttonConfigurarUsuarioGuardar_Click(object sender, EventArgs e)
        {
            string nuevaContrasena = textBoxConfigurarUsuarioNuevaContrasena.Text;
            string confirmarContrasena = textBoxConfigurarUsuarioConfirmarContrasena.Text;
            if (nuevaContrasena.Equals(confirmarContrasena))
            {
                usuarioEncontrado.password = nuevaContrasena;

                textBoxConfigurarUsuarioNuevaContrasena.Clear();
                textBoxConfigurarUsuarioConfirmarContrasena.Clear();
                textBoxConfigurarUsuarioNuevaContrasena.Focus();
            }
        }

        private void buttonConfigurarUsuarioNuevaIMG_Click(object sender, EventArgs e)
        {

        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
