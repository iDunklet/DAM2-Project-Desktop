using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace DAM2_Project_Desktop
{
    public partial class Pantalla6 : Form
    {
        // Lista interna para los usuarios del proyecto
        private BindingList<Usuario> usuariosProyecto = new BindingList<Usuario>();

        private Size originalSize;

        // Rectángulos del contenido principal
        private Rectangle rectTextBoxNombreUsuario;
        private Rectangle rectListBoxUsuarios;
        private Rectangle rectListBoxUsuariosProyecto;
        private Rectangle rectTextBoxNombreProyecto;
        private Rectangle rectDatePicker;
        private Rectangle rectButtonAgregar;
        private Rectangle rectButtonBorrar;
        private Rectangle rectButtonCrear;
        private Rectangle rectLinea;

        // Rectángulos de botones laterales
        private Rectangle rectButtonInicio;
        private Rectangle rectButtonProyectos;
        private Rectangle rectButtonUsuarios;
        private Rectangle rectButtonImportar;
        private Rectangle rectButtonExportar;
        private Rectangle rectButtonCrearUser;
        private Rectangle rectButton7;

        public Pantalla6()
        {
            InitializeComponent();

            this.Load += Pantalla6_Load;
            this.Resize += Pantalla6_Resize;

            CargarUsuariosDisponibles();

            textBoxNombreUsuario.TextChanged += TextBoxNombreUsuario_TextChanged;
            buttonAgregar.Click += buttonAgregar_Click;
            buttonBorrar.Click += buttonBorrar_Click;
            buttonCrear.Click += buttonCrear_Click;

            listBoxUsuariosProyecto.DataSource = usuariosProyecto;
            listBoxUsuariosProyecto.DisplayMember = "NombreCompleto";
        }

        private void Pantalla6_Load(object sender, EventArgs e)
        {
            originalSize = this.Size;
            InitializeOriginalRectangles();
        }

        private void InitializeOriginalRectangles()
        {
            // Contenido principal
            rectTextBoxNombreUsuario = new Rectangle(textBoxNombreUsuario.Location, textBoxNombreUsuario.Size);
            rectListBoxUsuarios = new Rectangle(listBoxUsuarios.Location, listBoxUsuarios.Size);
            rectListBoxUsuariosProyecto = new Rectangle(listBoxUsuariosProyecto.Location, listBoxUsuariosProyecto.Size);
            rectTextBoxNombreProyecto = new Rectangle(textBoxNombreProyecto.Location, textBoxNombreProyecto.Size);
            rectDatePicker = new Rectangle(dateTimePickerFechaNacimiento.Location, dateTimePickerFechaNacimiento.Size);
            rectButtonAgregar = new Rectangle(buttonAgregar.Location, buttonAgregar.Size);
            rectButtonBorrar = new Rectangle(buttonBorrar.Location, buttonBorrar.Size);
            rectButtonCrear = new Rectangle(buttonCrear.Location, buttonCrear.Size);

            // NUEVO → Línea horizontal
            rectLinea = new Rectangle(linea.Location, linea.Size);
        }

        private void Pantalla6_Resize(object sender, EventArgs e)
        {
            float scaleX = (float)this.Width / originalSize.Width;
            float scaleY = (float)this.Height / originalSize.Height;

            // Escalar todos los controles
            ResizeControl(textBoxNombreUsuario, rectTextBoxNombreUsuario);
            ResizeControl(listBoxUsuarios, rectListBoxUsuarios);
            ResizeControl(listBoxUsuariosProyecto, rectListBoxUsuariosProyecto);
            ResizeControl(textBoxNombreProyecto, rectTextBoxNombreProyecto);
            ResizeControl(dateTimePickerFechaNacimiento, rectDatePicker);
            ResizeControl(buttonAgregar, rectButtonAgregar);
            ResizeControl(buttonBorrar, rectButtonBorrar);
            ResizeControl(buttonCrear, rectButtonCrear);

            // --- NUEVO: Redimensionar la línea para que ocupe todo el ancho ---
            linea.Width = this.ClientSize.Width;

        }

        private void ResizeControl(Control control, Rectangle original)
        {
            float xRatio = (float)this.Width / originalSize.Width;
            float yRatio = (float)this.Height / originalSize.Height;

            int newX = (int)(original.X * xRatio);
            int newY = (int)(original.Y * yRatio);
            int newWidth = (int)(original.Width * xRatio);
            int newHeight = (int)(original.Height * yRatio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);
        }

        // --- NUEVO: Escalado estilo Pantalla8 ---
        private void ResizeSidebarButton(Control btn, Rectangle original, float scaleX, float scaleY)
        {
            btn.Left = (int)(original.Left * scaleX);
            btn.Top = (int)(original.Top * scaleY);
            btn.Width = (int)(original.Width * scaleX);
            btn.Height = (int)(original.Height * scaleY);
        }

        // -------------------------------------------------------------
        // ---------------------- LÓGICA ORIGINAL ----------------------
        // -------------------------------------------------------------

        private void CargarUsuariosDisponibles()
        {
            listBoxUsuarios.DataSource = null;
            listBoxUsuarios.DataSource = ListadoDatosClasses.ListadoUsuarios;
            listBoxUsuarios.DisplayMember = "NombreCompleto";
        }

        private void TextBoxNombreUsuario_TextChanged(object sender, EventArgs e)
        {
            string filtro = textBoxNombreUsuario.Text.ToLower();

            var usuariosFiltrados = ListadoDatosClasses.ListadoUsuarios
                .Where(u => u.nombre.ToLower().Contains(filtro))
                .ToList();

            listBoxUsuarios.DataSource = null;
            listBoxUsuarios.DataSource = usuariosFiltrados;
            listBoxUsuarios.DisplayMember = "NombreCompleto";
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (listBoxUsuarios.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un usuario para agregar.");
                return;
            }

            Usuario seleccionado = (Usuario)listBoxUsuarios.SelectedItem;

            if (usuariosProyecto.Contains(seleccionado))
            {
                MessageBox.Show("Ese usuario ya está agregado.");
                return;
            }

            usuariosProyecto.Add(seleccionado);
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            if (listBoxUsuariosProyecto.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un usuario para borrar.");
                return;
            }

            usuariosProyecto.Remove((Usuario)listBoxUsuariosProyecto.SelectedItem);
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            string nombreProyecto = textBoxNombreProyecto.Text.Trim();
            DateTime fechaEntrega = dateTimePickerFechaNacimiento.Value;

            if (string.IsNullOrWhiteSpace(nombreProyecto))
            {
                MessageBox.Show("Debe introducir un nombre de proyecto.");
                return;
            }

            if (usuariosProyecto.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un usuario.");
                return;
            }

            bool existeProyecto = ListadoDatosClasses.ListadoProyectos.Any(p => p.titulo.Equals(nombreProyecto, StringComparison.OrdinalIgnoreCase));

            if (existeProyecto)
            {
                MessageBox.Show("Ya existe un proyecto con ese nombre. Elige otro.");
                return;
            }

            List<Usuario> miembros = usuariosProyecto.ToList();
            Proyecto nuevoProyecto = new Proyecto(nombreProyecto, fechaEntrega, miembros);

            ListadoDatosClasses.ListadoProyectos.Add(nuevoProyecto);

            textBoxNombreProyecto.Clear();
            dateTimePickerFechaNacimiento.Value = DateTime.Now;
            usuariosProyecto.Clear();
            textBoxNombreUsuario.Clear();

            MessageBox.Show($"Proyecto '{nombreProyecto}' creado correctamente.");

            string proyectos = string.Join("\n", ListadoDatosClasses.ListadoProyectos
                                        .Select(p => $"[{p.ID}] {p.titulo}"));

            MessageBox.Show("Proyectos actuales:\n" + proyectos);

            ListadoDatosClasses.guardarDatos();
            this.Close();

        }
        private void buttonUsuarios_Click(object sender, EventArgs e)
        {
            Point location = Navegacion.FormInicialLocation(this);
            Size size = Navegacion.FormInicialSize(this);
            ListadoDatosClasses.exportProjects();
            Pantalla8 pantalla8 = new Pantalla8(location, size);
            pantalla8.Show();
            this.Close();
        }
        private void buttonInicio_Click(object sender, EventArgs e)
        {
            ListadoDatosClasses.exportProjects();
            Pantalla2 pantalla2 = new Pantalla2();
            pantalla2.Show();
            this.Close();
        }

        private void buttonImportarJSON_Click(object sender, EventArgs e)
        {
            ListadoDatosClasses.importJSONFromNewDirectory();
        }

        private void buttonExportarJSON_Click(object sender, EventArgs e)
        {
            ListadoDatosClasses.guardarDatos();
        }

        private void buttonOut_Click(object sender, EventArgs e)
        {
            ListadoDatosClasses.guardarDatos();
            Application.Exit();
        }
    }
}

