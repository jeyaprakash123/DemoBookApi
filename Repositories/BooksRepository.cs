using BookDetails.DataAccess;
using BookDetails.Models;
using Microsoft.EntityFrameworkCore;

namespace BookDetails.Repositories
{
    public class BooksRepository:IBooksRepository
    {
        public readonly BooksContext _context;
        public BooksRepository(BooksContext context) 
        {
            _context= context;
        }
        public async Task<List<Books>> GetSortedBookByPublisherAuthorTitle()
        {
            return await _context.Book.AsNoTracking().OrderBy(x => x.Publisher).ThenBy(x => x.Publisher).ThenBy(x => x.AuthorLastName).ThenBy(x => x.AuthorFirstName).ThenBy(x => x.Title).ToListAsync();
        }
        public async Task<List<Books>> GetSortedBookByAuthorTitle()
        {
            return await _context.Book.AsNoTracking().OrderBy(x => x.AuthorLastName).ThenBy(x => x.AuthorFirstName).ThenBy(x => x.Title).ToListAsync();
        }
        public async Task<List<Books>> GetSortedBookByPublisherAuthorTitle_Procedure()
        {
            return await _context.Book.FromSqlRaw("EXEC GetBooksSortedByPublisherAuthorTitle").ToListAsync();
        }
        public async Task<List<Books>> GetSortedBookByAuthorTitle_Procedure()
        {
            return await _context.Book.FromSqlRaw("EXEC GetBooksSortedByAuthorTitle").ToListAsync();
        }
        public async Task<decimal> GetTotalPrice()
        {
            return await _context.Book.SumAsync(x => x.Price);
        }
        public async Task AddBooks(List<Books> book)
        {
            _context.Book.AddRange(book);
            await _context.SaveChangesAsync();
        }
    }
}
