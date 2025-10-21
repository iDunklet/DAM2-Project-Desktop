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

            button1.Size = Dimencions.Scale(new Size(200, 60), this.ClientSize);
            button2.Size = Dimencions.Scale(new Size(200, 60), this.ClientSize);
            button3.Size = Dimencions.Scale(new Size(200, 60), this.ClientSize);
            button4.Size = Dimencions.Scale(new Size(200, 60), this.ClientSize);
            button5.Size = Dimencions.Scale(new Size(200, 60), this.ClientSize);
            button6.Size = Dimencions.Scale(new Size(200, 60), this.ClientSize);
            button7.Size = Dimencions.Scale(new Size(200, 60), this.ClientSize);

            // Escalar DataGridView
            dataGridViewListadoUsuarios.Size = Dimencions.Scale(new Size(1200, 151), this.ClientSize);

            // Escalar columnas
            float scaleX = (float)this.ClientSize.Width / 1440;
            ImgPerfil.Width = (int)(30 * scaleX);
            Username.Width = (int)(150 * scaleX);
            Nombre.Width = (int)(175 * scaleX);
            Apellidos.Width = (int)(285 * scaleX);
            Email.Width = (int)(250 * scaleX);
            Curso.Width = (int)(100 * scaleX);
            iconoEditar.Width = (int)(40 * scaleX);
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
            // --- CÓDIGO PARA AÑADIR LAS FILAS DE PRUEBA ---

            // Fila 1 (Par)
            dataGridViewListadoUsuarios.Rows.Add(
                null, // ImgPerfil
                "juanp", // Username
                "Juan",
                "Pérez García",
                "juan.perez@ejemplo.com",
                "1º DAM",
                null, // iconoEditar
               GetImgIconDelete()
            );

            // Fila 2 (Impar/Alterna)
            dataGridViewListadoUsuarios.Rows.Add(
                null, // ImgPerfil
                "anal", // Username
                "Ana",
                "López Fernández",
                "ana.lopez@ejemplo.com",
                "2º DAW",
                null, // iconoEditar
                null  // IconoDelete
            );

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = dataGridViewListadoUsuarios.Columns[e.ColumnIndex].Name;

            if (columnName == "IconoDelete")
            {
                dataGridViewListadoUsuarios.Rows.RemoveAt(e.RowIndex);

            }
            if (columnName == "iconoEdit")
            {
                //falta
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
