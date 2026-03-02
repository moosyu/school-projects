#include <iostream>
#include <string>

std::string getQuantityPhrase(int appleCount) {
    std::string phrase {};

    if (appleCount < 0) {
        phrase = "negative";
    } else if (appleCount == 0) {
        phrase = "no";
    } else if (appleCount == 1) {
        phrase = "a single";
    } else if (appleCount == 2) {
        phrase = "a couple of";
    } else if (appleCount == 3) {
        phrase = "a few";
    } else {
        phrase = "many";
    }

    return phrase;
}

std::string getApplesPluralized(int appleCount) {
    std::string plural {(appleCount > 1) ? "apples" : "apple"};
    return plural;
}

int main() {
    constexpr int maryApples {3};
    int numApples {};

    std::cout << "Mary has " << getQuantityPhrase(maryApples) << ' ' << getApplesPluralized(maryApples) << ".\n";

    std::cout << "How many apples do you have? ";
    std::cin >> numApples;

    std::cout << "You have " << getQuantityPhrase(numApples) << ' ' << getApplesPluralized(numApples) << ".\n";

    return 0;
}