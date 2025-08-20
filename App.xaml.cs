using Minesweeper.Controller;
using System.Configuration;
using System.Data;
using System.Windows;

namespace Minesweeper
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            MainWindow mainWindow = new MainWindow();
            mainWindow.Title = "Minesweeper Game Menu";
            mainWindow.Width = 800;
            mainWindow.Height = 600;
            mainWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            mainWindow.Content = "Welcome to Minesweeper! Please select a difficulty level to start the game.";
            mainWindow.Show();
        }
    }

}
