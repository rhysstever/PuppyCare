using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuppyCare
{
	class Program
	{
		static void Main(string[] args)
		{
			// Intro to the game
			Console.WriteLine(" Welcome to Puppy Care!");
			Console.WriteLine("\n In this game, you will be asked yes or no questions to care for your doggy. You may answer");
			Console.WriteLine(" yes as many times as you want, but be careful, as it might be too much for your doggy.");
			Console.WriteLine(" Additionally, you might do a certain activity not enough for the likes of your doggy.");
			Console.WriteLine(" There will be 6 activities where you interact with your doggy, to gains points.");

			Console.WriteLine("\n The game will first ask you which difficulty you want to play on (easy, medium, or hard).");
			Console.WriteLine(" The harder the difficulty, the more points you must gain to win the game.");

			Console.Write("\n Press Enter to continue to play the game...");
			Console.ReadLine();
			Console.Clear();

			string name = "";
			string type = "";
			string difficulty = "";
			char decision = ' ';

			do
			{
				// Asks the user for name and type of dog, and difficulty
				Console.Write(" What would you like to name your doggy? ");
				name = Console.ReadLine();
				Console.WriteLine("\n What type of dog is your doggy? ");
				Console.Write(" (athletic, lazy, big, small, puppy, grown, or old): ");
				type = Console.ReadLine();
				Console.WriteLine("\n Which difficulty would you like to play at? ");
				Console.Write(" (easy, medium, or hard): ");
				difficulty = Console.ReadLine();

				Puppy myPuppy = new Puppy(name, type, difficulty);
				myPuppy.PlayGame();

				// Asks to see if the user wants to play again
				Console.Write(" Would you like to play again? (y/n) ");
				decision = char.Parse(Console.ReadLine());
				
				Console.Clear();

			} while (decision.Equals('y'));
			
		}
	}
}
