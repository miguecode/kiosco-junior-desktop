namespace Vista
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            try
            {
                Application.Run(new FrmLogin());
            } catch(Exception ex)
            {
                Console.Write(ex.ToString());
            }
            //ControladorSerial.ExportarAutomaticamente();
        }
    }
}