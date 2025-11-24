using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace DAM2_Project_Desktop
{
    public partial class Pantalla6 : Form
    {
        // Lista interna para los usuarios del proyecto
        private BindingList<Usuarios> usuariosProyecto = new BindingList<Usuarios>();

        public Pantalla6()
        {
            InitializeComponent();

            // Cargar usuarios al iniciar
            CargarUsuariosDisponibles();

            // Conectar eventos
            textBoxNombreUsuario.TextChanged += TextBoxNombreUsuario_TextChanged;
            buttonAgregar.Click += buttonAgregar_Click;
            buttonBorrar.Click += buttonBorrar_Click;
            buttonCrear.Click += buttonCrear_Click;

            // Cargar la lista de usuarios del proyecto
            listBoxUsuariosProyecto.DataSource = usuariosProyecto;
            listBoxUsuariosProyecto.DisplayMember = "NombreCompleto";
        }

        // Cargar todos los usuarios disponibles
        private void CargarUsuariosDisponibles()
        {
            listBoxUsuarios.DataSource = null;
            listBoxUsuarios.DataSource = ListadoDatosClasses.ListadoUsuarios;
            listBoxUsuarios.DisplayMember = "NombreCompleto";
        }

        // Filtrar según texto escrito
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

        // BOTÓN AGREGAR
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (listBoxUsuarios.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un usuario para agregar.");
                return;
            }

            Usuarios seleccionado = (Usuarios)listBoxUsuarios.SelectedItem;

            // Evitar duplicados
            if (usuariosProyecto.Contains(seleccionado))
            {
                MessageBox.Show("Ese usuario ya está agregado.");
                return;
            }

            usuariosProyecto.Add(seleccionado);
        }

        // BOTÓN BORRAR
        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            if (listBoxUsuariosProyecto.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un usuario para borrar.");
                return;
            }

            usuariosProyecto.Remove((Usuarios)listBoxUsuariosProyecto.SelectedItem);
        }

        // BOTÓN CREAR PROYECTO (GUARDAR)
        private void buttonCrear_Click(object sender, EventArgs e)
        {
            string nombreProyecto = textBoxNombreProyecto.Text.Trim();
            DateTime fechaEntrega = dateTimePickerFechaNacimiento.Value;

            // Validaciones básicas
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

            List<Usuarios> miembros = usuariosProyecto.ToList();
            Proyecto nuevoProyecto = new Proyecto(nombreProyecto, fechaEntrega, miembros);

            ListadoDatosClasses.ListadoProyectos.Add(nuevoProyecto);

            // Limpiar campos para crear un nuevo proyecto
            textBoxNombreProyecto.Clear();
            dateTimePickerFechaNacimiento.Value = DateTime.Now;
            usuariosProyecto.Clear();

            MessageBox.Show($"Proyecto '{nombreProyecto}' creado correctamente.");

            string proyectos = string.Join("\n", ListadoDatosClasses.ListadoProyectos
                                        .Select(p => $"[{p.ID}] {p.titulo}"));

            MessageBox.Show("Proyectos actuales:\n" + proyectos);



        }


    }
}
