using System;

namespace WorkingWithClasses
{
	internal class WorkingWithClasses
	{
		static void Main()
		{
			Player player = new Player("John", 100);

			player.ShowInfo();
		}
	}

	class Player
	{
		private string _name;
		private int _score;

		public Player(string name, int score)
		{
			_name = name;
			_score = score;
		}

		public void ShowInfo()
		{
			Console.WriteLine($"Имя игрока - {_name}, его счёт - {_score}");
		}
	}
}
