#include <iostream>
#include <string>

// unrelated but i was interested in what a stride is <-- bad news, turns out slice is for something called a valarray and i have to use whatever a substr is

int main() {
    std::string hello = std::string{"hello world"}.substr(0, 5);
    std::cout << hello;

    return 0;
}