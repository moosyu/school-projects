#include <iostream>

int main() {
    unsigned short x{ 65535 };
    std::cout << "(1) x was: " << x << '\n';

    x = 65536;
    std::cout << "(2) x is now: " << x << '\n';

    x = 65537;
    std::cout << "(3) x is now: " << x << '\n';

    x = -5;
    std::cout << "(4) x is now: " << x << '\n';

    return 0;
}