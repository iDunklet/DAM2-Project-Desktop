using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace DAM2_Project_Desktop
{
    public partial class Pantalla2 : Form
    {

        private Size originalSize;

        // Rectángulos de la Barra Lateral (Botones)
        private Rectangle RectanglebuttonInicio;
        private Rectangle RectanglebuttonProyectosPrivados;
        private Rectangle RectanglebuttonUsuarios;
        private Rectangle RectanglebuttonImportarJSON;
        private Rectangle RectanglebuttonExportarJSON;
        private Rectangle Rectanglebutton7;

        private Rectangle Rectanglelabel1;
        private Rectangle Rectanglelabel2;
        private Rectangle RectangleflowLayoutPanel1;

        private Rectangle RectanglepictureBoxTasky;


        List<Usuarios> listaUsuarios;
        List<Tarea> listaTareas;
        Proyecto proyectoDemo;

        public Pantalla2()
        {
            InitializeComponent();

            Dimencions.ApplyMinimum(this);
            this.Resize += Pantalla2_Resize;

            originalSize = this.Size;
            InitializeOriginalRectangles();
            Pantalla2_Resize(null, null);

        }



        private void Pantalla2_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            var proyectos = ListadoDatosClasses.ListadoProyectos;
            foreach (var proyecto in proyectos)
            {
                ControlProyectoPantalla2 controlProyecto = new ControlProyectoPantalla2();
                controlProyecto.Proyecto = proyecto;
                controlProyecto.Margin = new Padding(10);
                controlProyecto.ProyectoClicado += ControlProyecto_ProyectoClicado;
                flowLayoutPanel1.Controls.Add(controlProyecto);
            }
        }
        private void ControlProyecto_ProyectoClicado(object sender, Proyecto proyectoClicado)
        {
            if (proyectoClicado == null) return;

            Pantalla3 pantalla3 = new Pantalla3(proyectoClicado);
            pantalla3.Show();

        }



        private void Pantalla2_Resize(object sender, EventArgs e)
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

            Dimencions.ResizeControl(label1, Rectanglelabel1, this, formOriginalSize);
            Dimencions.ResizeControl(label2, Rectanglelabel2, this, formOriginalSize);
            Dimencions.ResizeControl(flowLayoutPanel1, RectangleflowLayoutPanel1, this, formOriginalSize);


            ResizeBotonesLaterales();
        }

        private void ResizeBotonesLaterales()
        {
            Control[] sidebarButtons = { buttonInicio, buttonProyectosPrivados, buttonUsuarios, buttonImportarJSON, buttonExportarJSON, button7 };
            Rectangle[] originalRects = { RectanglebuttonInicio, RectanglebuttonProyectosPrivados, RectanglebuttonUsuarios, RectanglebuttonImportarJSON, RectanglebuttonExportarJSON, Rectanglebutton7 };

            int sidebarPanelWidth = splitContainer2.Panel1.ClientSize.Width;

            Dimencions.ResizeSidebarButtons(sidebarButtons, originalRects, sidebarPanelWidth, this);
        }

        private void InitializeOriginalRectangles()
        {
            RectanglepictureBoxTasky = new Rectangle(pictureBoxTasky.Location, pictureBoxTasky.Size);

            // Barra Lateral (Botones) - Usamos las coordenadas del diseñador.
            Size baseSize = new Size(200, 60);

            RectanglebuttonInicio = new Rectangle(new Point(21, 12), baseSize);
            RectanglebuttonProyectosPrivados = new Rectangle(new Point(21, 78), baseSize);
            RectanglebuttonUsuarios = new Rectangle(new Point(21, 144), baseSize);
            RectanglebuttonImportarJSON = new Rectangle(new Point(21, 210), baseSize);
            RectanglebuttonExportarJSON = new Rectangle(new Point(21, 276), baseSize);
            // button7 está en una posición Y alta.
            Rectanglebutton7 = new Rectangle(new Point(24, 1072), baseSize);

            Rectanglelabel1 = new Rectangle(label1.Location, label1.Size);
            Rectanglelabel2 = new Rectangle(label2.Location, label2.Size);
            RectangleflowLayoutPanel1 = new Rectangle(flowLayoutPanel1.Location, flowLayoutPanel1.Size);

            RectanglebuttonInicio = new Rectangle(new Point(21, 12), baseSize);
        }


        private void buttonExportarJson_Click(object sender, EventArgs e)
        {
   
            ListadoDatosClasses.exportProjects();

            ListadoDatosClasses.GenerarListaUsuarios();
            ListadoDatosClasses.exportUsers();
        }
        private void buttonImportarJSON_Click(object sender, EventArgs e)
        {
            string rutaArchivo = @"D:\Tasky_Desktop\DAM2-Project-Desktop\DAM2-Project-Desktop\Data\Imports";
            Directory.CreateDirectory(rutaArchivo);
            string rutaCompletaArchivo = Path.Combine(rutaArchivo, "JSON_Import.json");

            JArray proyectosImport = JArray.Parse(File.ReadAllText(rutaCompletaArchivo, Encoding.Default));
            var importData = proyectosImport.ToObject<List<Proyecto>>();

            foreach (var proyecto in importData)
            {
                ListadoDatosClasses.ListadoProyectos.Add(proyecto);
            }

            Console.WriteLine("Importacion de JSON completada con éxito.");
            Console.WriteLine($"Datos Importados con éxito a {rutaArchivo}");
        }

        private void buttonUsuarios_Click(object sender, EventArgs e)
        {
            Pantalla8 pantalla8 = new Pantalla8();
            pantalla8.Show();
        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            Pantalla2 pantalla2 = new Pantalla2();
            pantalla2.Show();
        }

        private void buttonCrearProyecto_Click(object sender, EventArgs e)
        {
            /*
            Pantalla6 pantalla6 = new Pantalla6();
            pantalla6.Show();
            */
        }
    }
}
