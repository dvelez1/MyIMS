using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyInvoices.Models;

namespace MyInvoices.Pages.Customers
{
    public class DetailsModel : PageModel
    {
        private readonly MyIMContext _context;

        public DetailsModel(MyIMContext context)
        {
            _context = context;
        }

        public Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.Customer.FirstOrDefaultAsync(m => m.CustId == id);

            if (Customer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
