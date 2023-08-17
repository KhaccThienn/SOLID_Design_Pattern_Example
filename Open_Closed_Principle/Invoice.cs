using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle
{
	public class Invoice
	{
		public int InvoiceNo { get; set; }
		public DateTime IssuedDate { get; set; }
		public string Customer { get; set; }
		public decimal Amount { get; set; }
		public string Description { get; set; }

        public Invoice()
        {
            
        }
		public Invoice(int invoiceNo, DateTime issuedDate, string customer, decimal amout, string description)
		{
			InvoiceNo = invoiceNo;
			IssuedDate = issuedDate;
			Customer = customer;
			Amount = amout;
			Description = description;
		}
    }
}
