﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyInvoices.Models;

namespace MyInvoices.Pages.Invoices
{
    public class CreateModel : PageModel
    {
        private readonly MyIMContext _context;

        public CreateModel(MyIMContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public InvoiceDet InvoiceDet { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.InvoiceDet.Add(InvoiceDet);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}