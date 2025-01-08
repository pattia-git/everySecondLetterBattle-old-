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

    public void letterSelector(List<string> activePlayer)
    {
        
        // add letter based on comonality in dictionary
        // ripped from Wikipedia https://en.wikipedia.org/wiki/Letter_frequency#Relative_frequencies_of_letters_in_the_English_language
        // doesn't add upp to 100%, but lets assume the remainder 0.41% is other characters
    
        int generatedRnd = _random.Next(1, 9959);
        double rnd = generatedRnd / 100;
        
        if (rnd <= 7.8)
        {
            activePlayer.Add("A");
        } else if (rnd > 7.8 && rnd <= 9.8)
        {
            activePlayer.Add("B");
        } else if (rnd > 9.8 && rnd <= 13.8)
        {
            activePlayer.Add("C");
        } else if (rnd > 13.8 && rnd <= 17.6)
        {
            activePlayer.Add("D");
        } else if (rnd > 17.6 && rnd <= 28.6)
        {
            activePlayer.Add("E");
        } else if (rnd > 28.6 && rnd <= 30)
        {
            activePlayer.Add("F");
        } else if (rnd > 30 && rnd <= 33)
        {
            activePlayer.Add("G");
        } else if (rnd > 33 && rnd <= 35.3)
        {
            activePlayer.Add("H");
        } else if (rnd > 35.3 && rnd <= 43.9)
        {
            activePlayer.Add("I");
        } else if (rnd > 43.9 && rnd <= 44.11)
        {
            activePlayer.Add("J");
        } else if (rnd > 44.11 && rnd <= 45.08)
        {
            activePlayer.Add("K");
        } else if (rnd > 45.08 && rnd <= 50.38)
        {
            activePlayer.Add("L");
        } else if (rnd > 50.38 && rnd <= 53.08)
        {
            activePlayer.Add("M");
        } else if (rnd > 53.08 && rnd <= 60.28)
        {
            activePlayer.Add("N");
        } else if (rnd > 60.28 && rnd <= 66.38)
        {
            activePlayer.Add("O");
        } else if (rnd > 66.38 && rnd <= 69.18)
        {
            activePlayer.Add("P");
        } else if (rnd > 69.18 && rnd <= 69.37)
        {
            activePlayer.Add("Q");
        } else if (rnd > 69.37 && rnd <= 76.67)
        {
            activePlayer.Add("R");
        } else if (rnd > 76.67 && rnd <= 85.37)
        {
            activePlayer.Add("S");
        } else if (rnd > 85.37 && rnd <= 92.07)
        {
            activePlayer.Add("T");
        } else if (rnd > 92.07 && rnd <= 95.37)
        {
            activePlayer.Add("U");
        } else if (rnd > 95.37 && rnd <= 96.37)
        {
            activePlayer.Add("V");
        } else if (rnd > 96.37 && rnd <= 97.28)
        {
            activePlayer.Add("W");
        } else if (rnd > 97.28 && rnd <= 97.55)
        {
            activePlayer.Add("X");
        } else if (rnd > 97.55 && rnd <= 99.15)
        {
            activePlayer.Add("Y");
        }  else if (rnd > 99.15 && rnd <= 99.59)
        {
            activePlayer.Add("Z");
        }
    }
    
}
