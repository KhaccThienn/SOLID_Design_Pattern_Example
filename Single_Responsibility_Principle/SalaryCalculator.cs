using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle
{
	public class SalaryCalculator
	{
		public void CalculateSalary(Employee employee)
		{
			Console.WriteLine("Total Salary: {0}", employee.BasicSalary + employee.Bonus);
		}
	}
}
