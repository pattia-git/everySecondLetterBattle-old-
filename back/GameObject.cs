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
    public string letterBoard = "";
    public int whosTurn;
    public int player1Points;
    public int player2Points;
    public List<string> usedValidWords = new List<string>();
    public List<string> usedInvalidWords = new();
    public List<string>? player1Tiles = new List<string>();
    public List<string> player2Tiles = new List<string>();
    
    public GameObject(){}
    
}