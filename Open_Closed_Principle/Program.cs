using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// create a new invoice
			var invoice = new Invoice(1, new DateTime(2023, 08, 16), "Taka A", 20000, "Web-Design Developement Prize");

			// save the invoice to a storage
			var fileInvoiceSaver = new FileInvoiceSaver();
			var dbInvoiceSaver = new DBInvoiceSaver();
			var cloudInvoiceSaver = new CloudInvoiceSaver();

			var fileRepository = new InvoiceRepository(fileInvoiceSaver);
			var dbRepository = new InvoiceRepository(dbInvoiceSaver);
			var cloudRepository = new InvoiceRepository(cloudInvoiceSaver);

			fileRepository.Save(invoice);
			dbRepository.Save(invoice);
			cloudRepository.Save(invoice);

		}
	}
}
