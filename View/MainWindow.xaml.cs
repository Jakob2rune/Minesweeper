using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Minesweeper
{
    public partial class MainWindow : Window
    {
        private GameBoard _gameBoard;

        public MainWindow()
        {
            InitializeComponent();

            // Create game board and subscribe to events
            _gameBoard = new GameBoard(GameBoard.DifficultyLevel.Easy);
            SubscribeToGameEvents();
        }

        private void SubscribeToGameEvents()
        {
            // Subscribe to all GameBoard events
            _gameBoard.TimeUpdated += GameBoard_TimeUpdated;
            _gameBoard.GridUpdated += GameBoard_GridUpdated;
            _gameBoard.GameWon += GameBoard_GameWon;
            _gameBoard.GameLost += GameBoard_GameLost;
        }

        private void UnsubscribeFromGameEvents()
        {
            // Always unsubscribe to prevent memory leaks
            _gameBoard.TimeUpdated -= GameBoard_TimeUpdated;
            _gameBoard.GridUpdated -= GameBoard_GridUpdated;
            _gameBoard.GameWon -= GameBoard_GameWon;
            _gameBoard.GameLost -= GameBoard_GameLost;
        }

        // Event handler methods
        private void GameBoard_TimeUpdated(double timeElapsed)
        {
            // Update your timer display
            // This runs on the UI thread automatically
            //timerTextBlock.Text = timeElapsed.ToString("F1") + "s";
        }

        private void GameBoard_GridUpdated(int[,] grid)
        {
            // Update your game grid UI
            UpdateGameGridUI(grid);
        }

        private void GameBoard_GameWon()
        {
            // Show win message
            MessageBox.Show("Congratulations! You won!", "Minesweeper",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void GameBoard_GameLost()
        {
            // Show lose message
            MessageBox.Show("Game Over! You hit a mine.", "Minesweeper",
                MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void UpdateGameGridUI(int[,] grid)
        {
            // Your implementation to update the visual grid
            // This could involve updating buttons, labels, etc.
        }

        // Don't forget to unsubscribe when the window closes
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            UnsubscribeFromGameEvents();
        }

        // Example button click handler to start game
        private void StartGameButton_Click(object sender, RoutedEventArgs e)
        {
            _gameBoard.StartGame();
        }
    }
}