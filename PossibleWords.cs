/*
* Purpose: Print all possible word combos on a level
* Author: Owen Colley
* Date: 9/9/24
*/

/*
using System;
using System.Collections.Generic;
using System.IO;

public class Program {
    // hash set to store scrabble dictionary
    private static readonly HashSet<string> dictionary = new HashSet<string>();

    // list to store all possible combos
    private static List<string> combos = new List<string>();

    // import scrabble dictionary
    static void LoadDictionary(string filePath) {
        using (StreamReader reader = new StreamReader(dictionary.txt)) {
            string line;
            while ((line = reader.ReadLine()) != null) {
                dictionary.Add(line.Trim());
            }
        }
    }

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
        
        // return if word additions not possible
        if (!dictionary.ContainsSubstring(combo)) {
            return;
        }

        // add combo if word fully matches dictionary word
        if (dictionary.Contains(combo)) {
            combos.Add(string.Join("", wordStack));
        }

        // grab letter options given last used letter
        const string LETTER_OPTIONS = letterOptions[combo[combo.Length - 1]];

        // uses recursion to iterate through every possible letter addition to the combo
        foreach (char letter in LETTER_OPTIONS) {
            GetPossibleCombos(combo + letter);
        }
    }

    // prints all possible word combos in level
    public static void Main(string[] args) {
        LoadDictionary("dictionary.txt");
        combos.Clear();
        GetPossibleCombos(" ");

        // print all possible combos
        foreach (string combo in allCombos) {
            Console.WriteLine(combo);
        }
    }
}
*/