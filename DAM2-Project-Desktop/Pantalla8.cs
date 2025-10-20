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
    public partial class Pantalla8 : Form
    {
        public Pantalla8()
        {
            InitializeComponent();
            this.Load += new EventHandler(Pantalla8_Load); // Asegurar la suscripción si no está en Designer.cs
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
                null  // IconoDelete
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
