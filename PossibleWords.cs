using System;
using System.Collections.Generic;
using System.IO;

public class Program {
    // import scrabble dictionary
    private static readonly string DICTIONARY = Convert.ToBase64String(File.ReadAllBytes(dictionary.txt));

    // define all nodes connected to each node
    private static readonly Dictionary<char, string> letterOptions = new Dictionary<char, string> {
        {' ', "abcdefgh"}, // the initial node when none have been given, returns all nodes
        {'a', "bfgh"},
        {'b', "afgh"},
        {'c', "defg"},
        {'d', "cefg"},
        {'e', "dcfgh"},
        {'f', "abcdfgh"},
        {'g', "abcdefg"},
        {'h', "abfge"}
    };

    // returns all possible subsequent words given initial letter combo or a space
    public static void GetPossibleCombos(string combo) {
        
        // grab next possible legal letters using last letter in combo
        string myLetterOptions = letterOptions[combo[combo.Length - 1]];

        foreach (char letter in myLetterOptions) {
            string newCombo = combo + letter;
            if (DICTIONARY.Contains(newCombo)) {
                if (DICTIONARY.Contains(newCombo + "\n")) {
                    Console.WriteLine("Combo: " + newCombo);
                }
                GetPossibleCombos(newCombo);
            }
        }
    }

    public static void Main(string[] args) {
        GetPossibleCombos(" ");
        Console.WriteLine();
    }
}
