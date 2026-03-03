namespace MathGame
{
    internal class Helpers
    {
        static List<string> games = new();
        internal static void GetGames()
        {
            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine("---------------------------------");
            foreach (var game in games)
            {
                Console.WriteLine(game);
            }
            Console.WriteLine("---------------------------------\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }


        internal static void AddToHistory(int gameScore, string gameType)
        {
            games.Add($"{DateTime.Now} - {gameType}: Score= {gameScore} pts");
        }



        internal static int[] GetDivisionNumbers()
        {
            var random = new Random();
            int firstNumber;
            int secondNumber;
            var result = new int[2];
            do
            {
                firstNumber = random.Next(1, 99);
                secondNumber = random.Next(1, 99);
            }
            while (firstNumber % secondNumber != 0);

            result[0] = firstNumber;
            result[1] = secondNumber;
            return result;
        }


    }
}
