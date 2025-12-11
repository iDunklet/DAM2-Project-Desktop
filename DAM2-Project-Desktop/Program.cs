namespace DAM2_Project_Desktop
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();


            //ListadoDatosClasses.inicioDatosClasses();
            //ListadoDatosClasses.guardarDatos();

            ListadoDatosClasses.cargarDatos();
            //ListadoDatosClasses.importProjects();
            //MessageBox.Show("Proyectos cargados: " + ListadoDatosClasses.ListadoProyectos.Count);

            Application.Run(new Pantalla2());

        }
    }
}
