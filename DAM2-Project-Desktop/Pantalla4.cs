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
using LiveCharts.Wpf;

namespace DAM2_Project_Desktop
{
    public partial class Pantalla4 : Form
    {
        private ComboBox comboUsuariosDAM2;
        private Proyecto proyectoActual;
        private Usuario usuarioFiltrado = null; // Usuario actualmente seleccionado para filtrar
        private Panel panelUsuarioSeleccionado = null; // Panel del usuario seleccionado


        public Pantalla4(Proyecto project)
        {
            InitializeComponent();
            proyectoActual = project;

            ListadoDatosClasses.cargarDatos();

            CargarInfoProyecto();
            CargarUsuariosProyecto();
            CrearGraficoEnSplitPanel();
        }

        private void Pantalla4_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        #region Gestión de Usuarios

        private void AgregarUsuarioAlPanel(Usuario usuario)
        {
            // Crear contenedor visual para cada usuario
            Panel panelUsuario = new Panel();
            panelUsuario.Width = 90;
            panelUsuario.Height = 120;
            panelUsuario.Margin = new Padding(0, 0, 10, 0);
            panelUsuario.Cursor = Cursors.Hand; // Indicar que es clickeable
            panelUsuario.Tag = usuario; // Guardar referencia al usuario

            // Imagen
            PictureBox pic = new PictureBox();
            pic.Image = usuario.imgPerfil;
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Width = 55;
            pic.Height = 55;
            pic.Location = new Point((panelUsuario.Width - pic.Width) / 2, 0);
            pic.Tag = usuario; // También en la imagen

            // Nombre debajo de la imagen
            Label lbl = new Label();
            lbl.Text = usuario.nombre;
            lbl.Font = new Font("Microsoft Sans Serif", 10F);
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.AutoSize = false;
            lbl.Width = 80;
            lbl.Height = 20;
            lbl.Location = new Point((panelUsuario.Width - lbl.Width) / 2, pic.Height + 3);
            lbl.Tag = usuario;

            // Eventos de clic para todos los controles
            panelUsuario.Click += PanelUsuario_Click;
            pic.Click += PanelUsuario_Click;
            lbl.Click += PanelUsuario_Click;

            // Agregar controles
            panelUsuario.Controls.Add(pic);
            panelUsuario.Controls.Add(lbl);

            // Agregar al FlowLayoutPanel del formulario
            flowPanelMiembros.Controls.Add(panelUsuario);
        }

        private void PanelUsuario_Click(object sender, EventArgs e)
        {
            // Obtener el usuario desde el Tag
            Usuario usuario = null;
            Panel panelClickeado = null;

            if (sender is Panel panel)
            {
                usuario = panel.Tag as Usuario;
                panelClickeado = panel;
            }
            else if (sender is PictureBox || sender is Label)
            {
                Control control = (Control)sender;
                usuario = control.Tag as Usuario;
                panelClickeado = control.Parent as Panel;
            }

            if (usuario == null || panelClickeado == null) return;

            // Si ya está seleccionado, deseleccionar (quitar filtro)
            if (usuarioFiltrado != null && usuarioFiltrado.nombre == usuario.nombre)
            {
                DesseleccionarUsuario();
                usuarioFiltrado = null;
                panelUsuarioSeleccionado = null;

                // Recargar gráfico sin filtro
                CrearGraficoEnSplitPanel();
            }
            else
            {
                // Deseleccionar anterior si existe
                if (panelUsuarioSeleccionado != null)
                {
                    DesseleccionarUsuario();
                }

                // Seleccionar nuevo usuario
                usuarioFiltrado = usuario;
                panelUsuarioSeleccionado = panelClickeado;
                SeleccionarUsuario(panelClickeado);

                // Recargar gráfico con filtro
                CrearGraficoEnSplitPanel();
            }
        }

        private void SeleccionarUsuario(Panel panel)
        {
            // Aplicar estilo de selección
            panel.BackColor = Color.FromArgb(79, 209, 197); // Color turquesa
            panel.Padding = new Padding(3);

            // Cambiar color del borde visualmente
            foreach (Control control in panel.Controls)
            {
                if (control is Label lbl)
                {
                    lbl.Font = new Font(lbl.Font, FontStyle.Bold);
                }
            }
        }

        private void DesseleccionarUsuario()
        {
            if (panelUsuarioSeleccionado != null)
            {
                // Restaurar estilo normal
                panelUsuarioSeleccionado.BackColor = Color.Transparent;
                panelUsuarioSeleccionado.Padding = new Padding(0);

                foreach (Control control in panelUsuarioSeleccionado.Controls)
                {
                    if (control is Label lbl)
                    {
                        lbl.Font = new Font(lbl.Font, FontStyle.Regular);
                    }
                }
            }
        }

        private void CargarInfoProyecto()
        {
            if (proyectoActual == null) return;

            labelId.Text = proyectoActual.ID.ToString();
            labelNombreProyecto.Text = proyectoActual.titulo;
            labelFechaProyecto.Text = proyectoActual.fechaEntrega.ToString("dd/MM/yyyy");

            labelId.TextAlign = ContentAlignment.MiddleCenter;
            labelNombreProyecto.TextAlign = ContentAlignment.MiddleCenter;
            labelFechaProyecto.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void CargarUsuariosProyecto()
        {
            flowPanelMiembros.Controls.Clear();

            if (proyectoActual.miembrosProyecto == null)
                proyectoActual.miembrosProyecto = new List<Usuario>();

            foreach (var usuario in proyectoActual.miembrosProyecto)
            {
                Panel panelUsuario = new Panel();
                panelUsuario.Width = 90;
                panelUsuario.Height = 120;
                panelUsuario.Margin = new Padding(0, 0, 10, 0);
                panelUsuario.Cursor = Cursors.Hand;
                panelUsuario.Tag = usuario;

                PictureBox pic = new PictureBox();
                pic.Image = usuario.imgPerfil;
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.Width = 55;
                pic.Height = 55;
                pic.Location = new Point((panelUsuario.Width - pic.Width) / 2, 0);
                pic.Tag = usuario;

                Label lbl = new Label();
                lbl.Text = usuario.nombre;
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.AutoSize = false;
                lbl.Width = 80;
                lbl.Height = 20;
                lbl.Location = new Point((panelUsuario.Width - lbl.Width) / 2, pic.Height + 3);
                lbl.Tag = usuario;

                // Eventos de clic
                panelUsuario.Click += PanelUsuario_Click;
                pic.Click += PanelUsuario_Click;
                lbl.Click += PanelUsuario_Click;

                panelUsuario.Controls.Add(pic);
                panelUsuario.Controls.Add(lbl);
                flowPanelMiembros.Controls.Add(panelUsuario);
            }
        }

        #endregion

        #region Gráfico

        private void CrearGraficoEnSplitPanel()
        {
            // Validar que existan tareas
            if (proyectoActual?.tareasProyecto == null || proyectoActual.tareasProyecto.Count == 0)
            {
                MostrarMensajeNoHayDatos();
                return;
            }

            // Obtener tareas filtradas o todas
            List<Tarea> tareasMostrar = ObtenerTareasFiltradas();

            if (tareasMostrar.Count == 0)
            {
                MostrarMensajeNoHayDatos("No hay tareas asignadas a este usuario");
                return;
            }

            // Preparar datos del gráfico
            var nombresTareas = new List<string>();
            var horasTareas = new LiveCharts.ChartValues<double>();

            foreach (var tarea in tareasMostrar)
            {
                // Nombre de la tarea (limitar longitud si es muy largo)
                string nombreTarea = string.IsNullOrEmpty(tarea.nombreTarea)
                    ? "Sin nombre"
                    : (tarea.nombreTarea.Length > 15
                        ? tarea.nombreTarea.Substring(0, 15) + "..."
                        : tarea.nombreTarea);

                nombresTareas.Add(nombreTarea);

                // Horas de la tarea (si es null, usar 0)
                double horas = tarea.horas ?? 0;
                horasTareas.Add(horas);
            }

            // Calcular valor máximo del eje Y dinámicamente
            double maxHoras = horasTareas.Count > 0 ? horasTareas.Max() : 5;
            double maxEjeY = Math.Ceiling(maxHoras / 5.0) * 5; // Redondear a múltiplo de 5
            if (maxEjeY < 5) maxEjeY = 5; // Mínimo 5 horas

            // Crear labels del eje Y
            int numLabels = (int)(maxEjeY / 5) + 1;
            var labelsY = new string[numLabels];
            for (int i = 0; i < numLabels; i++)
            {
                labelsY[i] = $"{i * 5} H";
            }

            // Panel contenedor con márgenes
            Panel contenedor = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(50, 30, 50, 100),
                BackColor = Color.FromArgb(247, 250, 252)
            };

            // Crear el gráfico
            var chart = new LiveCharts.WinForms.CartesianChart
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(247, 250, 252)
            };

            // Configurar la serie de columnas
            chart.Series = new LiveCharts.SeriesCollection
            {
                new LiveCharts.Wpf.ColumnSeries
                {
                    Title = usuarioFiltrado != null ? $"Tareas de {usuarioFiltrado.nombre}" : "Todas las tareas",
                    Values = horasTareas,
                    Fill = new System.Windows.Media.SolidColorBrush(
                        System.Windows.Media.Color.FromRgb(79, 209, 197)
                    ),
                    StrokeThickness = 0,
                    MaxColumnWidth = 45,
                    DataLabels = true, // Mostrar valores encima de las barras
                    LabelPoint = point => $"{point.Y} h"
                }
            };

            // Configurar eje X (nombres de tareas)
            chart.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Tareas",
                Labels = nombresTareas,
                FontSize = 14,
                FontFamily = new System.Windows.Media.FontFamily("Segoe UI"),
                FontWeight = System.Windows.FontWeights.Bold,
                Separator = new LiveCharts.Wpf.Separator { Step = 1, IsEnabled = false }
            });

            // Configurar eje Y (horas)
            chart.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Horas",
                MinValue = 0,
                MaxValue = maxEjeY,
                Labels = labelsY,
                Separator = new LiveCharts.Wpf.Separator
                {
                    Stroke = new System.Windows.Media.SolidColorBrush(
                        System.Windows.Media.Color.FromRgb(200, 200, 200)
                    ),
                    StrokeThickness = 1
                }
            });

            // Leyenda
            chart.LegendLocation = LegendLocation.Top;

            // Agregar gráfico al contenedor
            contenedor.Controls.Add(chart);

            // Limpiar y agregar al SplitContainer
            splitContainer6.Panel2.Controls.Clear();
            splitContainer6.Panel2.Controls.Add(contenedor);
        }

        private List<Tarea> ObtenerTareasFiltradas()
        {
            if (usuarioFiltrado == null)
            {
                // Mostrar todas las tareas
                return proyectoActual.tareasProyecto.ToList();
            }
            else
            {
                // Filtrar por usuario
                return proyectoActual.tareasProyecto
                    .Where(t => t.responsableAsignado != null &&
                               t.responsableAsignado.nombre == usuarioFiltrado.nombre)
                    .ToList();
            }
        }

        private void MostrarMensajeNoHayDatos(string mensaje = "No hay tareas para mostrar")
        {
            splitContainer6.Panel2.Controls.Clear();

            Label lblMensaje = new Label
            {
                Text = mensaje,
                Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold),
                ForeColor = Color.Gray,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };

            splitContainer6.Panel2.Controls.Add(lblMensaje);
        }

        #endregion

        #region Eventos de Botones

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (comboUsuariosDAM2 != null)
            {
                splitContainer4.Panel2.Controls.Remove(comboUsuariosDAM2);
                comboUsuariosDAM2.Dispose();
                comboUsuariosDAM2 = null;
            }

            comboUsuariosDAM2 = new ComboBox();
            comboUsuariosDAM2.DropDownStyle = ComboBoxStyle.DropDownList;

            var usuariosProyecto = proyectoActual.miembrosProyecto;
            comboUsuariosDAM2.DataSource = usuariosProyecto;
            comboUsuariosDAM2.DisplayMember = "nombre";

            splitContainer4.Panel2.Controls.Add(comboUsuariosDAM2);

            comboUsuariosDAM2.Location = new Point(
                splitContainer4.Panel2.Left
            );

            comboUsuariosDAM2.Width = 160;
            comboUsuariosDAM2.BringToFront();

            comboUsuariosDAM2.SelectedIndexChanged += (s, ev) =>
            {
                var usuarioSeleccionado = (Usuario)comboUsuariosDAM2.SelectedItem;

                bool existe = false;
                foreach (Panel panel in flowPanelMiembros.Controls)
                {
                    if (panel.Tag is Usuario usr && usr.nombre == usuarioSeleccionado.nombre)
                    {
                        existe = true;
                        break;
                    }
                }

                if (existe)
                {
                    MessageBox.Show("El usuario ya se encuentra en el panel.", "Aviso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    proyectoActual.miembrosProyecto.Add(usuarioSeleccionado);
                    ListadoDatosClasses.guardarDatos();
                    AgregarUsuarioAlPanel(usuarioSeleccionado);
                }

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
            // Vista actual
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListadoDatosClasses.guardarDatos();
            this.Close();
        }

        private void buttonCrearNuevoUsuario_Click(object sender, EventArgs e)
        {
            Pantalla5 pantalla5 = new Pantalla5();
            pantalla5.FormClosed += (s, args) =>
            {
                // Recargar datos después de crear usuario
                ListadoDatosClasses.cargarDatos();

                // Buscar proyecto actualizado
                var proyectoActualizado = ListadoDatosClasses.ListadoProyectos
                    .FirstOrDefault(p => p.ID == proyectoActual.ID);

                if (proyectoActualizado != null)
                    proyectoActual = proyectoActualizado;

                CargarUsuariosProyecto();
                CrearGraficoEnSplitPanel();
            };
            pantalla5.ShowDialog();
        }

        #endregion



        private void buttonOut_Click(object sender, EventArgs e)
        {
            ListadoDatosClasses.guardarDatos();
            Application.Exit();
        }
    }
}