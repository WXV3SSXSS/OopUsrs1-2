using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USRS1_2
{
	internal class ConsoleColors : ISubject
	{
		List<IObserver> _observers;
		Random r = new Random();
		public ConsoleColors()
		{
			_observers = new List<IObserver>();
		}
		public void AddObserver(IObserver observer)
		{
			_observers.Add(observer);
		}

		public void NotifyObservers()
		{
			var currentColor = (ConsoleColor)r.Next(1, 15);
            Console.WriteLine($"Notify {currentColor}");
            foreach (var item in _observers)
			{
				item.Update(currentColor);
			}
		}

		public void RemoveObserver(IObserver observer)
		{
			if (_observers.Remove(observer))
			{

			}
			else
			{
                Console.WriteLine("There is no such object");
            }
		}
	}
}
