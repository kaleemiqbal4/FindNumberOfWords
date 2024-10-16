# Word Count Console Application

This C# console application counts the number of words in a sentence input by the user. It trims leading and trailing spaces and accounts for multiple spaces between words.

## Features

- Prompts the user to enter a sentence.
- Counts the number of words while ignoring leading, trailing, and multiple spaces.
- Displays the word count in the console.

## How It Works

1. The program prompts the user to enter a sentence.
2. It reads the input and trims any leading or trailing spaces.
3. It iterates through the trimmed string, counting words by checking for spaces.
4. It outputs the total number of words in the sentence.

## Code Explanation

Here's a brief breakdown of the key sections of the code:

- **Input Handling**: The program asks for a sentence and reads user input.
- **Trimming**: It uses `TrimStart()` and `TrimEnd()` to remove unwanted spaces from the start and end of the string.
- **Word Counting**:
  - The program uses a loop to traverse the string.
  - It checks for spaces and uses a boolean flag (`previousSpace`) to ensure that it only counts distinct words.
- **Output**: Finally, it prints the word count to the console.

## Example Usage

```
Console.WriteLine("Enter string as a sentence");
string input = Console.ReadLine();
var newStr = input.TrimStart().TrimEnd();
bool previousSpace = false;
int count = 0;
if (newStr.Length > 0)
{
    for (int i = 0; i < newStr.Length; i++)
    {
        if (newStr[i] != ' ') previousSpace = false;

        if (newStr[i] == ' ' && previousSpace == false)
        {
            previousSpace = true;
            count++;
        }
    }
    count++;
}

Console.WriteLine($"no of words in given sentence {input} is {count}");
Console.ReadLine();


```

## Prerequisites

- .NET SDK installed on your machine.
- A C# development environment (e.g., Visual Studio, Visual Studio Code).

## Running the Application

1. Clone the repository or download the source code.
2. Open the project in your preferred C# development environment.
3. Build and run the application.
4. Enter a sentence when prompted.

## License

This project is open source and available under the [MIT License](LICENSE).
