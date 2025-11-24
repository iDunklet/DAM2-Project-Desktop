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
//using System.Windows.Forms.DataVisualization.Charting;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DAM2_Project_Desktop
{
    public partial class Pantalla7 : Form
    {
        private Usuario usuarioEncontrado;
        private Size originalSize;

        // Rectángulos de la Barra Lateral (Botones)
        private Rectangle RectanglebuttonInicio;
        private Rectangle RectanglebuttonProyectosPrivados;
        private Rectangle RectanglebuttonUsuarios;
        private Rectangle RectanglebuttonImportarJSON;
        private Rectangle RectanglebuttonExportarJSON;
        private Rectangle Rectanglebutton7;

        // Rectángulos del Área de Contenido Principal
        private Rectangle Rectanglelabel10;
        private Rectangle RectanglepictureBoxImgPerfil;
        private Rectangle Rectanglelabel1;
        private Rectangle RectangletextBoxConfigurarUsuarioName;
        private Rectangle Rectanglelabel2;
        private Rectangle RectangletextBoxConfigurarUsuarioApellido1;
        private Rectangle Rectanglelabel3;
        private Rectangle RectangletextBoxConfigurarUsuarioApellido2;
        private Rectangle Rectanglelabel4;
        private Rectangle RectangledateTimePickerConfigurarUsuarioFechaNacimiento;
        private Rectangle Rectanglelabel5;
        private Rectangle RectangletextBoxConfigurarUsuarioEmail;
        private Rectangle Rectanglelabel6;
        private Rectangle RectangletextBoxConfigurarUsuarioClase;
        private Rectangle Rectanglelabel7;
        private Rectangle Rectanglelabel9;
        private Rectangle RectangletextBoxConfigurarUsuarioNuevaContrasena;
        private Rectangle Rectanglelabel8;
        private Rectangle RectangletextBoxConfigurarUsuarioConfirmarContrasena;
        private Rectangle RectanglebuttonConfigurarUsuarioGuardar;
        private Rectangle RectanglepictureBoxTasky;

        public Pantalla7(Usuario usuarioEncontrado)
        {
            InitializeComponent();
            this.usuarioEncontrado = usuarioEncontrado;

            // Inicialización de datos de usuario...
            textBoxConfigurarUsuarioName.Text = usuarioEncontrado.nombre;
            textBoxConfigurarUsuarioApellido1.Text = usuarioEncontrado.apellido1;
            textBoxConfigurarUsuarioApellido2.Text = usuarioEncontrado.apellido2;
            textBoxConfigurarUsuarioClase.Text = usuarioEncontrado.classe;
            textBoxConfigurarUsuarioEmail.Text = usuarioEncontrado.email;
            pictureBoxImgPerfil.Image = usuarioEncontrado.imgPerfil;




            ActivarEdicionPorDobleClick();
            Dimencions.ApplyMinimum(this);
            this.Resize += Pantalla7_Resize;

            originalSize = this.Size;
            InitializeOriginalRectangles();
            Pantalla7_Resize(null, null);
        }

        private void Pantalla7_Resize(object sender, EventArgs e)
        {
            Size formOriginalSize = this.originalSize;


            const int ORIGINAL_SPLITTER_DISTANCE = 93;
            const int DESIGN_HEIGHT_BASE = 1100;

            Dimencions.ScaleAndCenterHeader(
                pictureBoxTasky,
                splitContainer1,
                ORIGINAL_SPLITTER_DISTANCE,
                this,
                DESIGN_HEIGHT_BASE);


            Dimencions.ResizeControl(buttonConfigurarUsuarioGuardar, RectanglebuttonConfigurarUsuarioGuardar, this, formOriginalSize);
            Dimencions.ResizeControl(textBoxConfigurarUsuarioConfirmarContrasena, RectangletextBoxConfigurarUsuarioConfirmarContrasena, this, formOriginalSize);
            Dimencions.ResizeControl(label8, Rectanglelabel8, this, formOriginalSize);
            Dimencions.ResizeControl(textBoxConfigurarUsuarioNuevaContrasena, RectangletextBoxConfigurarUsuarioNuevaContrasena, this, formOriginalSize);
            Dimencions.ResizeControl(label9, Rectanglelabel9, this, formOriginalSize);
            Dimencions.ResizeControl(label7, Rectanglelabel7, this, formOriginalSize);
            Dimencions.ResizeControl(textBoxConfigurarUsuarioClase, RectangletextBoxConfigurarUsuarioClase, this, formOriginalSize);
            Dimencions.ResizeControl(label6, Rectanglelabel6, this, formOriginalSize);
            Dimencions.ResizeControl(textBoxConfigurarUsuarioEmail, RectangletextBoxConfigurarUsuarioEmail, this, formOriginalSize);
            Dimencions.ResizeControl(label5, Rectanglelabel5, this, formOriginalSize);
            Dimencions.ResizeControl(dateTimePickerConfigurarUsuarioFechaNacimiento, RectangledateTimePickerConfigurarUsuarioFechaNacimiento, this, formOriginalSize);
            Dimencions.ResizeControl(label4, Rectanglelabel4, this, formOriginalSize);
            Dimencions.ResizeControl(textBoxConfigurarUsuarioApellido2, RectangletextBoxConfigurarUsuarioApellido2, this, formOriginalSize);
            Dimencions.ResizeControl(label3, Rectanglelabel3, this, formOriginalSize);
            Dimencions.ResizeControl(textBoxConfigurarUsuarioApellido1, RectangletextBoxConfigurarUsuarioApellido1, this, formOriginalSize);
            Dimencions.ResizeControl(label2, Rectanglelabel2, this, formOriginalSize);
            Dimencions.ResizeControl(textBoxConfigurarUsuarioName, RectangletextBoxConfigurarUsuarioName, this, formOriginalSize);
            Dimencions.ResizeControl(label1, Rectanglelabel1, this, formOriginalSize);
            Dimencions.ResizeControl(pictureBoxImgPerfil, RectanglepictureBoxImgPerfil, this, formOriginalSize);
            Dimencions.ResizeControl(label10, Rectanglelabel10, this, formOriginalSize);

            // Escalado de los botones laterales.
            ResizeBotonesLaterales();
        }

        private void ResizeBotonesLaterales()
        {
            Control[] sidebarButtons = { buttonInicio, buttonProyectosPrivados, buttonUsuarios, buttonImportarJSON, buttonExportarJSON, button7 };
            Rectangle[] originalRects = { RectanglebuttonInicio, RectanglebuttonProyectosPrivados, RectanglebuttonUsuarios, RectanglebuttonImportarJSON, RectanglebuttonExportarJSON, Rectanglebutton7 };

            int sidebarPanelWidth = splitContainer2.Panel1.ClientSize.Width;

            // Delega la lógica de centrado y escalado Y a la clase estática.
            Dimencions.ResizeSidebarButtons(sidebarButtons, originalRects, sidebarPanelWidth, this);
        }

        // Método para inicializar los rectángulos originales con la posición y tamaño de diseño.
        private void InitializeOriginalRectangles()
        {

            // Área de Contenido Principal (Datos) - Inicialización de rectángulos...
            Rectanglelabel10 = new Rectangle(label10.Location, label10.Size);
            RectanglepictureBoxImgPerfil = new Rectangle(pictureBoxImgPerfil.Location, pictureBoxImgPerfil.Size);
            Rectanglelabel1 = new Rectangle(label1.Location, label1.Size);
            RectangletextBoxConfigurarUsuarioName = new Rectangle(textBoxConfigurarUsuarioName.Location, textBoxConfigurarUsuarioName.Size);
            Rectanglelabel2 = new Rectangle(label2.Location, label2.Size);
            RectangletextBoxConfigurarUsuarioApellido1 = new Rectangle(textBoxConfigurarUsuarioApellido1.Location, textBoxConfigurarUsuarioApellido1.Size);
            Rectanglelabel3 = new Rectangle(label3.Location, label3.Size);
            RectangletextBoxConfigurarUsuarioApellido2 = new Rectangle(textBoxConfigurarUsuarioApellido2.Location, textBoxConfigurarUsuarioApellido2.Size);
            RectangledateTimePickerConfigurarUsuarioFechaNacimiento = new Rectangle(dateTimePickerConfigurarUsuarioFechaNacimiento.Location, dateTimePickerConfigurarUsuarioFechaNacimiento.Size);
            Rectanglelabel4 = new Rectangle(label4.Location, label4.Size);
            Rectanglelabel5 = new Rectangle(label5.Location, label5.Size);
            RectangletextBoxConfigurarUsuarioEmail = new Rectangle(textBoxConfigurarUsuarioEmail.Location, textBoxConfigurarUsuarioEmail.Size);
            Rectanglelabel6 = new Rectangle(label6.Location, label6.Size);
            RectangletextBoxConfigurarUsuarioClase = new Rectangle(textBoxConfigurarUsuarioClase.Location, textBoxConfigurarUsuarioClase.Size);
            Rectanglelabel7 = new Rectangle(label7.Location, label7.Size);
            Rectanglelabel9 = new Rectangle(label9.Location, label9.Size);
            RectangletextBoxConfigurarUsuarioNuevaContrasena = new Rectangle(textBoxConfigurarUsuarioNuevaContrasena.Location, textBoxConfigurarUsuarioNuevaContrasena.Size);
            Rectanglelabel8 = new Rectangle(label8.Location, label8.Size);
            RectangletextBoxConfigurarUsuarioConfirmarContrasena = new Rectangle(textBoxConfigurarUsuarioConfirmarContrasena.Location, textBoxConfigurarUsuarioConfirmarContrasena.Size);
            RectanglebuttonConfigurarUsuarioGuardar = new Rectangle(buttonConfigurarUsuarioGuardar.Location, buttonConfigurarUsuarioGuardar.Size);


            // Barra Lateral (Botones) - Usamos las coordenadas del diseñador.
            Size baseSize = new Size(200, 60);

            RectanglebuttonInicio = new Rectangle(new Point(21, 12), baseSize);
            RectanglebuttonProyectosPrivados = new Rectangle(new Point(21, 78), baseSize);
            RectanglebuttonUsuarios = new Rectangle(new Point(21, 144), baseSize);
            RectanglebuttonImportarJSON = new Rectangle(new Point(21, 210), baseSize);
            RectanglebuttonExportarJSON = new Rectangle(new Point(21, 276), baseSize);
            // button7 está en una posición Y alta.
            Rectanglebutton7 = new Rectangle(new Point(24, 1072), baseSize);
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
        private void buttonConfigurarUsuarioGuardar_Click(object sender, EventArgs e)
        {
            // Validar contraseñas
            string nuevaContrasena = textBoxConfigurarUsuarioNuevaContrasena.Text;
            string confirmarContrasena = textBoxConfigurarUsuarioConfirmarContrasena.Text;

            if (!string.IsNullOrWhiteSpace(nuevaContrasena) ||
                !string.IsNullOrWhiteSpace(confirmarContrasena))
            {
                if (!nuevaContrasena.Equals(confirmarContrasena))
                {
                    MessageBox.Show("Las contraseñas no coinciden.");
                    return;
                }

                usuarioEncontrado.password = nuevaContrasena;
            }

            // Actualizar campos del usuario
            usuarioEncontrado.nombre = textBoxConfigurarUsuarioName.Text;
            usuarioEncontrado.apellido1 = textBoxConfigurarUsuarioApellido1.Text;
            usuarioEncontrado.apellido2 = textBoxConfigurarUsuarioApellido2.Text;
            usuarioEncontrado.email = textBoxConfigurarUsuarioEmail.Text;
            usuarioEncontrado.classe = textBoxConfigurarUsuarioClase.Text;
            usuarioEncontrado.fechaNacimiento = dateTimePickerConfigurarUsuarioFechaNacimiento.Value;


            // Limpiar campos de contraseña
            textBoxConfigurarUsuarioNuevaContrasena.Clear();
            textBoxConfigurarUsuarioConfirmarContrasena.Clear();

            //guardado en JSON
            ListadoDatosClasses.exportUsers();

            MessageBox.Show("Cambios guardados correctamente.");

            // Cerrar la pantalla de edición
            this.Close();
        }
    }
}
