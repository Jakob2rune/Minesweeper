using Minesweeper.Controller;
using System.Configuration;
using System.Data;
using System.Windows;

namespace Minesweeper
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // This creates your actual WPF MainWindow
            MainWindow mainWindow = new MainWindow();
            mainWindow.Title = "Minesweeper Game Menu";
            mainWindow.Width = 800;
            mainWindow.Height = 600;
            mainWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            
            // Instead of setting Content to a string, you should set up proper UI controls
            // mainWindow.Content = "Welcome to Minesweeper!...";
            
            mainWindow.Show();
        }
    }
}