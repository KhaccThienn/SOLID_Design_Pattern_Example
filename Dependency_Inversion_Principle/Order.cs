using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle
{
	public class Order
	{
		// Dependency Injection
		private readonly ILogger _logger;

		public Order(ILogger logger)
		{
			_logger = logger;
		}

		public void Process()
		{
			_logger.Log("Order processed");
		}
	}
}
