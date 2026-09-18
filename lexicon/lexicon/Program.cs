// dictionary containing word and their word count
Dictionary<string, int> lexicon = [];

Console.WriteLine("The Tiny Lexicon");

// loops forever until manually broken
while(true) {
    Console.WriteLine();
    Console.Write("How many words would you like to enter: ");
    if (int.TryParse(Console.ReadLine(), out int wordCount)) {
        Console.WriteLine();
        if (wordCount <= 0) {
            Console.WriteLine("You can't enter 0 words!");
        } else {
            for (int i = 0; i < wordCount; i++) {
                Console.Write($"    Please enter word {i + 1}: ");
                string? word = Console.ReadLine();

                // readline cant create nullable results
                if (word == null || word.Length < 1) {
                    Console.WriteLine("You entered an invalid word! Skipping.");
                    continue;
                }

                // index 0 should be the first part of the word before any spaces
                string[] inputWords = word.Split(' ');
                if (inputWords.Length > 1) {
                    Console.WriteLine("You can't include words with spaces! Your input was truncated.");
                }

                string safeWord = inputWords[0].ToLower();

                if (lexicon.TryGetValue(safeWord, out int value)) {
                    lexicon[safeWord] = value + 1;
                } else {
                    lexicon[safeWord] = 1;
                }
            }

            Console.WriteLine();
            Console.Write("Would you like to enter any more words? (y/n): ");
            if (!getYNData()) {
                Console.WriteLine();
                break;
            }
            Console.WriteLine();
        }
    } else {
        Console.WriteLine();
        Console.WriteLine("Please enter a valid number!");
    }
}

Console.WriteLine();
Console.Write("Would you like to print your words? (y/n): ");
if (getYNData()) {
    Console.WriteLine();
    Console.WriteLine(string.Join(", ", lexicon.Keys));
}

Console.WriteLine();
Console.Write("Would you like to find the shortest word(s)? (y/n): ");
if (getYNData()) {
    Console.WriteLine();
    // dodges rerunning length for every key
    int min = lexicon.Keys.Min(key => key.Length);
    Console.WriteLine(string.Join(", ", lexicon.Keys.Where(key => key.Length == min)));
}

Console.WriteLine();
Console.Write("Would you like to find the longest word(s)? (y/n): ");
if (getYNData()) {
    Console.WriteLine();
    // dodges rerunning length for every key
    int max = lexicon.Keys.Max(key => key.Length);
    Console.WriteLine(string.Join(", ", lexicon.Keys.Where(key => key.Length == max)));
}

Console.WriteLine();
Console.Write("Would you like to find the most commonly used word(s)? (y/n): ");
if (getYNData()) {
    Console.WriteLine();
    // dodges rerunning length for every key
    int max = lexicon.Values.Max();
    Console.WriteLine(string.Join(", ", lexicon.Where(pair => pair.Value == max).Select(pair => pair.Key)));
}

Console.WriteLine();
Console.Write("Would you like to print the wordlist including wordcounts? (y/n): ");
if (getYNData()) {
    Console.WriteLine();
    foreach (KeyValuePair<string, int> item in lexicon) {
        Console.WriteLine($"{item.Key} ({item.Value})");
    }
}

// returns true if the user inputted yes, false if no
bool getYNData() {
    while (true) {
        // readkey only allows an input as 1 character so it's best here even if it needs a conversion to a string
        string? choice = Console.ReadKey().KeyChar.ToString().ToLower();

        if (choice != null) {
            if (choice == "y") {
                return true;
            } else if (choice == "n") {
                return false;
            }
        }
        Console.WriteLine();
        Console.WriteLine("Please enter y or n...");
    }

}