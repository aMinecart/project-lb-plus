/**
 * Purpose: Test file in C++
 * 
 * Author: Owen Colley
 * Date: 9/5/24
 * 
 */

#include <iostream>
#include <string>

char getGameType () {
  do {
    std::cout << "[S]olve, [D]raft, or [E]ndless? ";
    char gameType;
    std::cin >> gameType;
    gameType = toupper(gameType);
  } while (gameType != 'S' && gameType != 'D' && gameType != 'E');
  return gameType;
}

int main() {
  const char GAME_TYPE = getGameType();
  std::cout << "Game type: " << GAME_TYPE << std::endl;
  
  return 0;
}
