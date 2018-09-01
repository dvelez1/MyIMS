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
    public class IndexModel : PageModel
    {
        private readonly MyIMContext _context;

        public IndexModel(MyIMContext context)
        {
            _context = context;
        }

        public IList<InvoiceDet> InvoiceDet { get;set; }

        public async Task OnGetAsync()
        {
            InvoiceDet = await _context.InvoiceDet.ToListAsync();
        }
    }
}
