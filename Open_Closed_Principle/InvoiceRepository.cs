using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle
{
	public class InvoiceRepository
	{
		private readonly IInvoiceSaver _invoiceSaver;

		public InvoiceRepository(IInvoiceSaver invoiceSaver)
		{
			_invoiceSaver = invoiceSaver;
		}

		public void Save(Invoice invoice)
		{
			_invoiceSaver.Save(invoice);
		}
	}
}
