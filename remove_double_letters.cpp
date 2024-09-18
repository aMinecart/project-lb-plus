/**
 * Purpose: Add words from dictionary with double letters next to each other to new dictionary
 * 
 * Author: Owen Colley
 * Date: 9/18/24
 * 
 */

#include <iostream>
#include <string>
#include <fstream>

bool duplicateLetters(std::string word) {
    char prevLetter = ' ';
    foreach (char letter : word) {
        if (letter == prevLetter) {
            return true;
        }
        prevLetter = letter;
    }
    return false;
}

int main() {
    std::ifstream fin(dictionary.c_str());
    std::ofstream fout(new_dictionary.c_str());
    if (!fin || !fout) {
        std::cerr << "Cannot open dictionary." << std::endl;
        exit(1);
    }
    
    std::string word;
    while(fin >> word) {
        if (!duplicateLetters(word)) {
            new_dictionary << word << std::endl;
        }
    }
      
    return 0;
}
