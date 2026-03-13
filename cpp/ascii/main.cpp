#include <iostream>

int main() {
    char currentChar { 'a' };

    while (currentChar <= 'z') {
        std::cout << "Current char: " << currentChar << ", ASCII value: " << static_cast<int>(currentChar) << '\n';
        currentChar++;
    }
    return 0;
}