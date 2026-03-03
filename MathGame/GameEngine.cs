namespace MathGame
{
    internal class GameEngine
    {
        internal void AdditionGame(string message)
        {
            Console.WriteLine(message);
            var random = new Random();
            var score = 0;
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} + {secondNumber} = ?");
                var result = Console.ReadLine();

                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("That is correct! Type any key to continue...");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("That is incorrect Type any key to continue...");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, "Addition");

            Console.WriteLine($"Your final score: {score}. Press any key to continue...");
            Console.ReadLine();

        }

        internal void SubtractionGame(string message)
        {
            Console.WriteLine(message);
            var random = new Random();
            var score = 0;
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} - {secondNumber} = ?");
                var result = Console.ReadLine();

                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("That is correct! Type any key to continue...");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("That is incorrect Type any key to continue...");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, "Subtraction");

            Console.WriteLine($"Your final score: {score}. Press any key to continue...");
            Console.ReadLine();
        }

        internal void MultiplicationGame(string message)
        {
            Console.WriteLine(message);
            var random = new Random();
            var score = 0;
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} * {secondNumber} = ?");
                var result = Console.ReadLine();

                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("That is correct! Type any key to continue...");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("That is incorrect Type any key to continue...");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, "Multiplication");

            Console.WriteLine($"Your final score: {score}. Press any key to continue...");
            Console.ReadLine();
        }

        internal void DivisionGame(string message)
        {
            Console.WriteLine(message);
            var score = 0;
            for (int i = 0; i < 5; i++)
            {
                var divisionNumbers = Helpers.GetDivisionNumbers();
                Console.WriteLine($"{divisionNumbers[0]} / {divisionNumbers[1]} = ?");
                var result = Console.ReadLine();

                if (int.Parse(result) == divisionNumbers[0] / divisionNumbers[1])
                {
                    Console.WriteLine("That is correct! Type any key to continue...");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("That is incorrect Type any key to continue...");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, "Division");

            Console.WriteLine($"Your final score: {score}. Press any key to continue...");
            Console.ReadLine();
        }
    }
}
