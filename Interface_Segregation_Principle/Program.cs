using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var circle = new Circle(5);
			var rectangle = new Rectangle(20, 4);
			var tritangle = new Triangle(3, 4, 5, 3);

			Console.WriteLine(circle.GetType());
			circle.Draw();
			Console.WriteLine("\t Perimeter: {0}", circle.CalculatePerimeter());
			Console.WriteLine("\t Area: {0}", circle.CalculateArea());

			Console.WriteLine(rectangle.GetType());
			rectangle.Draw();
			Console.WriteLine("\t Perimeter: {0}", rectangle.CalculatePerimeter());
			Console.WriteLine("\t Area: {0}", rectangle.CalculateArea());

			Console.WriteLine(tritangle.GetType());
			Console.WriteLine("\t Perimeter: {0}", tritangle.CalculatePerimeter());
			Console.WriteLine("\t Area: {0}", tritangle.CalculateArea());
		}
	}
}
