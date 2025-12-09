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

        private Size originalSize;

        // --- Rectángulos de la Barra Lateral (Botones) ---
        private Rectangle RectanglebuttonInicio;
        private Rectangle RectanglebuttonProyectosPrivados;
        private Rectangle RectanglebuttonUsuarios;
        private Rectangle RectanglebuttonImportarJSON;
        private Rectangle RectanglebuttonExportarJSON;
        private Rectangle RectangelbuttonCrearUser;
        private Rectangle Rectanglebutton7;

        // --- Rectángulos del Contenido Principal ---
        private Rectangle RectanglepictureBoxTasky;
        private Rectangle RectangledataGridViewListadoUsuarios;

        public Pantalla8()
        {
            InitializeComponent();
            dataGridViewListadoUsuarios.AutoGenerateColumns = false;
            this.Load += new EventHandler(Pantalla8_Load);
            Dimencions.ApplyMinimum(this);
            this.Resize += Pantalla8_Resize;
            originalSize = this.Size;
            InitializeOriginalRectangles();
            Pantalla8_Resize(null, null);
        }
        public Pantalla8(Point p, Size s)
        {
            InitializeComponent();
            dataGridViewListadoUsuarios.AutoGenerateColumns = false;
            this.Load += new EventHandler(Pantalla8_Load);
            Dimencions.ApplyMinimum(this);
            this.Resize += Pantalla8_Resize;
            originalSize = this.Size;
            InitializeOriginalRectangles();
            Pantalla8_Resize(null, null);
        }

        private void Pantalla8_Resize(object sender, EventArgs e)
        {
            Size formOriginalSize = this.originalSize;

            // El escalado general de posición y altura se mantiene.
            ResizeBotonesLaterales();

            const int ORIGINAL_SPLITTER_DISTANCE = 93;
            const int DESIGN_HEIGHT_BASE = 1100;

            Dimencions.ScaleAndCenterHeader(
                pictureBoxTasky,
                splitContainer1,
                ORIGINAL_SPLITTER_DISTANCE,
                this,
                DESIGN_HEIGHT_BASE);

            // Resize grid
            Dimencions.ResizeControl(dataGridViewListadoUsuarios, RectangledataGridViewListadoUsuarios, this, formOriginalSize);

            // --- CÁLCULO Y ASIGNACIÓN DE ANCHURA DE COLUMNAS (CLAVE) ---
            float scaleX = (float)this.ClientSize.Width / 1440;

            int[] baseWidths = { 30, 150, 175, 285, 250, 125, 40, 40 };
            int totalScaledWidth = 0;

            ImgPerfil.Width = (int)(baseWidths[0] * scaleX);
            totalScaledWidth += ImgPerfil.Width;

            Username.Width = (int)(baseWidths[1] * scaleX);
            totalScaledWidth += Username.Width;

            Nombre.Width = (int)(baseWidths[2] * scaleX);
            totalScaledWidth += Nombre.Width;

            Apellidos.Width = (int)(baseWidths[3] * scaleX);
            totalScaledWidth += Apellidos.Width;

            Email.Width = (int)(baseWidths[4] * scaleX);
            totalScaledWidth += Email.Width;

            Curso.Width = (int)(baseWidths[5] * scaleX);
            totalScaledWidth += Curso.Width;

            iconoEdit.Width = (int)(baseWidths[6] * scaleX);
            totalScaledWidth += iconoEdit.Width;

            IconoDelete.Width = (int)(baseWidths[7] * scaleX);
            totalScaledWidth += IconoDelete.Width;

            dataGridViewListadoUsuarios.Width = totalScaledWidth + 2;

            // --- LÓGICA DE ESCALADO DE FILAS (Mantenida) ---
            float scaleY = (float)this.ClientSize.Height / 1024;
            foreach (DataGridViewRow row in dataGridViewListadoUsuarios.Rows)
            {
                row.Height = (int)(30 * scaleY);
            }

            // Opcional: Re-ajuste vertical para que la Grid coincida con la altura de las filas.
            if (dataGridViewListadoUsuarios.Rows.Count > 0)
            {
                int totalRowsHeight = dataGridViewListadoUsuarios.Rows.Cast<DataGridViewRow>().Sum(row => row.Height);
                int headerHeight = dataGridViewListadoUsuarios.ColumnHeadersHeight;
                dataGridViewListadoUsuarios.Height = totalRowsHeight + headerHeight + 2;
            }
        }

        private void ResizeBotonesLaterales()
        {
            Control[] sidebarButtons = { buttonInicio, buttonUsuarios, buttonImportarJSON, buttonExportarJSON, buttonCrearUser, button7 };
            Rectangle[] originalRects = { RectanglebuttonInicio, RectanglebuttonUsuarios, RectanglebuttonImportarJSON, RectanglebuttonExportarJSON, RectangelbuttonCrearUser, Rectanglebutton7 };

            // Obtener el ancho actual del panel lateral
            int sidebarPanelWidth = splitContainer2.Panel1.ClientSize.Width;

            // Delega la lógica de centrado y escalado Y a la clase estática.
            Dimencions.ResizeSidebarButtons(sidebarButtons, originalRects, sidebarPanelWidth, this);
        }

        private void InitializeOriginalRectangles()
        {
            // Header
            RectanglepictureBoxTasky = new Rectangle(pictureBoxTasky.Location, pictureBoxTasky.Size);

            const int GRID_DESIGN_WIDTH = 1146;
            const int GRID_DESIGN_HEIGHT = 842;

            // Contenido principal
            RectangledataGridViewListadoUsuarios = new Rectangle(
                  new Point(32, 27),
                  new Size(GRID_DESIGN_WIDTH, GRID_DESIGN_HEIGHT));

            // Barra Lateral (Botones) - Coordenadas del diseñador de Pantalla8
            Size baseSize = new Size(200, 60);

            // Posiciones Y críticas: 12 hasta 1072
            RectanglebuttonInicio = new Rectangle(new Point(21, 12), baseSize);
            RectanglebuttonProyectosPrivados = new Rectangle(new Point(21, 78), baseSize);
            RectanglebuttonUsuarios = new Rectangle(new Point(21, 144), baseSize);
            RectanglebuttonImportarJSON = new Rectangle(new Point(21, 210), baseSize);
            RectanglebuttonExportarJSON = new Rectangle(new Point(21, 276), baseSize);
            RectangelbuttonCrearUser = new Rectangle(new Point(21, 796), baseSize);
            Rectanglebutton7 = new Rectangle(new Point(24, 1072), baseSize);
        }


        private void Pantalla8_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            RefrescarListado();
            //dataGridViewListadoUsuarios.DataSource = ListadoDatosClasses.ListadoUsuarios;

            ConfigurarColumnaIconoDelete();
            ConfigurarColumnaIconoEditar();
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

            string columnName = dataGridViewListadoUsuarios.Columns[e.ColumnIndex].Name;
            DataGridViewRow clickedRow = dataGridViewListadoUsuarios.Rows[e.RowIndex];

            if (columnName == "IconoDelete")
            {
                Usuario usuarioAEliminar = clickedRow.DataBoundItem as Usuario;

                if (usuarioAEliminar != null)
                {
                    var confirm = MessageBox.Show(
                          "¿Seguro que deseas eliminar este usuario?",
                          "Confirmación",
                          MessageBoxButtons.YesNo,
                          MessageBoxIcon.Warning);

                    if (confirm == DialogResult.Yes)
                    {

                        ListadoDatosClasses.ListadoUsuarios.Remove(usuarioAEliminar);
                        ActualizarAlturaDataGridView();
                    }
                }

            }
            if (columnName == "iconoEdit")
            {
                Pantalla7 p = new Pantalla7(clickedRow.DataBoundItem as Usuario);
                p.FormClosed += (s, args) => RefrescarListado();
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

        private void buttonExportarJSON_Click(object sender, EventArgs e)
        {
            ListadoDatosClasses.guardarDatos();
            RefrescarListado();

        }

        private void buttonImportarJSON_Click(object sender, EventArgs e)
        {
            ListadoDatosClasses.importJSONFromNewDirectory();
            RefrescarListado();
        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            Pantalla2 pantalla2 = new Pantalla2();
            pantalla2.Show();

        }

        public void RefrescarListado()
        {
            dataGridViewListadoUsuarios.DataSource = null;
            dataGridViewListadoUsuarios.DataSource = ListadoDatosClasses.ListadoUsuarios;
        }
        private void buttonCrearUser_Click(object sender, EventArgs e)
        {

            Pantalla5 pantalla5 = new Pantalla5();
            pantalla5.Show();

        }


        private void buttonUsuarios_Click(object sender, EventArgs e)
        {
            ListadoDatosClasses.guardarDatos();
            Pantalla8 pantalla8 = new Pantalla8();
            pantalla8.Show();
            this.Hide();
        }

        private void buttonInicio_Click_1(object sender, EventArgs e)
        {
            ListadoDatosClasses.exportProjects();
            Pantalla2 pantalla2 = new Pantalla2();
            pantalla2.Show();
            this.Close();
        }
    }
}
