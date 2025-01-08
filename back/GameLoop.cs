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
  _gameObject.whosTurn = 1;
  for (int i = 0; i < 7; i++)
  {
   _generateTiles.letterSelector(_gameObject.player1Tiles);
   _generateTiles.letterSelector(_gameObject.player2Tiles);
  }
 }
 
}