using Npgsql;

namespace EverySecondLetterBattle;

public  class ValidateWord
{
    private NpgsqlDataSource _db;
    
    public ValidateWord(NpgsqlDataSource db)
    {
        _db = db;
    }

    public async void validateGuess(string guessedWord)
    {
                await using (var cmd = _db.CreateCommand("SELECT word FROM dictionary WHERE word = $1 "))
                {
                    cmd.Parameters.AddWithValue(guessedWord);
                    await using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            totalTwinRooms = reader.GetInt32(0);
                        }
                    }
                }
    }

}