#include <iostream>

int main() {
    double num1, num2, answer;
    char op;

    std::cout << "What is your first number? ";
    std::cin >> num1;
    std::cout << "What is your second number? ";
    std::cin >> num2;
    std::cout << "What is your operator? ";
    std::cin >> op;

    switch (op) {
    case '+':
        answer = num1 + num2;
        break;
    case '-':
        answer = num1 - num2;
        break;
    case '*':
        answer = num1 * num2;
        break;
    case '/':
        answer = num1 / num2;
        break;

    default:
        std::cout << "You didn't enter a valid operator!";
        return 0;
    }

    std::cout << "Your answer was: " << answer;

    return 0;
}