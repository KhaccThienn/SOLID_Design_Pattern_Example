using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var consoleLogger = new ConsoleLogger();
			var fileLogger = new FileLogger();

			var order1 = new Order(consoleLogger);
			order1.Process();

			var order2 = new Order(fileLogger);
			order2.Process();
		}
	}
}
