using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle
{
	public class Circle : IDrawable, ICalculable
	{
		public double Radius { get; set; }
        public Circle(double r)
        {
			Radius = r;
        }
        public double CalculateArea() => Math.PI * Radius * Radius;

		public double CalculatePerimeter() => 2 * Math.PI * Radius;

		public void Draw()
		{
			Console.WriteLine("Drawing A Circle !");
		}
	}
}
