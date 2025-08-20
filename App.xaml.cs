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

            MainWindow mainView = new MainWindow();
            // Create the controller and pass it the view it will control
            Gameboard gameController = new Gameboard(mainView);

            mainView.Show(); // The controller is now in charge of the view.

            // You might also need to pass the controller to the view if
            // view events (like button clicks) need to call it.
            // mainView.GameController = gameController;
        }
    }

}
