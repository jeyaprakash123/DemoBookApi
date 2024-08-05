using BookDetails.Models;

namespace BookDetails.Repositories
{
    public interface IBooksRepository
    {
        Task<List<Books>> GetSortedBookByPublisherAuthorTitle();
        Task<List<Books>> GetSortedBookByAuthorTitle();
        Task<List<Books>> GetSortedBookByPublisherAuthorTitle_Procedure();
        Task<List<Books>> GetSortedBookByAuthorTitle_Procedure();
        Task<decimal> GetTotalPrice();
        Task AddBooks(List<Books> book);
    }
}
