using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyInvoices.Models
{
    public class Product
    {

        [Key, Column(Order = 0)]
        public int ProdId { get; set; }

        [Display(Name = "Product Name")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string ProdDesc { get; set; }

        
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }


        [Display(Name = "Sales Tax")]
        [Range(0, 30.99)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal SalesTax { get; set; }

       // public ICollection<InvoiceDet> invoiceDets { get; set; }


    }
}
