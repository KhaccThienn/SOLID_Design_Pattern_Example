using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IFruit a = new Apple();
			Console.WriteLine(a.GetColor());

			IFruit p = new PineApple();
			Console.WriteLine(p.GetColor());

			Console.ReadKey();
		}
	}
}
