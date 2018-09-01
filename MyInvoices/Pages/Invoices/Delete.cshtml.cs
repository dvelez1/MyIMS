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
    public class DeleteModel : PageModel
    {
        private readonly MyIMContext _context;

        public DeleteModel(MyIMContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            InvoiceDet = await _context.InvoiceDet.FindAsync(id);

            if (InvoiceDet != null)
            {
                _context.InvoiceDet.Remove(InvoiceDet);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
