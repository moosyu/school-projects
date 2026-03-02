#include <iostream>

// but why though?
#define DISPLAY_NAME "noah"

int main() {
    #ifdef DISPLAY_NAME
    std::cout << DISPLAY_NAME;
    #endif
    return 0;
}