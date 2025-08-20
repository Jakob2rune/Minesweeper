using System;

public class GameBoard
{
	MainWindow _mainWindow;
	int [,] _grid;
	int _amountOfMines;
	int _amountOfRevealedCells;
	int _amountOfRows;
	int _amountOfColumns;
	double _timeElapsed;
	bool _isRunning;
	StopWatch stopWatch = new StopWatch();


    enum DifficultyLevel
	{
		Easy,
		Medium,
        Hard
    }



    public GameBoard(MainWindow mainwindow, int[,]grid, int amountOfMines, int amountOfRows, int amountOfColumns,
		double timeElapsed, bool isRunning, enum difficultyLevel)
	{
		_mainWindow = mainwindow
		_grid = grid;
		_amountOfMines = amountOfMines;
		_amountOfRevealedCells = 0;
		_amountOfRows = amountOfRows;
		_amountOfColumns = amountOfColumns;
		_timeElapsed = timeElapsed;
		_isRunning = isRunning;
		DifficultyLevel = difficultyLevel;
	}

	public void RevealCell()
	{

	}

	public void FlagCell()
	{
	}

	public void UnflagCell()
	{
	}

	public void StartGame()
	{
		stopWatch.Start();
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
		stopWatch.Reset();
		_isRunning = false;
		_timeElapsed = 0;
		_amountOfRevealedCells = 0;
		// Reset the grid and other game state variables
	}
	public void UpdateTimeElapsed()
	{
		if (_isRunning)
		{
			_timeElapsed = stopWatch.Elapsed.TotalSeconds;
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
	}

}
