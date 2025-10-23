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
    public partial class ControlProyectoPantalla2 : UserControl
    {
        private Proyecto _proyecto;

        public ControlProyectoPantalla2()
        {
            InitializeComponent();
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
            if (_proyecto == null) return;

            // Actualizar nombre del proyecto
            labelTitulo.Text = _proyecto.titulo;

            // Actualizar número de miembros
            int numMiembros = 0;
            if (_proyecto.miembrosProyecto != null)
            {
                numMiembros = _proyecto.miembrosProyecto.Count;
            }
            labelMiembros.Text = "miembros: " + numMiembros.ToString();

            // Actualizar número de tareas
            int numTareas = 0;
            if (_proyecto.tareasProyecto != null)
            {
                numTareas = _proyecto.tareasProyecto.Count;
            }
            labelTareas.Text = "tareas: " + numTareas.ToString();

            // Actualizar imagen
            if (_proyecto.ImgProyecto != null)
            {
                pictureBoxImagen.Image = _proyecto.ImgProyecto;
                pictureBoxImagen.BackColor = Color.Transparent;
            }
            else
            {
                pictureBoxImagen.Image = null;
                pictureBoxImagen.BackColor = Color.Silver;
            }
        }

        private void ControlProyectoPantalla2_Click(object sender, EventArgs e)
        {
            // Aquí irá el código cuando hagas click
        }

        

       

        public Image Imagen
        {
            get { return pictureBoxImagen.Image; }
            set
            {
                pictureBoxImagen.Image = value;
                if (value == null)
                {
                    pictureBoxImagen.BackColor = Color.Silver;
                }
                else
                {
                    pictureBoxImagen.BackColor = Color.Transparent;
                }
            }
        }
    }
}