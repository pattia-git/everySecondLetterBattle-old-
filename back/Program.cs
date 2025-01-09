namespace EverySecondLetterBattle;

class Program
{
    static async Task Main(string[] args)
    {
        Database database = new();
        var db = database.Connection();
        GameLoop gameLoop = new GameLoop(db);
        
        await gameLoop.startGame();
        
        Console.WriteLine("I can go trough!");
    }
}