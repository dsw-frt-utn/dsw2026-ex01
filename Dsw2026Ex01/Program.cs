using Dsw2026Ex1.Data;
using Dsw2026Ex1.Views;

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
            Persistencia.InicializarDatos();
            ConsoleView consoleView = new ConsoleView();
            consoleView.DibujarMenu();
        }
    }
}