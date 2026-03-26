#include <iostream>
#include <string>

bool palindromeChecker(std::string_view a) {
    if (a.length() == 0) return false;
    size_t len = a.length();
    for (size_t i = 0; i < len / 2; i++) {
        if (std::tolower(static_cast<unsigned char>(a[i])) != std::tolower(static_cast<unsigned char>(a[len - i - 1]))) {
            return false;
        }
    }
    return true;
}

int main() {
    const std::string PALINDROME_WORD = "Mum";
    std::cout << PALINDROME_WORD << (palindromeChecker(PALINDROME_WORD) ? " is " : " isn't ") << "a palindrome";
}