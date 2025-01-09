using Npgsql;

namespace EverySecondLetterBattle;

public class Queries
{
    private NpgsqlDataSource _db;
    public Queries(NpgsqlDataSource db)
    {
        _db = db;
    }

    public async Task<bool> GuessValidation(string guess)
    {
        await using (var cmd = _db.CreateCommand("SELECT * FROM dictionary WHERE word = $1"))
        {
            cmd.Parameters.AddWithValue(guess);
            await using (var reader = await cmd.ExecuteReaderAsync())
            {
                if (reader.HasRows)
                {
                    return true;
                }
                return false;
            }
        }
    }
    
    public async void ShowOne(string id)
    {
        await using (var cmd = _db.CreateCommand("SELECT * FROM items WHERE id = $1"))
        {
            cmd.Parameters.AddWithValue(int.Parse(id));
            await using (var reader = await cmd.ExecuteReaderAsync())
            {
                while (await reader.ReadAsync())
                {
                    Console.WriteLine($"id: {reader.GetInt32(0)} \t name: {reader.GetString(1)} \t slogan: {reader.GetString(2)}");
                }
            }
        }
    }
}