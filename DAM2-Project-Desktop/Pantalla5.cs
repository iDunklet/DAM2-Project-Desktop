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
    public partial class Pantalla5 : Form
    {
        public Pantalla5()
        {
            InitializeComponent();

            // 🔹 Aquí añadimos los eventos después de que los controles existen
            // 🔹 Aquí añadimos los eventos después de que los controles existen
            textBoxNombre.TextChanged += CamposUsuario_TextChanged;
            textBoxApellido1.TextChanged += CamposUsuario_TextChanged;
            textBoxCurso.TextChanged += CamposUsuario_TextChanged;
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
    }
}
