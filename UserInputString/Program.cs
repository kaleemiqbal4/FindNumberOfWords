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

