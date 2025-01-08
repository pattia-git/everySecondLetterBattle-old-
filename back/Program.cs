namespace EverySecondLetterBattle;

class Program
{
    static void Main(string[] args)
    {
        Database database = new();
        var db = database.Connection();
        GameLoop gameLoop = new GameLoop(db);
        
        gameLoop.startGame();
        
        Console.WriteLine("Hello, World!");
    }
}