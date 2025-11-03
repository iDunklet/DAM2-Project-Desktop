using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAM2_Project_Desktop.Properties;

namespace DAM2_Project_Desktop
{
    public partial class Pantalla8 : Form
    {

        public Pantalla8()
        {
            InitializeComponent();
            this.Load += new EventHandler(Pantalla8_Load);
            Dimencions.ApplyMinimum(this);
            this.Resize += Pantalla8_Resize;
        }

        private void Pantalla8_Resize(object sender, EventArgs e)
        {

            buttonInicio.Size = Dimencions.Scale(new Size(200, 60), this.ClientSize);
            buttonProyectosPrivados.Size = Dimencions.Scale(new Size(200, 60), this.ClientSize);
            buttonUsuarios.Size = Dimencions.Scale(new Size(200, 60), this.ClientSize);
            buttonImportarJSON.Size = Dimencions.Scale(new Size(200, 60), this.ClientSize);
            buttonExportarJSON.Size = Dimencions.Scale(new Size(200, 60), this.ClientSize);
            button7.Size = Dimencions.Scale(new Size(200, 60), this.ClientSize);

            // Escalar DataGridView
            dataGridViewListadoUsuarios.Size = Dimencions.Scale(new Size(1200, 810), this.ClientSize);

            // Escalar columnas
            float scaleX = (float)this.ClientSize.Width / 1440;
            ImgPerfil.Width = (int)(30 * scaleX);
            Username.Width = (int)(150 * scaleX);
            Nombre.Width = (int)(175 * scaleX);
            Apellidos.Width = (int)(285 * scaleX);
            Email.Width = (int)(250 * scaleX);
            Curso.Width = (int)(100 * scaleX);
            iconoEdit.Width = (int)(40 * scaleX);
            IconoDelete.Width = (int)(40 * scaleX);

            // Escalar altura de filas
            float scaleY = (float)this.ClientSize.Height / 1024;
            foreach (DataGridViewRow row in dataGridViewListadoUsuarios.Rows)
            {
                row.Height = (int)(30 * scaleY);
            }

        }


        private void Pantalla8_Load(object sender, EventArgs e)
        {
            dataGridViewListadoUsuarios.DataSource = ListadoDatosClasses.ListadoUsuarios;

            ConfigurarColumnaIconoEdit();
            ConfigurarColumnaIconoDelete();
            ConfigurarColumnaIconoEditar();


            // --- CÓDIGO PARA EL REDIMENSIONAMIENTO AUTOMÁTICO DE ALTURA ---

            // Calcula la altura total de todas las filas y aplica el ajuste.
            int totalHeight = dataGridViewListadoUsuarios.Rows.Cast<DataGridViewRow>().Sum(row => row.Height);

            // Establece la nueva altura (total de filas + pequeño margen de 3 píxeles).
            dataGridViewListadoUsuarios.Height = totalHeight + 3;
        }

        

        public Bitmap GetImgIconDelete()
        {
            Bitmap icon = Properties.Resources.icon_delete;
            Bitmap resizedIcon = new Bitmap(icon, new Size(15, 15));
            return resizedIcon;
        }

        public Bitmap GetImgIconEdit()
        {
            Bitmap icon = Properties.Resources.icon_edit;
            Bitmap resizedIcon = new Bitmap(icon, new Size(15, 15));
            return resizedIcon;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (columnName == "iconoEditar")
            {
                var usuario = clickedRow.DataBoundItem as Usuarios;

                if (usuario == null)
                {
                    MessageBox.Show("❌ No se pudo obtener el usuario (DataBoundItem es null).");
                    return;
                }

                // 💥 VERIFICACIÓN CLAVE 💥
                MessageBox.Show(
                    $"Usuario obtenido:\n\n" +
                    $"Nombre: {usuario.nombre}\n" +
                    $"Username: {usuario.username}\n" +
                    $"Email: {usuario.email}"
                );

                Pantalla7 p = new Pantalla7(usuario);
                p.Show();
            }
        }



        /*
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = dataGridViewListadoUsuarios.Columns[e.ColumnIndex].Name;
            DataGridViewRow clickedRow = dataGridViewListadoUsuarios.Rows[e.RowIndex];

            if (columnName == "IconoDelete")
            {
                Usuarios usuarioAEliminar = clickedRow.DataBoundItem as Usuarios;

                if (usuarioAEliminar != null)
                {

                    ListadoDatosClasses.ListadoUsuarios.Remove(usuarioAEliminar);
                    ActualizarAlturaDataGridView();
                }

            }
            if (columnName == "iconoEdit")
            {
                Pantalla7 p = new Pantalla7(clickedRow.DataBoundItem as Usuarios);
                p.Show();
            }
        }
        private void ActualizarAlturaDataGridView()
        {

            int totalHeight = dataGridViewListadoUsuarios.ColumnHeadersHeight;


            if (dataGridViewListadoUsuarios.Rows.Count > 0)
            {
                totalHeight += dataGridViewListadoUsuarios.Rows.Cast<DataGridViewRow>().Sum(row => row.Height);
            }

            dataGridViewListadoUsuarios.Height = totalHeight + 3;
        }
        private void ConfigurarColumnaIconoDelete()
        {
            if (dataGridViewListadoUsuarios.Columns.Contains("IconoDelete"))
            {
                DataGridViewImageColumn deleteCol = (DataGridViewImageColumn)dataGridViewListadoUsuarios.Columns["IconoDelete"];
                deleteCol.Image = GetImgIconDelete();
            }
        }
        */
        private void ConfigurarColumnaIconoEdit()
        {
            if (dataGridViewListadoUsuarios.Columns.Contains("iconoEditar"))
            {
                DataGridViewImageColumn deleteCol = (DataGridViewImageColumn)dataGridViewListadoUsuarios.Columns["iconoEditar"];
                deleteCol.Image = GetImgIconEdit();
            }
        }

        private void ConfigurarColumnaIconoEditar()
        {
            if (dataGridViewListadoUsuarios.Columns.Contains("IconoEdit"))
            {
                DataGridViewImageColumn ediCol = (DataGridViewImageColumn)dataGridViewListadoUsuarios.Columns["IconoEdit"];
                ediCol.Image = GetImgIconEdit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewListadoUsuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
