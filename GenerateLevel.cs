/*
* Purpose: Generate a random letter box level
* Author: Owen Colley
* Date: 9/11/24
*/

/*
using System;
using System.Collections.Generic;
using System.IO;

public class Program {
    // hash set to store scrabble dictionary
    private static readonly HashSet<string> dictionary = new HashSet<string>();
  
    // import scrabble dictionary
    static void LoadDictionary(string filePath) {
        using (StreamReader reader = new StreamReader(dictionary.txt)) {
            string line;
            while ((line = reader.ReadLine()) != null) {
                dictionary.Add(line.Trim());
            }
        }
    }

    private Level getRandomLevelPreset(int difficulty) {
        const Level PRESET1 = {{' ', "abc"}, {' ', "bcd"}};
        const Level PRESET2 = {{' ', "abc"}, {' ', "bcd"}};
        const Level PRESET3 = {{' ', "abc"}, {' ', "bcd"}, {' ', "bcd"}};
        const Level PRESET4 = {{' ', "abc"}, {' ', "bcd"}, {' ', "bcd"}};
        const Level PRESET5 = {{' ', "abc"}, {' ', "bcd"}, {' ', "bcd"}, {' ', "bcd"}};
        const Level PRESET6 = {{' ', "abc"}, {' ', "bcd"}, {' ', "bcd"}, {' ', "bcd"}};
        
        switch(difficulty) {
            case 0: return PRESET1;
            case 1: return PRESET2;
            case 2: return PRESET3;
            case 3: return PRESET4;
            case 4: return PRESET5;
            case 5: return PRESET6;
        }
    }

    private Level returnRandomLevel(int difficulty) {
      emptyPreset = getRandomLevelPreset(difficulty);
    }

    // prints all possible word combos in level
    public static void Main(string[] args) {
        LoadDictionary("dictionary.txt");
    }
}
*/