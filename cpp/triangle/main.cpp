#include <iostream>

void buildPyramid(int pyramidSize) {
    for (int i {0}; i < pyramidSize / 2; i++) {
        for (int k {0}; k <= pyramidSize; k++) {
            if (k >= (pyramidSize / 2) - i && k <= (pyramidSize / 2) + i) {
                std::cout << k;
            } else {
                std::cout << " ";
            }
        }
        std::cout << '\n';
    }
}

int main() {
    buildPyramid(10);

    return 0;
}