using BookDetails.Models;
using BookDetails.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BookDetails.Services
{
    public class BookService : IBookService
    {
        private readonly IBooksRepository _booksRepository;

        public BookService(IBooksRepository booksRepository)
        {
            _booksRepository= booksRepository;
        }
        public async Task<List<Books>> SortedBookByPublisherAuthorTitle()
        {
            return await _booksRepository.GetSortedBookByPublisherAuthorTitle();
        }
        public async Task<List<Books>> SortedBookByAuthorTitle()
        {
            return await _booksRepository.GetSortedBookByAuthorTitle();
        }
        public async Task<List<Books>> SortedBookByPublisherAuthorTitle_Procedure()
        {
            return await _booksRepository.GetSortedBookByPublisherAuthorTitle_Procedure();
        }
        public async Task<List<Books>> SortedBookByAuthorTitle_Procedure()
        {
            return await _booksRepository.GetSortedBookByAuthorTitle_Procedure();
        }
        public async Task<decimal> TotalPrice()
        {
            return await _booksRepository.GetTotalPrice();
        }
        public async Task InsertBooks(List<Books> book)
        {
           await _booksRepository.AddBooks(book);
        }
    }
}
