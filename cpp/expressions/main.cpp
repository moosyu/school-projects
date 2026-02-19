#include <iostream>

int returnNum(int num) {
    return num;
}

int main() {
    int x {returnNum(5)};

    std::cout << x;
    return 0;
}