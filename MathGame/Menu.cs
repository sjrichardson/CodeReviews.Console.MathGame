namespace MathGame
{
    internal class Menu
    {
        GameEngine engine = new();
        internal void ShowMenu(string? name, DateTime date)
        {
            Console.Clear();
            Console.WriteLine($"Hello {name} it is {date}");
            var isGameActive = true;
            do
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine(@"Please choose a game option:
V - View Previous Games
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit");
                Console.WriteLine("---------------------------------");

                var gameSelected = Console.ReadLine();

                switch (gameSelected.Trim().ToLower())
                {
                    case "v":
                        Helpers.GetGames();
                        break;
                    case "a":
                        engine.AdditionGame("Addition selected");
                        break;
                    case "s":
                        engine.SubtractionGame("Subtraction selected");
                        break;
                    case "m":
                        engine.MultiplicationGame("Multiplication selected");
                        break;
                    case "d":
                        engine.DivisionGame("Division selected");
                        break;
                    case "q":
                        Console.WriteLine("Quit selected");
                        isGameActive = false;
                        break;
                    default:
                        Console.WriteLine("Invalid selection");
                        break;
                }
            } while (isGameActive);
        }


        public Menu() { }
    }
}
