#include <iostream>
#include <limits>
#include "generateNumber.h"

/// <summary>
/// number guessing game! a hood classic for sure
/// </summary>
/// <returns></returns>
int main() {
	int userInput{};
	int generatedNumber = generateNumber(1, 100);
	std::cout << generatedNumber;

	do {
		std::cout << "\nEnter your guess: ";

		if (!(std::cin >> userInput)) {
			std::cout << "Invalid input! Please enter an integer.";

			std::cin.clear();
			std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
			continue;
		}

		if (userInput != generatedNumber) {
			if (userInput < generatedNumber) {
				std::cout << "Higher!";
			} else {
				std::cout << "Lower!";
			}
		}
	} while (userInput != generatedNumber);
	std::cout << "You did it!";

	return 0;
}