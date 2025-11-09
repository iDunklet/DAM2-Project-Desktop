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
    public partial class Pantalla3 : Form
    {
        private ComboBox comboUsuariosDAM2;
        //private ComboBox comboProyectos;

        public Pantalla3(Proyecto project)
        {


            InitializeComponent();
            //dataGridView1_CellContentClick();
            dataGridView1.CellClick += dataGridView1_CellClick;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evita errores si se hace clic en el encabezado
            try
            {
                if (e.RowIndex < 0) return;

                // Comprueba en qué columna se ha hecho clic (usa los nombres que pusiste en el diseñador)
                string nombreColumna = dataGridView1.Columns[e.ColumnIndex].Name;

                if (nombreColumna == "FechaInicioColumn" || nombreColumna == "FechaFinalColumn")
                {
                    ShowDatePicker(e.RowIndex, e.ColumnIndex);
                }
            }
            catch { }
        }

        private void ShowDatePicker(int rowIndex, int columnIndex)
        {
            // Crear el control DateTimePicker
            DateTimePicker dtp = new DateTimePicker();
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.CustomFormat = "dd/MM/yyyy";
            dtp.Visible = true;

            // Colocarlo encima de la celda seleccionada
            Rectangle cellRectangle = dataGridView1.GetCellDisplayRectangle(columnIndex, rowIndex, true);
            dtp.Location = new Point(cellRectangle.X, cellRectangle.Y);
            dtp.Size = new Size(cellRectangle.Width, cellRectangle.Height);

            // Añadir el control al DataGridView
            dataGridView1.Controls.Add(dtp);

            // Cuando el usuario elija la fecha y cierre el calendario
            dtp.CloseUp += (s, e) =>
            {
                dataGridView1.Rows[rowIndex].Cells[columnIndex].Value = dtp.Text;
                dataGridView1.Controls.Remove(dtp);
            };

            // Actualizar el valor al cambiar la fecha
            dtp.TextChanged += (s, e) =>
            {
                dataGridView1.Rows[rowIndex].Cells[columnIndex].Value = dtp.Text;
            };
        }

        private void splitContainer3_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pantalla3_Load(object sender, EventArgs e)
        {
            Proyecto proyecto = ListadoDatosClasses.ListadoProyectos[0]; // <-- viene de la clase estática
            MostrarProyecto(proyecto);
        }

        private void splitContainer6_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer7_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer5_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewComboBoxColumn colOpciones = new DataGridViewComboBoxColumn();
            colOpciones.HeaderText = "Opciones";
            colOpciones.Items.AddRange("Opción 1", "Opción 2", "Opción 3");
            dataGridView1.Columns.Add(colOpciones);

            DataGridViewCheckBoxColumn colCheck = new DataGridViewCheckBoxColumn();
            colCheck.HeaderText = "Activo";
            dataGridView1.Columns.Add(colCheck);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer4_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer7_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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

            var usuariosDAM2 = ListadoDatosClasses.ListadoUsuarios
                .Where(u => u.classe == "DAM2")
                .ToList();

            comboUsuariosDAM2.DataSource = usuariosDAM2;
            comboUsuariosDAM2.DisplayMember = "nombre";

            // 💥 Importante: añadir el combo en el mismo contenedor que el PictureBox
            splitContainer4.Panel2.Controls.Add(comboUsuariosDAM2);

            // 🟩 Colocarlo al lado del pictureBox4, en coordenadas del mismo Panel
            comboUsuariosDAM2.Location = new Point(
                pictureBox4.Left,
                pictureBox4.Top - comboUsuariosDAM2.Height - 5
            );

            comboUsuariosDAM2.Width = 160;
            comboUsuariosDAM2.BringToFront();

            comboUsuariosDAM2.SelectedIndexChanged += (s, ev) =>
            {
                var u = (Usuarios)comboUsuariosDAM2.SelectedItem;
                AgregarUsuarioAlPanel(u);

                splitContainer4.Panel2.Controls.Remove(comboUsuariosDAM2);
                comboUsuariosDAM2.Dispose();
                comboUsuariosDAM2 = null;
            };
        }

        private void AgregarUsuarioAlPanel(Usuarios usuario)
        {
            // Crear contenedor visual para cada usuario
            Panel panelUsuario = new Panel();
            panelUsuario.Width = 90;
            panelUsuario.Height = 120;
            panelUsuario.Margin = new Padding(10);

            // Imagen (usamos la mini o la grande)
            PictureBox pic = new PictureBox();
            pic.Image = usuario.imgPerfil; // O miniImgPerfil si prefieres pequeño
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Width = 80;
            pic.Height = 80;
            pic.Location = new Point(5, 5);

            // Nombre debajo de la imagen
            Label lbl = new Label();
            lbl.Text = usuario.nombre;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.AutoSize = false;
            lbl.Width = 80;
            lbl.Height = 30;
            lbl.Location = new Point(5, 90);

            // Agregar al panel
            panelUsuario.Controls.Add(pic);
            panelUsuario.Controls.Add(lbl);

            // Agregar al FlowLayoutPanel del formulario
            flowPanelMiembros.Controls.Add(panelUsuario);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer4_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer5_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MostrarProyecto(Proyecto proyecto)
        {
            if (proyecto == null) return;

            labelNombreProyecto.Text = proyecto.titulo;
            labelFechaProyecto.Text = proyecto.fechaEntrega.ToString("dd/MM/yyyy");
        }

        private void labelNombreProyecto_Click(object sender, EventArgs e)
        {

        }

        private void labelFechaProyecto_Click(object sender, EventArgs e)
        {

        }
    }
}
