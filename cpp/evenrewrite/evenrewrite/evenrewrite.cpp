#include <iostream>

static bool isEven(int x) {
    return !(x % 2);
}

int main() {
    int x {};
    std::cout << "Enter an integer: ";
    std::cin >> x;

    if (isEven(x))
        std::cout << x << " is even\n";
    else
        std::cout << x << " is odd\n";

    return 0;
}