namespace Reverse;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, write any word");
        string userInput = Console.ReadLine();
        Console.WriteLine($"You wrote the word {userInput}");
        int numberOfCharacters = userInput.Length;
        string reversedWord = "";
        for (int count = numberOfCharacters - 1; count >= 0; count--)
        {
            reversedWord = reversedWord + userInput[count];
        }
        Console.WriteLine($"The reversed word is {reversedWord}");
    }
}

