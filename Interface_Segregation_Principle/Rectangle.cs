using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle
{
	public class Rectangle : IDrawable, ICalculable
	{
		public double Width { get; set; }
		public double Height { get; set; }

		public Rectangle(double width, double height)
		{
			Width = width;
			Height = height;
		}

		public double CalculateArea() => (Width + Height) * 2;

		public double CalculatePerimeter() => Width * Height;

		public void Draw()
		{
			Console.WriteLine("Drawing a Rectangle");
		}
	}
}
