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
            ListadoDatosClasses.cargarDatos();
            CrearGraficoEnSplitPanel();
            proyectoActual = project;
            CargarInfoProyecto();
            CargarUsuariosProyecto();

        }

        private void Pantalla4_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Proyecto proyecto = ListadoDatosClasses.ListadoProyectos[0];
        }

        private void AgregarUsuarioAlPanel(Usuario usuario)
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
            // 1️⃣ Crear un panel contenedor
            Panel contenedor = new Panel
            {
                Dock = DockStyle.Fill,              // Ocupa todo el Panel2 del SplitContainer
                Padding = new Padding(50, 30, 50, 100), // Márgenes: izquierda 20, arriba 0, derecha 20, abajo 20
                BackColor = Color.FromArgb(247, 250, 252) // Fondo opcional del contenedor
            };

            // 2️⃣ Crear el gráfico
            var chart = new LiveCharts.WinForms.CartesianChart
            {
                Dock = DockStyle.Fill,              // Ocupa todo el espacio del panel contenedor
                BackColor = Color.FromArgb(247, 250, 252) // Color de fondo del gráfico
            };

            // 3️⃣ Configurar los valores de ejemplo
            var valores = new LiveCharts.ChartValues<double> { 2.7, 3.5, 1.6, 2.8, 2.2, 0.8, 3.0 };

            // 4️⃣ Configurar la serie de columnas
            chart.Series = new LiveCharts.SeriesCollection
            {
                new LiveCharts.Wpf.ColumnSeries
                {
                    Values = valores,
                    Fill = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(79, 209, 197)),
                    StrokeThickness = 0,
                    MaxColumnWidth = 45
            }
            };

            // 5️⃣ Configurar eje X
            chart.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Labels = new[] { "TAREA 1", "TAREA 2", "TAREA 3", "TAREA 4", "TAREA 5", "TAREA 6", "TAREA 7" },
                Separator = new LiveCharts.Wpf.Separator { Step = 1, IsEnabled = false }
            });

            // 6️⃣ Configurar eje Y
            chart.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                MinValue = 0,
                MaxValue = 4.9,
                Labels = new[] { "1 H", "2 H", "3 H", "4 H", "5 H" },
                Separator = new LiveCharts.Wpf.Separator
                {
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 0, 0)),
                    StrokeThickness = 1
                }
            });

            // 7️⃣ Agregar el gráfico al panel contenedor
            contenedor.Controls.Add(chart);

            // 8️⃣ Limpiar el Panel2 del SplitContainer y agregar el contenedor
            splitContainer6.Panel2.Controls.Clear();
            splitContainer6.Panel2.Controls.Add(contenedor);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Si ya existe un combo, lo eliminamos
            if (comboUsuariosDAM2 != null)
            {
                splitContainer4.Panel2.Controls.Remove(comboUsuariosDAM2);
                comboUsuariosDAM2.Dispose();
                comboUsuariosDAM2 = null;
            }

            comboUsuariosDAM2 = new ComboBox();
            comboUsuariosDAM2.DropDownStyle = ComboBoxStyle.DropDownList;

            // Tomar solo los usuarios del proyecto actual
            var usuariosProyecto = proyectoActual.miembrosProyecto;

            comboUsuariosDAM2.DataSource = usuariosProyecto;
            comboUsuariosDAM2.DisplayMember = "nombre";

            // Añadir el combo al panel correspondiente
            splitContainer4.Panel2.Controls.Add(comboUsuariosDAM2);

            // Colocarlo al lado del pictureBox4
            comboUsuariosDAM2.Location = new Point(
                splitContainer4.Panel2.Left,
                pictureBox4.Top - 12
            );

            comboUsuariosDAM2.Width = 160;
            comboUsuariosDAM2.BringToFront();

            // Cuando se selecciona un usuario
            comboUsuariosDAM2.SelectedIndexChanged += (s, ev) =>
            {
                var usuarioSeleccionado = (Usuario)comboUsuariosDAM2.SelectedItem;

                // Comprobar si ya existe en el FlowLayoutPanel
                bool existe = false;
                foreach (Panel panel in flowPanelMiembros.Controls)
                {
                    foreach (Control control in panel.Controls)
                    {
                        if (control is Label lbl && lbl.Text == usuarioSeleccionado.nombre)
                        {
                            existe = true;
                            break;
                        }
                    }
                    if (existe) break;
                }

                if (existe)
                {
                    MessageBox.Show("El usuario ya se encuentra en el panel.", "Aviso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    AgregarUsuarioAlPanel(usuarioSeleccionado);
                }

                // Limpiar el ComboBox
                splitContainer4.Panel2.Controls.Remove(comboUsuariosDAM2);
                comboUsuariosDAM2.Dispose();
                comboUsuariosDAM2 = null;
            };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListadoDatosClasses.guardarDatos();
            Pantalla3 pantalla3 = new Pantalla3(proyectoActual);
            pantalla3.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListadoDatosClasses.guardarDatos();
            //vista actual
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListadoDatosClasses.guardarDatos();
            this.Close();
        }

        private void buttonCrearNuevoUsuario_Click(object sender, EventArgs e)
        {
            ListadoDatosClasses.guardarDatos();
            Pantalla5 pantalla5 = new Pantalla5();
            pantalla5.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
