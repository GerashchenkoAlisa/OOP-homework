using System;

class Program
{
    /// <summary>
    /// Entry point of the program. Processes user input and outputs the result.
    /// </summary>
    static void Main()
    {
        /// <summary>
        /// Prompts the user to enter a sentence.
        /// </summary>
        Console.WriteLine("Enter a sentences:");
        // "I was running and singing while running and dancing! Singing is fun. Dancing or not dancing?" - предложение для проверки
        string text = Console.ReadLine();

        /// <summary>
        /// Creates an instance of the Text class and processes the input text.
        /// </summary>
        Text сhanging = new Text();
        string result = сhanging.СhangingText(text);

        /// <summary>
        /// Outputs the processed result.
        /// </summary>
        Console.WriteLine("Result: " + result);
    }
}
