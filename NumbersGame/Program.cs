using System;

namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen! Jag tänker på ett nummer, kan du gissa vilket? Du får fem försök.");
            Random random = new Random();
            int rightNumber = random.Next(0, 21);
            int guessAttempts = 5;

            for (int attempt = 1; attempt <= guessAttempts; attempt++)
            {
                Console.WriteLine($"Försök [{attempt}]:");
                int guess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                if (CheckGuess(guess, rightNumber))
                {
                    Console.WriteLine($"Woho! Du gjorde det! Talet var: {rightNumber}");
                    break;
                }
                if (attempt == guessAttempts)
                {
                    Console.WriteLine($"Du har använt alla dina gissningar, rätt svar var {rightNumber}");
                }
            }

            Console.ReadKey();
        }

        static bool CheckGuess(int guess, int rightNumber)
        {
            if (guess < rightNumber)
            {
                Console.WriteLine($"{guess} är tyvärr för lågt!");
            }
            else if (guess > rightNumber)
            {
                Console.WriteLine($"{guess} är tyvärr för högt!");
            }
            else
            {
                return true;
            }
            return false;
        }
    }
}