#include <iostream>
#include <cmath>

int main() {
    double x {};

    std::cout << "Enter a number to square: ";
    std::cin >> x;
    // this is what masterful efficiency looks like
    std::cout << pow(x, 2.0);

    return 0;
}