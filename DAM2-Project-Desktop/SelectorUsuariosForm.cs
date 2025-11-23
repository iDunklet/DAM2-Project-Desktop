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
    public partial class SelectorUsuariosForm : Form
    {
        public Usuario UsuarioSeleccionado { get; private set; }

        public SelectorUsuariosForm(List<Usuario> usuarios)
        {
            InitializeComponent();

            // Tamaño pequeño tipo mini ventana
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.StartPosition = FormStartPosition.Manual;
            this.Width = 200;
            this.Height = 250;

            // Crear ListBox con usuarios
            var listBoxUsuarios = new ListBox
            {
                Dock = DockStyle.Fill,
                DataSource = usuarios,
                DisplayMember = "nombre"
            };

            listBoxUsuarios.DoubleClick += (s, e) =>
            {
                UsuarioSeleccionado = (Usuario)listBoxUsuarios.SelectedItem;
                this.DialogResult = DialogResult.OK;
                this.Close();
            };

            this.Controls.Add(listBoxUsuarios);
        }
    }
}
