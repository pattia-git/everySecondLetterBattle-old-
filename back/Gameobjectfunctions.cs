namespace EverySecondLetterBattle;

public class Gameobjectfunctions
{
    public Gameobjectfunctions(GameObject)
    {
        /* ? = GameObjectNamn*/
        
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