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

    // returns if string has any of the same letters next to each other
    private boolean SimilarNeighborLevels(string word) {
        for (int i = 0; i < word.length()-1) {
            if (word[i] == word[i+1]) {
                return true;
            }
        } return false;
    }

    // returns number of unique letters found in both passed in words
    private int NumUniqueLetters(string word1, string word2) {
        int count = 0;
        foreach (char letter : word1) {
            if (word2.indexOf(letter) != -1) {
                ++count;
            }
        }
        return count;
    }

    // takes a difficulty and number of words solution to create a random preset based on difficulty, then fills it with letters.
    private Level ReturnRandomLevel(int difficulty) {
        Level myLevel;
        // set myLevel to an empty based on difficulty
        switch(difficulty) {
            case 0: myLevel = {{' ', "abc"}, {' ', "bcd"}}; break;
            case 1: myLevel = {{' ', "abc"}, {' ', "bcd"}}; break;
            case 2: myLevel = {{' ', "abc"}, {' ', "bcd"}}; break;
            case 3: myLevel = {{' ', "abc"}, {' ', "bcd"}}; break;
            case 4: myLevel = {{' ', "abc"}, {' ', "bcd"}}; break;
            case 5: myLevel = {{' ', "abc"}, {' ', "bcd"}}; break;
            default: myLevel = {{' ', "abc"}, {' ', "bcd"}}; break;
        }

        Random random = new Random();
        finalWord = "";
        // set combinedWord to legal words to fill myLevel with
        // legal words need the second word to start with the letter of the first word and to add to the correct length
        while (NumUniqueLetters(combinedWord) != myLevel.size()) {
            string randWord1;
            do {
                randWord1 = dictionary.ElementAt(random.Next(myLevel.length()));
            } while (SimilarNeighborLetters(randWord1);
            
            const char LAST_LETTER = RAND_WORD1[word.length() - 1];
            string randWord2;
            do {
                randWord2 = dictionary.ElementAt(random.Next(myLevel.length()));
            } while (LAST_LETTER != randWord2[0] || SimilarNeighborLetter(randWord2)); // make sure 2nd word starts with letter 1st word ends on
            
            finalWord = randWord1 + randWord2.substr(1); // combine words and get rid of the duplicated letter
        }
        
        // fill myLevel with finalString letters
        for (int i = 0; i < myLevel.length; ++i) {
            myLevel[i] = {finalString[i], myLevel[i][1]};
        }
        return myLevel;
    }

    // prints all possible word combos in level
    public static void Main(string[] args) {
        LoadDictionary("dictionary.txt");
    }
}
*/