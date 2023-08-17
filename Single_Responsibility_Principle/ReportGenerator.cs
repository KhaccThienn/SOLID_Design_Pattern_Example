using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle
{
	public class ReportGenerator
	{
		public void GenerateReport(Employee employee) 
		{
            Console.WriteLine($"Id: {employee.Id}");
            Console.WriteLine($"Name: {employee.Name}");
            Console.WriteLine($"Basic Salary: {employee.BasicSalary}");
			Console.WriteLine($"Bonus: {employee.Bonus}");

		}
	}
}
