using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DAM2_Project_Desktop
{
    public partial class Pantalla2 : Form
    {
        List<Usuarios> listaUsuarios;
        List<Tarea> listaTareas;
        Proyecto proyectoDemo;
        public Pantalla2()
        {
            InitializeComponent();


        }

        private void Pantalla2_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            var proyectos = ListadoDatosClasses.ListadoProyectos;
            foreach (var proyecto in proyectos)
            {
                ControlProyectoPantalla2 controlProyecto = new ControlProyectoPantalla2();
                controlProyecto.Proyecto = proyecto;
                flowLayoutPanel1.Controls.Add(controlProyecto);
            }
        }

        private void buttonImportarJson_Click(object sender, EventArgs e)
        {

        }
    }
}
