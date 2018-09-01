using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyInvoices.Models;

namespace MyInvoices.Pages.Invoices
{
    public class DetailsModel : PageModel
    {
        private readonly MyIMContext _context;

        public DetailsModel(MyIMContext context)
        {
            _context = context;
        }

        public InvoiceDet InvoiceDet { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            InvoiceDet = await _context.InvoiceDet.FirstOrDefaultAsync(m => m.Id == id);

            if (InvoiceDet == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
