namespace EverySecondLetterBattle;
/*
 contains the "game"
 should not save data locally, but in GameObject
 */


public class GameLoop
{
 public GameLoop()
 {
  
 }

 public GameObject _gameObject = new GameObject();
 public GenerateTiles _generateTiles = new GenerateTiles();

 public void startGame()
 {
  // Sets initial players turn and popluates each players tiles
  _gameObject.whosTurn = 1;
  for (int i = 0; i < 7; i++)
  {
   _generateTiles.letterSelector(_gameObject.player1Tiles);
   _generateTiles.letterSelector(_gameObject.player2Tiles);
  }
 }

 public void playerTurn()
 {

  if (_gameObject)
  {
   
  }
  
  // initial console for testing
  
  Console.WriteLine("Tiles player 1:" + _gameObject.player1Tiles);
  Console.WriteLine("Tiles player 2:" + _gameObject.player2Tiles);
  Console.WriteLine("take a guess player " + _gameObject.whosTurn + "(take index of guessed number)");
  string input = Console.ReadLine();
  int playedTile = int.Parse(input);
  
  
  

 }
 
 
}