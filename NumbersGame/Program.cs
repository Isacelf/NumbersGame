//Isac Elfstrand SUT23
using System;

namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen! Jag tänker på ett nummer, kan du gissa vilket? Du får fem försök.");// Skriver ut välkomstmeddelandet för spelet.

            Random random = new Random();// Skapar en instans av Random-klassen för att generera ett slumpmässigt nummer.
            int rightNumber = random.Next(0, 21); // Genererar ett slumpmässigt nummer mellan 0 och 20 och tilldelar det till variabeln rightNumber.
            int guessAttempts = 5; // Definierar antalet gissningsförsök som spelaren har.

            for (int attempt = 1; attempt <= guessAttempts; attempt++) // En loop som ger spelaren upp till 5 försök att gissa rätt nummer.
            {
                Console.WriteLine($"Försök [{attempt}]:"); // Skriver ut vilket försök spelaren är på.
                int guess = Convert.ToInt32(Console.ReadLine()); // Läser in spelarens gissning från användaren och konverterar den till ett heltal.
                Console.WriteLine(""); // En extra space för att göra programmet mer lättläst.

                if (CheckGuess(guess, rightNumber)) // Anropar funktionen CheckGuess för att kontrollera om gissningen är korrekt.
                {
                    Console.WriteLine($"Woho! Du gjorde det! Talet var: {rightNumber}"); // Skriver ut ett meddelande om spelaren gissade rätt och avslutar loopen.
                    break;
                }
                if (attempt == guessAttempts) // Om spelaren har använt alla sina gissningar, skriver vi ut rätt svar.

                {
                    Console.WriteLine($"Du har använt alla dina gissningar, rätt svar var {rightNumber}");
                }
            }

            Console.ReadKey(); // Väntar på att användaren ska trycka på en tangent innan programmet avslutas.
        }

        static bool CheckGuess(int guess, int rightNumber) // Funktion för att kontrollera om gissningen är korrekt.
        {
            if (guess < rightNumber) // Jämför gissningen med det rätta numret och ger feedback till spelaren.
            {
                Console.WriteLine($"{guess} är tyvärr för lågt!");
            }
            else if (guess > rightNumber)
            {
                Console.WriteLine($"{guess} är tyvärr för högt!");
            }
            else
            {
                return true; // Om gissningen är korrekt, returnerar vi sant.
            }
            return false; // Om gissningen är felaktig, returnerar vi falskt.
        }
    }
}