#define _USE_MATH_DEFINES

#include <iostream>
#include <cmath>
#include <limits>

int main()
{
    float float_num {6.0f};

    std::cout << "PI: " << M_PI << '\n';
    std::cout << "Scientific notation:" << 1.2e40 << '\n';
    std::cout << std::boolalpha;
    std::cout << "float: " << std::numeric_limits<float>::is_iec559 << '\n';
    std::cout << "double: " << std::numeric_limits<double>::is_iec559 << '\n';
    std::cout << "long double: " << std::numeric_limits<long double>::is_iec559 << '\n';
    std::cout << "this is a float: " << float_num;
}