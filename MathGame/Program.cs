// See https://aka.ms/new-console-template for more information
using MathGame;

Console.WriteLine("Please provide your name");

var menu = new Menu();

var name = Console.ReadLine();
var date = DateTime.UtcNow;

menu.ShowMenu(name, date);

