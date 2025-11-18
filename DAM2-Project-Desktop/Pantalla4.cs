using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf; // Algunas clases vienen de aquí, necesario para Series y ChartValues

namespace DAM2_Project_Desktop
{
    
    public partial class Pantalla4 : Form
    {
        private ComboBox comboUsuariosDAM2;
        private Proyecto proyectoActual;
        public Pantalla4(Proyecto project)
        {
            InitializeComponent();
            CrearGraficoEnSplitPanel();
            proyectoActual = project;
            CargarInfoProyecto();
            CargarUsuariosProyecto();
            
        }

        private void Pantalla4_Load(object sender, EventArgs e)
        {
            Proyecto proyecto = ListadoDatosClasses.ListadoProyectos[0];
        }

        private void splitContainer6_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AgregarUsuarioAlPanel(Usuarios usuario)
        {
            // Crear contenedor visual para cada usuario
            Panel panelUsuario = new Panel();
            panelUsuario.Width = 90;
            panelUsuario.Height = 120;
            panelUsuario.Margin = new Padding(0, 0, 10, 0);

            // Imagen (usamos la mini o la grande)
            PictureBox pic = new PictureBox();
            pic.Image = usuario.imgPerfil; // O miniImgPerfil si prefieres pequeño
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Width = 55;
            pic.Height = 55;
            pic.Location = new Point((panelUsuario.Width - pic.Width) / 2, 0);

            // Nombre debajo de la imagen
            Label lbl = new Label();
            lbl.Text = usuario.nombre;
            lbl.Font = new Font("Microsoft Sans Serif", 10F);
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.AutoSize = false;
            lbl.Width = 80;
            lbl.Height = 20;
            lbl.Location = new Point((panelUsuario.Width - lbl.Width) / 2, pic.Height + 3);

            // Agregar al panel
            panelUsuario.Controls.Add(pic);
            panelUsuario.Controls.Add(lbl);

            // Agregar al FlowLayoutPanel del formulario
            flowPanelMiembros.Controls.Add(panelUsuario);
        }

        private void CargarInfoProyecto()
        {
            if (proyectoActual == null) return;

            // Suponiendo que tienes Labels dentro de cada SplitContainer:
            labelId.Text = proyectoActual.ID.ToString(); // Id del proyecto
            labelNombreProyecto.Text = proyectoActual.titulo; // Nombre
            labelFechaProyecto.Text = proyectoActual.fechaEntrega.ToString("dd/MM/yyyy"); // Fecha

            // Centrar texto (opcional)
            labelId.TextAlign = ContentAlignment.MiddleCenter;
            labelNombreProyecto.TextAlign = ContentAlignment.MiddleCenter;
            labelFechaProyecto.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void CargarUsuariosProyecto()
        {
            flowPanelMiembros.Controls.Clear(); // Limpiamos antes de cargar

            foreach (var usuario in proyectoActual.miembrosProyecto)
            {
                // Creamos un panel individual para cada usuario
                Panel panelUsuario = new Panel();
                panelUsuario.Width = 90;
                panelUsuario.Height = 120;
                panelUsuario.Margin = new Padding(0, 0, 10, 0);

                // PictureBox con la imagen del usuario
                PictureBox pic = new PictureBox();
                pic.Image = usuario.imgPerfil; // Usamos la imagen generada
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.Width = 55;
                pic.Height = 55;
                pic.Location = new Point((panelUsuario.Width - pic.Width) / 2, 0);

                // Label con el nombre del usuario
                Label lbl = new Label();
                lbl.Text = usuario.nombre;
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.AutoSize = false;
                lbl.Width = 80;
                lbl.Height = 20;
                lbl.Location = new Point((panelUsuario.Width - lbl.Width) / 2, pic.Height + 3);

                // Añadimos PictureBox y Label al panel del usuario
                panelUsuario.Controls.Add(pic);
                panelUsuario.Controls.Add(lbl);

                // Añadimos el panel al FlowLayoutPanel de miembros
                flowPanelMiembros.Controls.Add(panelUsuario);
            }
        }

        private void CrearGraficoEnSplitPanel()
        {
            var chart = new LiveCharts.WinForms.CartesianChart
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };

            // Valores como en la imagen (puedes ajustarlos)
            var valores = new LiveCharts.ChartValues<double>
    {
        2.7, // Lunes
        3.5, // Martes
        1.6, // Miércoles
        2.8, // Jueves
        2.2, // Viernes
        0.8, // Sábado
        3.0  // Domingo
    };

            chart.Series = new LiveCharts.SeriesCollection
    {
        new LiveCharts.Wpf.ColumnSeries
        {
            Values = valores,
            Fill = new System.Windows.Media.SolidColorBrush(
                System.Windows.Media.Color.FromRgb(210, 210, 210) // gris claro
            ),
            StrokeThickness = 0,
            MaxColumnWidth = 45
        }
    };

            // EJE X — Días de la semana
            chart.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Labels = new[]
                {
            "LUNES", "MARTES", "MIÉRCOLES", "JUEVES",
            "VIERNES", "SÁBADO", "DOMINGO"
        },
                Separator = new LiveCharts.Wpf.Separator
                {
                    Step = 1,
                    IsEnabled = false
                }
            });

            // EJE Y — Horas (1H–5H)
            chart.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                MinValue = 0,
                MaxValue = 5,
                Separator = new LiveCharts.Wpf.Separator
                {
                    Stroke = new System.Windows.Media.SolidColorBrush(
                        System.Windows.Media.Color.FromRgb(0, 0, 0)
                    ),
                    StrokeThickness = 1
                },
                Labels = new[] { "1 H", "2 H", "3 H", "4 H", "5 H" }
            });

            // Agregar al SplitContainer
            splitContainer6.Panel2.Controls.Clear();
            splitContainer6.Panel2.Controls.Add(chart);
        }

    }
}
