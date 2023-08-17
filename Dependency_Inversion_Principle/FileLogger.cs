using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle
{
	public class FileLogger : ILogger
	{
		public void Log(string message)
		{
			File.AppendAllText("Logger.txt", $"{Environment.UserName} : {message} {Environment.NewLine}");
		}
	}
}
