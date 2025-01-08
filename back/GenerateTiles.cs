using System.Security.Cryptography;
using System;

namespace EverySecondLetterBattle;

/*
 Generates tiles for players
 first itteration fills hands
 adds one tile when player "plays" a tile
 should be weighted for most common letters (no full hand of XYZ)
 */

public class GenerateTiles
{
    
    public GenerateTiles()
    {
    }
    
    private static Random _random = new Random();
    private int rnd = _random.Next(1, 1000);

    public void letterSelector()
    {
        if (rnd <= 78)
        {
            
        }
    }
    
}
