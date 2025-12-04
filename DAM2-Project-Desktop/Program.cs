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

            ListadoDatosClasses.inicioDatosClasses();

            //ListadoDatosClasses.importProjects();
            MessageBox.Show("Proyectos cargados: " + ListadoDatosClasses.ListadoProyectos.Count);
            ListadoDatosClasses.importUsers();

            Application.Run(new Pantalla1());
            //chenhan la ha liado 

        }
    }
}
