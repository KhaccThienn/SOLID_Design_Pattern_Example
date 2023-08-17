using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle
{
	public class Program
	{
		static void Main(string[] args)
		{
			var e = new Employee(1, "Taka A", 2000, 100);
			var rg = new ReportGenerator();
			var sc = new SalaryCalculator();

			rg.GenerateReport(e);
			sc.CalculateSalary(e);
		}
	}
}
