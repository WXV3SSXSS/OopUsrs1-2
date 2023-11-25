using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USRS1_2
{
	internal interface IObserver
	{
		void Update(ConsoleColor color);
	}
}
