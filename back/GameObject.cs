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
    public bool whosTurn;
    public int player1Points;
    public int player2Points;
    public List<string> usedWords;
    public List<string> player1Tiles;
    public List<string> player2Tiles;

    public GameObject(){}


    public void checkUsedWords()
    {
        
    }
    public void checkValidWord()
    {
        
    }
    
    

    public void Player1Points()
    {
        foreach(var tile in guessedWord)
        {
            player1Points += 1;
        }
    }
    public void Player2Points()
    {
        foreach (var tile in guessedWord)
        {
            player2Points += 1;
        }
    }
    
}