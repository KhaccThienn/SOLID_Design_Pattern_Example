using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle
{
	public class DBInvoiceSaver : IInvoiceSaver
	{
		public void Save(Invoice invoice)
		{
			Console.WriteLine($"Saved the invoice #{invoice.InvoiceNo} to Database.");
		}
	}
}
