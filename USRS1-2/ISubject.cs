using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USRS1_2
{
	internal interface ISubject
	{
		void AddObserver(IObserver observer);
		void RemoveObserver(IObserver observer);
		void NotifyObservers();
	}
}
