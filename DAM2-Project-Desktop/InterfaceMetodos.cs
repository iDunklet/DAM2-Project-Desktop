using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel; // Necesario para BindingList<T>
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq; // Necesario para .ToList()

namespace DAM2_Project_Desktop
{

    internal interface InterfaceMetodos
    {
        // Propiedad de solo lectura para la carpeta de exportación
        string CarpetaExportacion => Path.Combine(Directory.GetCurrentDirectory(), "Exports");

        // --- Clase de Soporte para la Deserialización (Importación) ---
        public class DatosExportacion
        {
            public DateTime FechaExportacion { get; set; }
            public string VersionSistema { get; set; }
            public object Metadatos { get; set; }

            // Usamos List<T> para la deserialización desde JSON
            public List<Proyecto> Proyectos { get; set; }
            public List<Usuarios> Usuarios { get; set; }
            public List<Tarea> Tareas { get; set; }
        }

        // --- Método de Exportación ---
        bool ExportarTodoAJson()
        {
            try
            {
                // Crear carpeta Exports si no existe
                if (!Directory.Exists(CarpetaExportacion))
                    Directory.CreateDirectory(CarpetaExportacion);

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
                    // Convertir BindingList<T> a List<T> para una serialización JSON más limpia
                    Proyectos = ListadoDatosClasses.ListadoProyectos.ToList(),
                    Usuarios = ListadoDatosClasses.ListadoUsuarios.ToList(),
                    Tareas = ListadoDatosClasses.ListaTareas.ToList()
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

        // --- Método para Abrir la Carpeta ---
        void AbrirCarpetaExports()
        {
            if (!Directory.Exists(CarpetaExportacion))
                Directory.CreateDirectory(CarpetaExportacion);

            Process.Start(new ProcessStartInfo("explorer.exe", CarpetaExportacion) { UseShellExecute = true });
        }

        // --- Método de Importación ---
        bool ImportarTodoDesdeJson()
        {
            try
            {
                using (OpenFileDialog openDialog = new OpenFileDialog())
                {
                    openDialog.Filter = "Archivos JSON (*.json)|*.json";
                    openDialog.Title = "Seleccionar archivo JSON para importar";
                    openDialog.InitialDirectory = CarpetaExportacion;

                    if (openDialog.ShowDialog() == DialogResult.OK)
                    {
                        string json = File.ReadAllText(openDialog.FileName);
                        var datosImportados = JsonConvert.DeserializeObject<DatosExportacion>(json);

                        if (datosImportados != null)
                        {
                            // 1. Limpiar datos existentes
                            ListadoDatosClasses.ListadoProyectos.Clear();
                            ListadoDatosClasses.ListadoUsuarios.Clear();
                            ListadoDatosClasses.ListaTareas.Clear();

                            // 2. Cargar nuevos datos usando foreach (necesario para BindingList<T>)
                            if (datosImportados.Usuarios != null)
                            {
                                foreach (var usuario in datosImportados.Usuarios)
                                    ListadoDatosClasses.ListadoUsuarios.Add(usuario);
                            }

                            if (datosImportados.Tareas != null)
                            {
                                foreach (var tarea in datosImportados.Tareas)
                                    ListadoDatosClasses.ListaTareas.Add(tarea);
                            }

                            if (datosImportados.Proyectos != null)
                            {
                                foreach (var proyecto in datosImportados.Proyectos)
                                    ListadoDatosClasses.ListadoProyectos.Add(proyecto);
                            }

                            MessageBox.Show(
                                $"✅ Importación completada!\n\n" +
                                $"📊 Proyectos importados: {ListadoDatosClasses.ListadoProyectos.Count}\n" +
                                $"👥 Usuarios importados: {ListadoDatosClasses.ListadoUsuarios.Count}\n" +
                                $"✅ Tareas importadas: {ListadoDatosClasses.ListaTareas.Count}",
                                "Importación Exitosa",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            return true;
                        }
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error al importar: {ex.Message}", "Error de Importación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}