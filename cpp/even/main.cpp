#include <iostream>

int main() {
    int num {};
    std::cout << "Enter an integer: ";
    std::cin >> num;

    std::cout << num;
    if (num % 2 == 0) {
        std::cout << " is even.";
    } else {
        std::cout << " is odd.";
    }

    return 0;
}