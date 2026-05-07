using Dsw2026Ex01.Views;
using Dsw2026Ex01.Data;

namespace Dsw2026Ex01
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
            Persistencia.InicializarDatos();
            //ConsoleView consoleView = new ConsoleView();
            //consoleView.DibujarMenu();
            Application.Run(new ListarVehiculosView());
        }
    }
}