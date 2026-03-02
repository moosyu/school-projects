#include <iostream>

float getFloat(float inputFloat) {
    std::cout << "Enter a float: ";
    return inputFloat;
}

int main()
{
    float num1 {};
    float num2 {};
    float answer {};
    char chosenOperator {};

    std::cin >> ;

    std::cout << "Enter your second number: ";
    std::cin >> num2;

    std::cout << "Enter your operator: ";
    std::cin >> chosenOperator;


    if (chosenOperator == '+') {
        answer = num1 + num2;
    } else if (chosenOperator == '-') {
        answer = num1 - num2;
    } else if (chosenOperator == '*') {
        answer = num1 * num2;
    } else if (chosenOperator == '/') {
        answer = num1 / num2;
    } else {
        std::cout << "Ruh roh! You've chosen an invalid operator!";
        return 0;
    }

    std::cout << "Your answer was: " << answer;
    return 0;
}