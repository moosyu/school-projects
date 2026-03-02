#include <iostream>
#include <random>

int generateNumber(int minValue, int maxValue) {
	// https://en.cppreference.com/w/cpp/numeric/random/uniform_int_distribution.html
	std::random_device rd;
	std::mt19937 gen(rd());
	std::uniform_int_distribution<> ranRange(minValue, maxValue);

	return ranRange(gen);
}