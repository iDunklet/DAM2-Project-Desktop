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
            int numMiembros = _proyecto.miembrosProyecto?.Count ?? 0;
            labelMiembros.Text = "miembros: " + numMiembros.ToString();

            // Actualizar número de tareas
            int numTareas = _proyecto.tareasProyecto?.Count ?? 0;
            labelTareas.Text = "tareas: " + numTareas.ToString();

            // DEBUG: Verificar si la imagen se está generando
            bool tieneImagen = _proyecto.ImgProyecto != null;
            System.Diagnostics.Debug.WriteLine($"Proyecto: {_proyecto.titulo}, Imagen generada: {tieneImagen}");

            // Actualizar imagen
            pictureBoxImagen.Image = _proyecto.ImgProyecto;

            // Forzar refresco visual
            pictureBoxImagen.Refresh();
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