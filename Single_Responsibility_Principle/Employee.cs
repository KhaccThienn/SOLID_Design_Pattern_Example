using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle
{
	public class Employee
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public double BasicSalary { get; set; }
		public double Bonus { get; set; }
		public Employee() { }
		public Employee(int id, string name, double basicSalary, double bonus)
		{
			Id = id;
			Name = name;
			BasicSalary = basicSalary;
			Bonus = bonus;
		}
		// Sai: Một lớp có quá nhiều trách nhiệm
		//public void CalculateSalary() { /*...*/ }
		//public void GenerateReport() { /*...*/ }
	}
}
