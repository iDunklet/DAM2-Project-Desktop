using System;
using System.Linq;
using System.Windows.Forms;

namespace DAM2_Project_Desktop
{
    public partial class Pantalla5 : Form
    {
        public Pantalla5()
        {
            InitializeComponent();

            // 🔹 Eventos para generar el username automáticamente
            textBoxNombre.TextChanged += CamposUsuario_TextChanged;
            textBoxApellido1.TextChanged += CamposUsuario_TextChanged;
            textBoxCurso.TextChanged += CamposUsuario_TextChanged;

            // 🔹 Evento del botón Crear Usuario
            buttonCrearUsuario.Click += ButtonCrearUsuario_Click;
        }

        private void ButtonCrearUsuario_Click(object? sender, EventArgs e)
        {
        }

        private void CamposUsuario_TextChanged(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            string apellido1 = textBoxApellido1.Text;
            string classe = textBoxCurso.Text;

            // Generamos el username automáticamente
            textBoxUsuario.Text = GenerateUserName(nombre, apellido1, classe);
        }

        private string GenerateUserName(string nombre, string apellido1, string classe)
        {
            nombre = nombre?.Trim() ?? "";
            apellido1 = apellido1?.Trim() ?? "";
            classe = classe?.Trim() ?? "";

            string inicialNombre = nombre.Length > 0 ? nombre[0].ToString() : "?";
            string apellido = apellido1.Length > 0 ? apellido1 : "?";
            string claseParte = classe.Length > 0 ? classe : "";

            string userName = inicialNombre + apellido + claseParte;
            return userName.ToUpper();
        }
        /*
        private void ButtonCrearUsuario2_Click(object sender, EventArgs e)
        {
            // 1️⃣ Leer los datos de los campos
            string nombre = textBoxNombre.Text.Trim();
            string apellido1 = textBoxApellido1.Text.Trim();
            string apellido2 = textBoxApellido2.Text.Trim();
            string clase = textBoxCurso.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string password = textBoxContrasenya.Text.Trim();
            string repPassword = textBoxRepContrasenya.Text.Trim();
            DateTime fechaNacimiento = dateTimePickerFechaNacimiento.Value;
            string userName = textBoxUsuario.Text.Trim();

            // 2️⃣ Validaciones básicas
            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(apellido1) ||
                string.IsNullOrWhiteSpace(apellido2) ||
                string.IsNullOrWhiteSpace(clase) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(repPassword))
            {
                MessageBox.Show("Por favor, completa todos los campos obligatorios.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != repPassword)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3️⃣ Crear el usuario
            Usuarios nuevoUsuario = new Usuarios(
                nombre,
                apellido1,
                apellido2,
                fechaNacimiento,
                clase,
                email,
                password,
                userName
            );
       
            // 4️⃣ Añadirlo a la lista de usuarios
            ListadoDatosClasses.ListadoUsuarios.Add(nuevoUsuario);

            MessageBox.Show($"Usuario '{nuevoUsuario.userName}' creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 5️⃣ Limpiar campos para un nuevo registro
            LimpiarCamposUsuario();
        }

        */


        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            // 1️⃣ Leer los datos de los campos
            string nombre = textBoxNombre.Text.Trim();
            string apellido1 = textBoxApellido1.Text.Trim();
            string apellido2 = textBoxApellido2.Text.Trim();
            string clase = textBoxCurso.Text.Trim();
            DateTime fechaNacimiento = dateTimePickerFechaNacimiento.Value;
            string email = textBoxEmail.Text.Trim();
            string password = textBoxContrasenya.Text.Trim();
            string repPassword = textBoxRepetirContrasenya.Text.Trim();
            string userName = textBoxUsuario.Text.Trim(); // Ya se genera automáticamente antes

            // 2️⃣ Validación de campos vacíos
            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(apellido1) ||
                string.IsNullOrWhiteSpace(clase) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(repPassword))
            {
                MessageBox.Show("Por favor, completa todos los campos obligatorios.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3️⃣ Validación de contraseñas
            if (password != repPassword)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 4️⃣ Crear el usuario
            Usuarios nuevoUsuario = new Usuarios(
                nombre, apellido1, fechaNacimiento,
                clase, email, password, userName
            );

            // 5️⃣ Añadirlo a la lista de usuarios
            ListadoDatosClasses.ListadoUsuarios.Add(nuevoUsuario);

            MessageBox.Show($"Usuario creado correctamente ✅\n\n" +
                            $"Nombre: {nuevoUsuario.nombre}\n" +
                            $"UserName: {nuevoUsuario.userName}\n" +
                            $"Usuarios totales: {ListadoDatosClasses.ListadoUsuarios.Count}");

            // 6️⃣ Mostrar lista de usuarios
            string lista = "";
            foreach (var usuario in ListadoDatosClasses.ListadoUsuarios)
            {
                lista += $"• {usuario.userName} ({usuario.nombre} {usuario.apellido1}) {usuario.classe}\n";
            }

            MessageBox.Show(lista, "Lista de Usuarios");

            // 7️⃣ Limpiar campos para un nuevo registro
            LimpiarCamposUsuario();
        }




    }
}
