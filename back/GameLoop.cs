using Npgsql;

namespace EverySecondLetterBattle;
/*
 contains the "game"
 should not save data locally, but in GameObject
 */


public class GameLoop
{
 
 public GameObject _gameObject = new GameObject();
 public GenerateTiles _generateTiles = new GenerateTiles();
 public Queries _queries;

 private NpgsqlDataSource _db;
 public GameLoop(NpgsqlDataSource db)
 {
 _db = db;
 _queries = new Queries(_db);
 }

 public async Task startGame()
 {
  // Sets initial players turn and popluates each players tiles
  _gameObject.whosTurn = 1;
  for (int i = 0; i < 7; i++)
  {
   _generateTiles.LetterSelector(_gameObject.player1Tiles);
   _generateTiles.LetterSelector(_gameObject.player2Tiles);
  }

  while (_gameObject.player1Points < 10 || _gameObject.player2Points < 10)
  {
   await playerTurn();
  }

  if (_gameObject.player1Points >= 10)
  {
   Console.WriteLine("player one wins!");
  } else if (_gameObject.player2Points >= 10)
  {
   Console.WriteLine("player two wins!");
  }
  
  
 }

 public async Task playerTurn()
 {
  if (_gameObject.letterBoard.Length == 10)
  {
   _gameObject.letterBoard = "";
  }

  // initial console for testing



  if (_gameObject.whosTurn == 1)
  {
   Console.WriteLine("Tiles player 1:");
   foreach (var letter in _gameObject.player1Tiles)
   {
    Console.WriteLine(letter);
   }

   Console.WriteLine("play a letter " + _gameObject.whosTurn + "(take index of guessed number)");
   string input = Console.ReadLine();
   int playedTile = int.Parse(input);

   _gameObject.letterBoard += _gameObject.player1Tiles[playedTile];
   _gameObject.player1Tiles.RemoveAt(playedTile);
   _generateTiles.LetterSelector(_gameObject.player1Tiles);


   Console.WriteLine(_gameObject.letterBoard);
   Console.WriteLine("do you also want to guess? (y)");

   input = Console.ReadLine();
   if (input == "y")
   {
    if (await _queries.GuessValidation(_gameObject.letterBoard) &&
        !_gameObject.usedValidWords.Contains(_gameObject.letterBoard))
    {
     _gameObject.player1Points += _gameObject.letterBoard.Length;
     _gameObject.usedValidWords.Add(_gameObject.letterBoard);
     _gameObject.letterBoard = "";
     Console.WriteLine("you have " + _gameObject.player1Points + " points");
    }
    else if (!_gameObject.usedInvalidWords.Contains(_gameObject.letterBoard))
    {
     _gameObject.usedInvalidWords.Add(_gameObject.letterBoard);
     if (_gameObject.player1Points != 0)
     {
      Console.WriteLine("line 95");
      _gameObject.player1Points -= 1;
     }

     Console.WriteLine("line 98");
     _gameObject.letterBoard = "";
    }
    // make guess
   }

   _gameObject.whosTurn = 2;

  }
  else
  {
   Console.WriteLine("Tiles player 2:");
   foreach (var letter in _gameObject.player2Tiles)
   {
    Console.WriteLine(letter);
   }

   Console.WriteLine("play a letter " + _gameObject.whosTurn + "(take index of guessed number)");
   string input = Console.ReadLine();
   int playedTile = int.Parse(input);

   _gameObject.letterBoard += _gameObject.player2Tiles[playedTile];
   _gameObject.player2Tiles.RemoveAt(playedTile);
   _generateTiles.LetterSelector(_gameObject.player2Tiles);


   Console.WriteLine(_gameObject.letterBoard);
   Console.WriteLine("do you also want to guess? (y)");

   input = Console.ReadLine();
   if (input == "y")
   {
    if (await _queries.GuessValidation(_gameObject.letterBoard) &&
        !_gameObject.usedValidWords.Contains(_gameObject.letterBoard))
    {
     _gameObject.player2Points += _gameObject.letterBoard.Length;
     _gameObject.usedValidWords.Add(_gameObject.letterBoard);
     _gameObject.letterBoard = "";
     Console.WriteLine("you have " + _gameObject.player2Points + " points");
    }
    else if (!_gameObject.usedInvalidWords.Contains(_gameObject.letterBoard))
    {
     _gameObject.usedInvalidWords.Add(_gameObject.letterBoard);
     if (_gameObject.player2Points != 0)
     {
      Console.WriteLine("line 95");
      _gameObject.player2Points -= 1;
     }

     Console.WriteLine("line 98");
     _gameObject.letterBoard = "";
    }
    // make guess
   }

   _gameObject.whosTurn = 1;

  }

 }
}