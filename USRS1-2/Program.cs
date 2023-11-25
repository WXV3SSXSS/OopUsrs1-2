// See https://aka.ms/new-console-template for more information
using USRS1_2;

Console.WriteLine("Hello, World!");

ConsoleColors consoleColors = new ConsoleColors();
Painter painter = new Painter();
Painter secondPainter = new Painter();
BlindPainter blurPainter = new BlindPainter();

consoleColors.AddObserver(painter);
consoleColors.AddObserver(secondPainter);
consoleColors.AddObserver(blurPainter);

consoleColors.NotifyObservers();

consoleColors.RemoveObserver(painter);

consoleColors.NotifyObservers();
