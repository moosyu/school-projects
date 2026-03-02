#include <iostream>
#include <string>

int main() {
    std::string fullName {};
    int age {};

    std::cout << "What is your full name? ";
    std::getline(std::cin >> std::ws, fullName);

    std::cout << "What is your age? ";
    std::cin >> age;

    std::cout << "Your age + length of name is: " << static_cast<int>(fullName.length()) + age;
    return 0;
}