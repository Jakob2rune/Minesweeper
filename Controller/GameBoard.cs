using Minesweeper;
using System;
using System.Diagnostics;
using System.Windows;

public class GameBoard
{

    //Delegates and events
    public event Action<double> TimeUpdated;
    public event Action<int[,]> GridUpdated;
    public event Action GameWon;
    public event Action GameLost;


    private Window _window;
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

    public GameBoard(Window window, DifficultyLevel difficultyLevel)
    {
        _window = window;
        _amountOfRevealedCells = 0;
        _timeElapsed = 0;
        _isRunning = false;
        _difficultyLevel = difficultyLevel;
        SetDifficulty(difficultyLevel);
    }
    public GameBoard(DifficultyLevel difficultyLevel)
    {
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


    //Delegate methods to update UI
    private void OnTimeUpdated(double time)
    {
        TimeUpdated?.Invoke(time);
    }

    private void OnGridUpdated(int[,] grid)
    {
        GridUpdated?.Invoke(grid);
    }

    private void OnGameWon()
    {
        GameWon?.Invoke();
    }
}
