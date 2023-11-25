using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USRS1_2
{
	internal class BlindPainter : IObserver
	{
		public void Update(ConsoleColor color)
		{
			Console.BackgroundColor = color - 1;
			Console.ForegroundColor = color;
			Console.WriteLine("BlindPainter");
			Console.ResetColor();
		}
	}
}
