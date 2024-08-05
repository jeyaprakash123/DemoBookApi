using BookDetails.Models;
using Microsoft.EntityFrameworkCore;

namespace BookDetails.DataAccess
{
    public class BooksContext : DbContext
    {
        public BooksContext(DbContextOptions<BooksContext> options) : base(options)
        {

        }

        public DbSet<Books> Book { get; set; }
    }
}
