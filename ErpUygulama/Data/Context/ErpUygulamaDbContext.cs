using ErpUygulama.Models;
using Microsoft.EntityFrameworkCore;

namespace ErpUygulama.Data.Context
{
    public class ErpUygulamaDbContext :DbContext
    {

        public ErpUygulamaDbContext(DbContextOptions<ErpUygulamaDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=FURKAN\\SQLEXPRESS;Initial Catalog=ErpDb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }
          public DbSet<Invoice> Invoices { get; set; }


    }
}
