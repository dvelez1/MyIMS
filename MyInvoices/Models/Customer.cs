using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyInvoices.Models
{
    public class Customer
    {
        [Key, Column(Order = 0)]
        public int CustId { get; set; }

        [Display(Name = "Customer Name")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string CustDesc { get; set; }

        [Display(Name = "Address")]
        [StringLength(200, MinimumLength = 5)]
        [Required]
        public string Address { get; set; }

        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        [Required]
        public string PhoneNumber { get; set; }

       // public ICollection<Invoice> Invoices { get; set; }

    }
}
