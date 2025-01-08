namespace EverySecondLetterBattle;
using System.Security.Cryptography;
using EverySecondLetterBattle;
using Npgsql;

class Program
{
    public static void Main(string[] args)
    {
        Database database = new();

        var db = database.Connection();
        Console.WriteLine("Guess a word");
        string guessedWord = Console.ReadLine();
    }
    ValidateWord validate = new();

}

