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
    
    private static Random _random = new();

    public void LetterSelector(List<string> activePlayer)
    {

        // add letter based on comonality in dictionary
        // ripped from Wikipedia https://en.wikipedia.org/wiki/Letter_frequency#Relative_frequencies_of_letters_in_the_English_language
        // doesn't add upp to 100%, but lets assume the remainder 0.41% is other characters
        
        Dictionary<string, double> alphabet = new Dictionary<string, double>();
        alphabet.Add("A", 7.8);
        alphabet.Add("B", 2);
        alphabet.Add("C", 4);
        alphabet.Add("D", 3.8);
        alphabet.Add("E", 11);
        alphabet.Add("F", 1.4);
        alphabet.Add("G", 3);
        alphabet.Add("H", 2.3);
        alphabet.Add("I", 8.6);
        alphabet.Add("J", 0.21);
        alphabet.Add("K", 0.97);
        alphabet.Add("L", 5.3);
        alphabet.Add("M", 2.7);
        alphabet.Add("N", 7.2);
        alphabet.Add("O", 6.1);
        alphabet.Add("P", 2.8);
        alphabet.Add("Q", 0.19);
        alphabet.Add("R", 7.3);
        alphabet.Add("S", 8.7);
        alphabet.Add("T", 6.7);
        alphabet.Add("U", 3.3);
        alphabet.Add("V", 1);
        alphabet.Add("W", 0.91);
        alphabet.Add("X", 0.27);
        alphabet.Add("Y", 1.6);
        alphabet.Add("Z",0.44);
        
        int generatedRnd = _random.Next(1, 9959);
        double randomPercentage = generatedRnd / 100;
        double previouspercentageAccumulation = 0;
        double percentageAccumulation = 0;
        
        foreach (var letter in alphabet)
        {
            percentageAccumulation += letter.Value;
            if (previouspercentageAccumulation < randomPercentage &&  randomPercentage <= percentageAccumulation)
            {
                activePlayer.Add(letter.Key);
                return;
            }
            previouspercentageAccumulation = percentageAccumulation;
        }

        
        
    }

}
