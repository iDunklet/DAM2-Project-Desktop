using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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

        private void controlProyectoPantalla21_Load(object sender, EventArgs e)
        {

        }

        private void buttonExportarJson_Click(object sender, EventArgs e)
        {
            string rutaArchivo = @"D:\Tasky_Desktop\DAM2-Project-Desktop\DAM2-Project-Desktop\Data\Exports";
            Directory.CreateDirectory(rutaArchivo);
            string rutaCompletaArchivo = Path.Combine(rutaArchivo, "JSON_PRUEBA.json");

            var proyectosList = ListadoDatosClasses.ListadoProyectos;
            JArray Proyectos = (JArray)JToken.FromObject(proyectosList);

            File.WriteAllText(rutaCompletaArchivo, Proyectos.ToString());
            Console.WriteLine("Exportación a JSON completada con éxito.");
            Console.WriteLine($"Datos exportados con éxito a {rutaArchivo}");
        }
    }
}
