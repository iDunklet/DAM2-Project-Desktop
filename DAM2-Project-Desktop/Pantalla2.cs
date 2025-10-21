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
            RedondearPanel(projectTemplatePanel, 25);

            listaUsuarios = new List<Usuarios>
            {
                new Usuarios("Carlos"),
                new Usuarios("María"),
                new Usuarios("Lucía")
            };

            listaTareas = new List<Tarea> {
                new Tarea("Tarea1"),
                new Tarea("Tarea2"),
                new Tarea("Tarea3")
            };
            proyectoDemo = new Proyecto(
                "Proyecto Demo",
                listaUsuarios,
                listaTareas,
                null
            );
        }



        //Redondear panel
        private void RedondearPanel(Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            panel.Region = new Region(path);
        }



        private void projectTemplatePanel_Click(object sender, EventArgs e)
        {

        }

        private void projectNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void Pantalla2_Load(object sender, EventArgs e)
        {

        }
    }
}
