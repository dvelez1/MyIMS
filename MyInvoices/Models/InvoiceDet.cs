using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyInvoices.Models
{
    public class InvoiceDet
    {

        [Key, Column(Order = 0)]
        public int Id { get; set; }

        [Display(Name = "Invoice ID")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public int InvId { get; set; }

        [Display(Name = "Product ID")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public int ProdId { get; set; }

        
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Units { get; set; }


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

       
       // public Product products { get; set; }
       // public Invoice Invoices { get; set; }

    }
}
