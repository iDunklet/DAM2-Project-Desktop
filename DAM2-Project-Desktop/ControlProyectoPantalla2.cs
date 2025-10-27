using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DAM2_Project_Desktop
{
    public partial class ControlProyectoPantalla2 : UserControl
    {
        private Proyecto _proyecto;

        public ControlProyectoPantalla2()
        {
            InitializeComponent();
            pictureBoxImagen.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxImagen.BackColor = Color.LightGray;


        }

        public Proyecto Proyecto
        {
            get { return _proyecto; }
            set
            {
                _proyecto = value;
                ActualizarDatos();
            }
        }

        private void ActualizarDatos()
        {
            if (_proyecto == null)
            {
                labelTitulo.Text = "(sin proyecto)";
                labelMiembros.Text = "miembros: 0";
                labelTareas.Text = "tareas: 0";
                pictureBoxImagen.Image = null;
                pictureBoxImagen.BackColor = Color.LightGray;
                return;
            }

            if (_proyecto.titulo != null)
                labelTitulo.Text = _proyecto.titulo;
            else
                labelTitulo.Text = "(sin título)";

            int numMiembros = 0;
            if (_proyecto.miembrosProyecto != null)
                numMiembros = _proyecto.miembrosProyecto.Count;
            labelMiembros.Text = "miembros: " + numMiembros.ToString();

            int numTareas = 0;
            if (_proyecto.tareasProyecto != null)
                numTareas = _proyecto.tareasProyecto.Count;
            labelTareas.Text = "tareas: " + numTareas.ToString();

            if (_proyecto.ImgProyecto == null)
                _proyecto.ImgProyecto = null;

            pictureBoxImagen.Image = _proyecto.ImgProyecto;
            pictureBoxImagen.Refresh();
        }

        public Image Imagen
        {
            get { return pictureBoxImagen.Image; }
            set
            {
                pictureBoxImagen.Image = value;
                if (value == null)
                    pictureBoxImagen.BackColor = Color.Silver;
                else
                    pictureBoxImagen.BackColor = Color.Transparent;
            }
        }



        private void ControlProyectoPantalla2_Load(object sender, EventArgs e)
        {
            RedondearEsquinas(15);
        }

        private void ControlProyectoPantalla2_Resize(object sender, EventArgs e)
        {
            RedondearEsquinas(15);
        }

        private void RedondearEsquinas(int borderRadius)
        {
            this.Region = Region.FromHrgn(CreateRoundRectRgn(-1, -1, this.Width, this.Height, borderRadius, borderRadius));
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);


      
        private void ControlProyectoPantalla2_Click(object sender, EventArgs e)
        {
            if (_proyecto != null)
            {
                // Crear y mostrar Pantalla3, pasando el proyecto
                //Pantalla3 pantalla3 = new Pantalla3(_proyecto);
                //pantalla3.Show();

              
                this.FindForm()?.Close();
            }
            else
            {
                MessageBox.Show("No hay proyecto seleccionado", "Información",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}