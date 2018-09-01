using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyInvoices.Models;

    public class MyIMContext : DbContext
    {
        public MyIMContext (DbContextOptions<MyIMContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<InvoiceDet> InvoiceDet { get; set; }

    }
