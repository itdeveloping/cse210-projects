using System;
/*Specification
Functional requirements
Your program must do the following:

Store a scripture, including both the reference (for example "John 3:16") and the text of the scripture.
Accommodate scriptures with multiple verses, such as "Proverbs 3:5-6".
Clear the console screen and display the complete scripture, including the reference and the text.
Prompt the user to press the enter key or type quit.
If the user types quit, the program should end.
If the user presses the enter key (without typing quit), the program should hide a few random words in the scripture, clear the console screen, and display the scripture again.
The program should continue prompting the user and hiding more words until all words in the scripture are hidden.
When all words in the scripture are hidden, the program should end.
When selecting the random words to hide, for the core requirements, you can select any word at random, even if the word was already hidden. (As a stretch challenge, try to randomly select from only those words that are not already hidden.)*/
class Program
{
    /*And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.*/
    static void Main(string[] args)
    {
        string escritura = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
        Console.Clear();
        Console.WriteLine("Hello and welcome to Scripture Memorizer program!");
        Console.WriteLine($"\nThe scripture you are goind to memorize is {escritura}.");
        Console.Write("\nHow many word do you want me to hide: (1-5)");
        string _wordsToHideStr = Console.ReadLine();
        int _countWords = Int32.Parse(_wordsToHideStr);
        while (_countWords < 1 || _countWords > 5)
        {
            Console.Write("\nSorry, I didn't not recognized yout input as a valid number. \nHow many word do you want me to hide: (1-5)");
             _wordsToHideStr = Console.ReadLine();
             _countWords = Int32.Parse(_wordsToHideStr);
        }

        Console.Clear();

        Reference reference = new Reference("1 Nephi", "3", "7");
        Scripture scripture = new Scripture(escritura, reference, _countWords);
        Console.WriteLine(scripture.ScriptureToString(true));
        Console.WriteLine();
        Console.Write("Hit enter to continue or quit to finish...");
        string input = Console.ReadLine();
        while (input.ToUpper() != "QUIT" && !scripture.IsFinish())
        {
            Console.Clear();
            Console.WriteLine(scripture.ScriptureToString(false));
            Console.Write("\nHit enter to continue or quit to finish...");
            input = Console.ReadLine();
        }
        Console.WriteLine("You did it! Congratulations!");
    }
}