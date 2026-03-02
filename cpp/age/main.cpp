// you see me use &? yeah. im like that.
#include <iostream>
#include <string>
#include <string_view>

struct Person {
    std::string name;
    int age;
};

void printNameAge(const Person& older, const Person& younger) {
    std::cout << older.name << " (age " << older.age << ") is older than " << younger.name << " (age " << younger.age << ").";
}

int main() {
    Person people[2];

    for (int i = 0; i < 2; i++) {
        const int indexAdded = i + 1;
        std::cout << "Enter the name of person #" << indexAdded << ": ";
        std::getline(std::cin >> std::ws, people[i].name);
        std::cout << "Enter the age of person #" << indexAdded << ": ";
        std::cin >> people[i].age;
    }

    if (people[0].age > people[1].age) {
        printNameAge(people[0], people[1]);
    } else {
        printNameAge(people[1], people[0]);
    }

    return 0;
}