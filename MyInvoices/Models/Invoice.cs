using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyInvoices.Models
{
    public class Invoice
    {

        [Display(Name = "Invoice ID")]
        [Key, Column(Order = 0)]
        public int InvId { get; set; }

        [Display(Name = "Customer ID")]
        public int CustId { get; set; }


        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Sales { get; set; }
        
        [Display(Name = "Sales Tax")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal TotalSalesTax { get; set; }

        [Display(Name = "Gross Sales")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Gross { get; set; }


        [Display(Name = "Transaction Date")]
        [DataType(DataType.Date)]
        public DateTime TransDate { get; set; }

        public Customer Customers { get; set; }
        //public ICollection<InvoiceDet> InvoiceDets { get; set; }

    }
}
