Console.WriteLine("Enter a sentence: ");
string SentenceInput = Console.ReadLine();

string[] words = SentenceInput.Split(' ');

foreach (string word in words)
{
    Console.WriteLine(word);
}


List<string> WordList = new();
bool Exit;

do
{
    Console.WriteLine("Enter some text: ");
    string WordInput = Console.ReadLine();

    WordList.Add(WordInput);
    string Output = string.Join(" ", WordList);
    Console.WriteLine("You have entered: " + Output);

    
    Console.WriteLine("Would you like to continue (y/n) ? ");
    string GoAgainInput = Console.ReadLine();

    if (GoAgainInput is "y" || GoAgainInput is "Y" || GoAgainInput is "Yes" || GoAgainInput is "yes")
    {
        Exit = false;
    }
    else
        Exit = true;
} while (Exit == false );
Console.WriteLine("Goodbye!");
