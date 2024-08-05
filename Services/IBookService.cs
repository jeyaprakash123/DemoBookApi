using BookDetails.Models;

namespace BookDetails.Services
{
    public interface IBookService
    {
        Task<List<Books>> SortedBookByPublisherAuthorTitle();
        Task<List<Books>> SortedBookByAuthorTitle();
        Task<List<Books>> SortedBookByPublisherAuthorTitle_Procedure();
        Task<List<Books>> SortedBookByAuthorTitle_Procedure();
        Task<decimal> TotalPrice();
        Task InsertBooks(List<Books> book);
    }
}
