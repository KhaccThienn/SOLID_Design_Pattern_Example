using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle
{
	public interface ILogger
	{
		void Log(string message);
	}
}
