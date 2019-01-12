using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuppyCare
{
	class Puppy
	{
		private string name;
		private string type;
		private string difficulty;
		private int treats;
		private int gamesOfFetch;
		private int snuggles;
		private int pets;
		private int kisses;
		private int points;
		private int counter;
		private char decision;
		private int pointsNeeded;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public string Type
		{
			get { return type; }
			set { type = value; }
		}

		public string Difficulty
		{
			get { return difficulty; }
			set { difficulty = value; }
		}

		/// <summary>
		/// Takes input of a name and a type, and sets the values of treats, gamesOfFetch, snuggles, pets, kisses, and hugs
		/// </summary>
		/// <param name="name">The name of the dog</param>
		/// <param name="type">The type of dog, will alter the values of the 6 stats if a specific dog type is entered</param>
		/// <param name="difficulty">The difficulty of the game, it increases the number of points the user needs to win the game</param>
		public Puppy(string name, string type, string difficulty)
		{
			this.name = name;
			this.type = type;
			this.difficulty = difficulty;
			
			// Starter values for each activity
			treats = 2;
			gamesOfFetch = 2;
			snuggles = 1;
			pets = 3;
			kisses = 2;

			points = 0;
			if (difficulty.ToLower().Equals("easy"))
				pointsNeeded = 2;
			else if (difficulty.ToLower().Equals("medium"))
				pointsNeeded = 4;
			else if (difficulty.ToLower().Equals("hard"))
				pointsNeeded = 6;

			// Changes certian values based on the type of the dog
			switch(type.ToLower())
			{
				// Athletic dogs get +1 Treats, +1 Games of Fetch, and -1 Snuggles 
				case "athletic":
					treats++;
					gamesOfFetch++;
					snuggles--;
					break;
				// Lazy dogs get -1 Games of Fetch and +1 Snuggles
				case "lazy":
					gamesOfFetch--;
					snuggles++;
					break;
				// Big dogs get +1 Treats, +1 Games of Fetch, +1 Pets
				case "big":
					treats++;
					gamesOfFetch++;
					pets++;
					break;
				// Small dogs get -1 Treats and -1 Games of Fetch
				case "small":
					treats--;
					gamesOfFetch--;
					break;
				// Puppies get +1 Treats and +1 Fetch
				case "puppy":
					treats++;
					gamesOfFetch++;
					break;
				// Grown dogs get +1 Kisses
				case "grown":
					kisses++;
					break;
				// Old dogs get -1 Fetch and +1 Pets
				case "old":
					gamesOfFetch--;
					pets++;
					break;
			}
			// Verifies if any value is below zero, if so, makes that value zero
			if(treats < 0)
				treats = 0;
			if (gamesOfFetch < 0)
				gamesOfFetch = 0;
			if (snuggles < 0)
				snuggles = 0;
			if (pets < 0)
				pets = 0;
			if (kisses < 0)
				kisses = 0;
		}
		/// <summary>
		/// This will be the only method called in Main(). It will call other methods and run the game
		/// </summary>
		public void PlayGame()
		{
			points = 0;

			GiveTreats();
			PlayFetch();
			Snuggle();
			Pet();
			Kiss();
			Hug();

			Console.Clear();

			// Result
			if (points >= pointsNeeded)
			{
				Console.WriteLine(" Congradulations! You successfully cared for " + name);
				Console.WriteLine(" by getting " + points + " out of " + pointsNeeded + " points.");
			}
			else
			{
				Console.WriteLine(" Unfortunately, you did not care for " + name + " good enough.");
			}
		}
		public void GiveTreats()
		{
			Console.Clear();
			Console.WriteLine(" Activiy #1: Giving Treats\n");
			counter = 0;
			do
			{
				Console.Write(" Do you want to give " + name + " a treat? (y/n) ");
				decision = char.Parse(Console.ReadLine());
				decision = char.ToLower(decision);
				if (decision.Equals('y'))
				{
					Console.WriteLine("\n " + name + " was given a treat.");
					counter++;
					Console.WriteLine(" " + name + " has received " + counter + " treat(s).\n");
				}
			} while (decision.Equals('y'));

			if (counter > treats)
			{
				Console.WriteLine("\n Too many treats! " + name + " is now fat!");
				Console.WriteLine(" You did not get a point.");
			}
			else if (counter < treats)
			{
				Console.WriteLine("\n " + name + " still wants treats!");
			}
			else
			{
				Console.WriteLine("\n " + name + " is happy! You got a point!");
				points++;
			}
			Console.WriteLine(" You have " + points + " point(s).");
			Console.Write("\n Press Enter to continue...");
			Console.ReadLine();
		}
		public void PlayFetch()
		{
			Console.Clear();
			Console.WriteLine(" Activiy #2: Playing Fetch\n");
			counter = 0;
			do
			{
				Console.Write(" Do you want to play a game with " + name + "? (y/n) ");
				decision = char.Parse(Console.ReadLine());
				decision = char.ToLower(decision);
				if (decision.Equals('y'))
				{
					Console.WriteLine("\n You played a game of fetch with " + name + ".");
					counter++;
					Console.WriteLine(" " + name + " has played " + counter + " game(s) of fetch.\n");
				}
			} while (decision.Equals('y'));

			if (counter > gamesOfFetch)
			{
				Console.WriteLine("\n Too many games of fetch! " + name + " is now tired!");
				Console.WriteLine(" You did not get a point.");
			}
			else if (counter < gamesOfFetch)
			{
				Console.WriteLine("\n " + name + " wants to play more!");
			}
			else
			{
				Console.WriteLine("\n " + name + " is happy! You got a point!");
				points++;
			}
			Console.WriteLine(" You have " + points + " point(s).");
			Console.Write("\n Press Enter to continue...");
			Console.ReadLine();
		}
		public void Snuggle()
		{
			Console.Clear();
			Console.WriteLine(" Activiy #3: Snuggling\n");
			counter = 0;
			do
			{
				Console.Write(" Do you want to snuggle with " + name + "? (y/n) ");
				decision = char.Parse(Console.ReadLine());
				decision = char.ToLower(decision);
				if (decision.Equals('y'))
				{
					Console.WriteLine("\n You snuggled with " + name + ".");
					counter++;
					Console.WriteLine(" " + name + " has snuggled " + counter + " time(s).\n");
				}
			} while (decision.Equals('y'));

			if (counter > snuggles)
			{
				Console.WriteLine("\n Too many snuggles! " + name + " wants to play!");
				Console.WriteLine(" You did not get a point.");
			}
			else if (counter < snuggles)
			{
				Console.WriteLine("\n " + name + " wants to snuggle more!");
			}
			else
			{
				Console.WriteLine("\n " + name + " is happy! You got a point!");
				points++;
			}
			Console.WriteLine(" You have " + points + " point(s).");
			Console.Write("\n Press Enter to continue...");
			Console.ReadLine();
		}
		public void Pet()
		{
			Console.Clear();
			Console.WriteLine(" Activiy #4: Petting\n");
			counter = 0;
			do
			{
				Console.Write(" Do you want to pet " + name + "? (y/n) ");
				decision = char.Parse(Console.ReadLine());
				decision = char.ToLower(decision);
				if (decision.Equals('y'))
				{
					Console.WriteLine("\n You gave " + name + " a quality pet.");
					counter++;
					Console.WriteLine(" " + name + " has been petted " + counter + " time(s).\n");
				}
			} while (decision.Equals('y'));

			if (counter > pets)
			{
				Console.WriteLine("\n Too many pets! " + name + " wants to play!");
				Console.WriteLine(" You did not get a point.");
			}
			else if (counter < pets)
			{
				Console.WriteLine("\n " + name + " wants more pets!");
			}
			else
			{
				Console.WriteLine("\n " + name + " is happy! You got a point!");
				points++;
			}
			Console.WriteLine(" You have " + points + " point(s).");
			Console.Write("\n Press Enter to continue...");
			Console.ReadLine();
		}
		public void Kiss()
		{
			Console.Clear();
			Console.WriteLine(" Activiy #5: Giving Kisses\n");
			counter = 0;
			do
			{
				Console.Write(" Do you want give " + name + " a kiss? (y/n) ");
				decision = char.Parse(Console.ReadLine());
				decision = char.ToLower(decision);
				if (decision.Equals('y'))
				{
					Console.WriteLine("\n You kissed " + name + ".");
					counter++;
					Console.WriteLine(" " + name + " has been kissed " + counter + " time(s).\n");
				}
			} while (decision.Equals('y'));

			if (counter > kisses)
			{
				Console.WriteLine("\n Too many kisses! Too much love for " + name + "!");
				Console.WriteLine(" You did not get a point.");
			}
			else if (counter < kisses)
			{
				Console.WriteLine("\n " + name + " wants more kisses!");
			}
			else
			{
				Console.WriteLine("\n " + name + " is happy! You got a point!");
				points++;
			}
			Console.WriteLine(" You have " + points + " point(s).");
			Console.Write("\n Press Enter to continue...");
			Console.ReadLine();
		}
		public void Hug()
		{
			Console.Clear();
			Console.WriteLine(" Activiy #6: Giving Hugs\n");
			counter = 0;
			do
			{
				Console.Write(" Do you hug " + name + "? (y/n) ");
				decision = char.Parse(Console.ReadLine());
				decision = char.ToLower(decision);
				if (decision.Equals('y'))
				{
					Console.WriteLine("\n You hugged " + name + ".");
					counter++;
					Console.WriteLine(" " + name + " has been hugged " + counter + " time(s).\n");
				}
			} while (decision.Equals('y'));

			if (counter > 0)
			{
				Console.WriteLine("\n No dog should be hugged!");
				Console.WriteLine(" You did not get a point.");
			}
			else
			{
				Console.WriteLine("\n " + name + " is happy! You got a point!");
				points++;
			}
			Console.WriteLine(" You have " + points + " point(s).");
			Console.Write("\n Press Enter to continue...");
			Console.ReadLine();
		}
	}
}
