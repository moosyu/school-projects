#include <iostream>

int main() {
    for (int i = 5; i > 0; i--) {
        for (int k = i; k > 0; k--) {
            std::cout << k;
        }
        std::cout << '\n';
    }

    return 0;
}