#include <iostream>

int main() {
    for (int i {0}; i < 5; i++) {
        for (int k {5}; k > 0; k--) {
            if (k <= i + 1) {
                std::cout << k;
            } else {
                std::cout << 'X';
            }
        }
        std::cout << '\n';
    }

    return 0;
}