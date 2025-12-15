using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DAM2_Project_Desktop
{
    public partial class SelectorUsuariosForm : Form
    {
        public Usuario UsuarioSeleccionado { get; private set; }

        public SelectorUsuariosForm(List<Usuario> usuarios)
        {
            InitializeComponent();

            // Configuración del Form
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Width = 320;  // Más ancho para incluir el borde
            this.Height = 370; // Más alto para incluir el borde
            this.BackColor = Color.FromArgb(35, 78, 82); // Color del borde
            this.Padding = new Padding(4); // Grosor del borde

            // Panel principal con el contenido
            var panelPrincipal = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                BorderStyle = BorderStyle.None
            };
            this.Controls.Add(panelPrincipal);

            // Título
            var lblTitulo = new Label
            {
                Text = "Seleccionar usuario",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                Dock = DockStyle.Top,
                Height = 40,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.FromArgb(35, 78, 82)
            };
            panelPrincipal.Controls.Add(lblTitulo);

            // Lista de usuarios
            var listBoxUsuarios = new ListBox
            {
                Dock = DockStyle.Top,
                Height = 220,
                DataSource = usuarios,
                DisplayMember = "nombre",
                Font = new Font("Segoe UI", 11),
                BorderStyle = BorderStyle.None,
                BackColor = Color.White,
                ForeColor = Color.FromArgb(50, 50, 50)
            };
            panelPrincipal.Controls.Add(listBoxUsuarios);

            // Panel para botones
            var panelBotones = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 50
            };
            panelPrincipal.Controls.Add(panelBotones);

            // Botón Aceptar
            var btnAceptar = new Button
            {
                Text = "Aceptar",
                Width = 120,
                Height = 35,
                BackColor = Color.FromArgb(79, 209, 197),
                ForeColor = Color.FromArgb(35, 78, 82),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Montserrat Medium", 10, FontStyle.Bold)
            };
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.Click += (s, e) => ConfirmarSeleccion(listBoxUsuarios);
            panelBotones.Controls.Add(btnAceptar);
            btnAceptar.Location = new Point(20, 7);

            // Botón Cancelar
            var btnCancelar = new Button
            {
                Text = "Cancelar",
                Width = 120,
                Height = 35,
                BackColor = Color.FromArgb(220, 220, 220),
                ForeColor = Color.FromArgb(35, 78, 82),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Montserrat Medium", 10, FontStyle.Bold)
            };
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.Click += (s, e) => this.Close();
            panelBotones.Controls.Add(btnCancelar);
            btnCancelar.Location = new Point(150, 7);

            // Doble clic en la lista también confirma
            listBoxUsuarios.DoubleClick += (s, e) => ConfirmarSeleccion(listBoxUsuarios);
        }

        private void ConfirmarSeleccion(ListBox listBox)
        {
            if (listBox.SelectedItem != null)
            {
                UsuarioSeleccionado = (Usuario)listBox.SelectedItem;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
