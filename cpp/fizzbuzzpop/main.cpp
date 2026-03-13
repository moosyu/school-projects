#include <iostream>

void fizzbuzzpop(int count) {
    for (int i {1}; i <= count; i++) {
        bool selected {false};
        if (i % 3 == 0) {
            std::cout << "fizz";
            selected = true;
        }
        if (i % 5 == 0) {
            std::cout << "buzz";
            selected = true;
        }
        if (i % 7 == 0) {
            std::cout << "pop";
            selected = true;
        }
        if (!selected) {
            std::cout << i;
        }

        std::cout << '\n';
    }
}

int main() {
    fizzbuzzpop(150);
    return 0;
}