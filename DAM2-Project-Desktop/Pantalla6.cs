using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAM2_Project_Desktop
{
    public partial class Pantalla6 : Form
    {
        public Pantalla6()
        {
            InitializeComponent();

            // Eliminar métodos que lanzan excepción por defecto
            splitContainer2.Panel2.Paint -= splitContainer2_Panel2_Paint;
            labelFechaNacimiento.Click -= label4_Click;

            // Asociamos el evento del botón Guardar
            buttonGuardar.Click += ButtonGuardar_Click;
        }

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            // 1️⃣ Leer los datos de los campos
            string nombre = textBoxNombre.Text.Trim();
            string apellido = textBoxApellido.Text.Trim();
            string correo = textBoxCorreo.Text.Trim();
            string contrasenyaActual = textBoxContrasenya.Text.Trim();
            string nuevaContrasenya = textBoxNuevaContrasenya.Text.Trim();
            string confirmarContrasenya = textBoxConfirmarContrasenya.Text.Trim();

            //21️⃣ Validar los datos de los campos

            var campos = new[] { nombre, apellido, correo, contrasenyaActual, nuevaContrasenya, confirmarContrasenya };

            if (campos.Any(string.IsNullOrWhiteSpace))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!nuevaContrasenya.Equals(confirmarContrasenya))
            {
                MessageBox.Show("Las contraseñas nuevas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3️⃣ Buscar usuario
            var usuario = ListadoDatosClasses.ListadoUsuarios
                .FirstOrDefault(u =>
                    u.nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase) &&
                    u.apellido1.Equals(apellido, StringComparison.OrdinalIgnoreCase) &&
                    u.email.Equals(correo, StringComparison.OrdinalIgnoreCase));

            if (usuario == null)
            {
                MessageBox.Show("No se encontró ningún usuario con esos datos.", "Usuario no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 4️⃣ Verificar contraseña actual
            if (usuario.password != contrasenyaActual)
            {
                MessageBox.Show("La contraseña actual es incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 5️⃣ Actualizar contraseña
            usuario.password = nuevaContrasenya;

            MessageBox.Show("Contraseña actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 6️⃣ Limpiar los campos
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            textBoxNombre.Clear();
            textBoxApellido.Clear();
            textBoxCorreo.Clear();
            textBoxContrasenya.Clear();
            textBoxNuevaContrasenya.Clear();
            textBoxConfirmarContrasenya.Clear();
            textBoxClase.Clear();
        }

        private void buttonGuardar_Click_1(object sender, EventArgs e)
        {

        }
    }
}

