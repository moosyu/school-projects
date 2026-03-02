#include <iostream>
#include <string>

static std::string toLowerString(std::string input) {
    for (int i {0}; i < input.length(); i++) {
        input[i] = static_cast<char>(tolower(input[i]));
    }
    return input;
}
/// <summary>
/// Program to test how to use the C++ method of lowering case on a string
/// </summary>
/// <returns></returns>
int main() {
    std::string inputString {};

    std::cout << "Input a string to be lowered:\n";
    std::cin >> inputString;

    std::cout << "You entered: " << toLowerString(inputString);

    return 0;
}