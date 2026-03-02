#include <iostream>
#include <cmath>

int main() {
    const double gravity {9.8};
    double height {};

    std::cout << "Height? (In meters): ";
    std::cin >> height;

    for (int i {0}; i <= 5; i++) {
        double heightFallen {gravity * (std::pow(i, 2) / 2 )};
        double heightAboveGround {height - heightFallen};
        if (heightAboveGround > 0.0) {
            std::cout << "At " << i << " seconds, the ball is " << heightAboveGround << "m from the ground.\n";
        } else {
            std::cout << "At " << i << " seconds, the ball is on the ground.\n";
        }
    }
}