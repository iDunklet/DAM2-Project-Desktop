using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM2_Project_Desktop
{
    internal interface InterfaceMetodos
    {
        string CarpetaExportacion => Path.Combine(Directory.GetCurrentDirectory(), "Exports");

        /// <summary>
        /// Exporta TODOS los datos del sistema a JSON en la carpeta Exports
        /// </summary>
        bool ExportarTodoAJson()
        {
            try
            {
                // Crear carpeta Exports si no existe
                if (!Directory.Exists(CarpetaExportacion))
                    Directory.CreateDirectory(CarpetaExportacion);

                // Generar nombre de archivo con fecha
                string nombreArchivo = $"Backup_DAM2_{DateTime.Now:yyyyMMdd_HHmmss}.json";
                string rutaCompleta = Path.Combine(CarpetaExportacion, nombreArchivo);

                var datosCompletos = new
                {
                    FechaExportacion = DateTime.Now,
                    VersionSistema = "DAM2_Project_Desktop",
                    Metadatos = new
                    {
                        TotalProyectos = ListadoDatosClasses.ListadoProyectos.Count,
                        TotalUsuarios = ListadoDatosClasses.ListadoUsuarios.Count,
                        TotalTareas = ListadoDatosClasses.ListaTareas.Count
                    },
                    Proyectos = ListadoDatosClasses.ListadoProyectos,
                    Usuarios = ListadoDatosClasses.ListadoUsuarios,
                    Tareas = ListadoDatosClasses.ListaTareas
                };

                var settings = new JsonSerializerSettings
                {
                    Formatting = Formatting.Indented,
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                    NullValueHandling = NullValueHandling.Ignore
                };

                string json = JsonConvert.SerializeObject(datosCompletos, settings);
                File.WriteAllText(rutaCompleta, json, System.Text.Encoding.UTF8);

                MessageBox.Show(
                    $"✅ Exportación completada!\n\n" +
                    $"📁 Ubicación: {CarpetaExportacion}\n" +
                    $"📄 Archivo: {nombreArchivo}\n" +
                    $"📊 Proyectos: {ListadoDatosClasses.ListadoProyectos.Count}\n" +
                    $"👥 Usuarios: {ListadoDatosClasses.ListadoUsuarios.Count}\n" +
                    $"✅ Tareas: {ListadoDatosClasses.ListaTareas.Count}",
                    "Exportación Exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error al exportar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Método adicional: Abrir carpeta Exports
        /// </summary>
        void AbrirCarpetaExports()
        {
            if (!Directory.Exists(CarpetaExportacion))
                Directory.CreateDirectory(CarpetaExportacion);

            System.Diagnostics.Process.Start("explorer.exe", CarpetaExportacion);
        }
        bool ImportarTodoDesdeJson()
        {
            try
            {
                using (OpenFileDialog openDialog = new OpenFileDialog())
                {
                    openDialog.Filter = "Archivos JSON (*.json)|*.json";
                    openDialog.Title = "Seleccionar archivo JSON para importar";

                    if (openDialog.ShowDialog() == DialogResult.OK)
                    {
                        string json = File.ReadAllText(openDialog.FileName);
                        var datosImportados = JsonConvert.DeserializeObject<DatosExportacion>(json);

                        if (datosImportados != null)
                        {
                            // Limpiar datos existentes
                            ListadoDatosClasses.ListadoProyectos.Clear();
                            ListadoDatosClasses.ListadoUsuarios.Clear();
                            ListadoDatosClasses.ListaTareas.Clear();

                            // Cargar nuevos datos
                            foreach (var usuario in datosImportados.Usuarios)
                                ListadoDatosClasses.ListadoUsuarios.Add(usuario);

                            foreach (var tarea in datosImportados.Tareas)
                                ListadoDatosClasses.ListaTareas.Add(tarea);

                            foreach (var proyecto in datosImportados.Proyectos)
                                ListadoDatosClasses.ListadoProyectos.Add(proyecto);

                            MessageBox.Show("Datos importados correctamente");
                            return true;
                        }
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al importar: {ex.Message}");
                return false;
            }
        }
        public class DatosExportacion
        {
            public DateTime FechaExportacion { get; set; }
            public string VersionSistema { get; set; }
            public System.Collections.Generic.List<Proyecto> Proyectos { get; set; }
            public System.Collections.Generic.List<Usuarios> Usuarios { get; set; }
            public System.Collections.Generic.List<Tarea> Tareas { get; set; }
        }



    }
}
