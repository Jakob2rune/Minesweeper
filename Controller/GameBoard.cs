using System;
using System.Diagnostics;

public class GameBoard
{
    private MainWindow _mainWindow;
    private int[,] _grid;
    private int _amountOfMines;
    private int _amountOfRevealedCells;
    private int _amountOfRows;
    private int _amountOfColumns;
    private double _timeElapsed;
    private bool _isRunning;
    private Stopwatch _stopWatch = new Stopwatch();
    private DifficultyLevel _difficultyLevel;

    public enum DifficultyLevel
    {
        Easy,
        Medium,
        Hard
    }

    public GameBoard(MainWindow mainWindow, DifficultyLevel difficultyLevel)
    {
        _mainWindow = mainWindow;
        _amountOfRevealedCells = 0;
        _timeElapsed = 0;
        _isRunning = false;
        _difficultyLevel = difficultyLevel;
        SetDifficulty(difficultyLevel);

    }

    public void RevealCell()
    {
        // Implementation
    }

    public void FlagCell()
    {
        // Implementation
    }

    public void UnflagCell()
    {
        // Implementation
    }

    public void StartGame()
    {
        _stopWatch.Start();
        _isRunning = true;
        _timeElapsed = 0;
        _amountOfRevealedCells = 0;
        // Initialize the grid with mines and numbers
        // This would typically involve placing mines randomly and calculating adjacent mine counts
    }

    public void EndGame()
    {
        _isRunning = false;
        // Logic to handle game over, such as revealing all mines or showing a message
    }

    public void ResetGame()
    {
        _stopWatch.Reset();
        _isRunning = false;
        _timeElapsed = 0;
        _amountOfRevealedCells = 0;
        // Reset the grid and other game state variables
    }

    public void UpdateTimeElapsed()
    {
        if (_isRunning)
        {
            _timeElapsed = _stopWatch.Elapsed.TotalSeconds;
            _mainWindow.UpdateTimeDisplay(_timeElapsed); // Assuming MainWindow has a method to update the display
        }
    }

    public void UpdateGridDisplay()
    {
        _mainWindow.UpdateGrid(_grid); // Assuming MainWindow has a method to update the grid display
    }

    public void CheckWinCondition()
    {
        if (_amountOfRevealedCells + _amountOfMines == _amountOfRows * _amountOfColumns)
        {
            EndGame();
            _mainWindow.ShowWinMessage(); // Assuming MainWindow has a method to show a win message
        }
    }

    public void SetDifficulty(DifficultyLevel difficulty)
    {
        switch (difficulty)
        {
            case DifficultyLevel.Easy:
                _amountOfRows = 8;
                _amountOfColumns = 8;
                _amountOfMines = 10;
                break;
            case DifficultyLevel.Medium:
                _amountOfRows = 16;
                _amountOfColumns = 16;
                _amountOfMines = 40;
                break;
            case DifficultyLevel.Hard:
                _amountOfRows = 16;
                _amountOfColumns = 30;
                _amountOfMines = 99;
                break;
        }
        _difficultyLevel = difficulty;
    }
}

// You'll need to define this class somewhere in your project
public class MainWindow
{
    public void UpdateTimeDisplay(double timeElapsed)
    {
        // Implementation
    }

    public void UpdateGrid(int[,] grid)
    {
        // Implementation
    }

    public void ShowWinMessage()
    {
        // Implementation
    }
}