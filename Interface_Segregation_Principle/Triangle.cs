using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle
{
	public class Triangle : ICalculable
	{
		public double AEgde { get; set; }
		public double CEdge { get; set; }
		public double Base { get; set; }
		public double Height { get; set; }

		public Triangle(double aEgde, double cEdge, double @base, double height)
		{
			AEgde = aEgde;
			CEdge = cEdge;
			Base = @base;
			Height = height;
		}

		public double CalculatePerimeter() => AEgde + Base + CEdge;

		public double CalculateArea() => 0.5 * Base * Height;

	}
}
