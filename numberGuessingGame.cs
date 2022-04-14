class numberGuessingGame
{
    
    static void Main(string[] args)
    {
        Random rnd = new Random();
        bool playAgain = true;
        int min = 1;
        int max = 100;
        int guess;
        int number;
        int guesses = 0;
        String response;

        while (playAgain)
        {
            guess = 0;
            guesses = 0;
            response = "";
            number = rnd.Next(min, max + 1);

            while (guess != number)
            {
                Console.WriteLine("Guess a number between " + min + " and " + max + " : ");
                guess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You guessed: " + guess);

                if (guess > number)
                {
                    Console.WriteLine("Your guess is too high");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Your guess is too low");
                }
                guesses++;

            }
            Console.WriteLine("Number: " + number);
            Console.WriteLine("YOU WIN!");
            Console.WriteLine("You guessed the number in " + guesses + " guesses");

            Console.WriteLine("Do you want to play again? (y/n)");
            response = Console.ReadLine();

            if (response == "n")
            {
                playAgain = false;
                Console.WriteLine("Goodbye");
            }

        }
    }

}