using System.Runtime.InteropServices.JavaScript;

namespace EverySecondLetterBattle;

/*
Contains game related data
- whos turn it is
- points
- guessed words
- tiles for each player
- played tiles
 */

public class GameObject
{
    public string letterBoard;
    public int whosTurn;
    public int player1Points;
    public int player2Points;
    public List<string> usedWords;
    public List<string> player1Tiles;
    public List<string> player2Tiles;

    public GameObject(){}
    
    
    

  
    
    
}