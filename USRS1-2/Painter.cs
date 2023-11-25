using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USRS1_2
{
	internal class Painter : IObserver
	{
		public void Update(ConsoleColor color)
		{
			Console.ForegroundColor = color;
            Console.WriteLine("Painter");
			Console.ResetColor();
        }
	}
}
