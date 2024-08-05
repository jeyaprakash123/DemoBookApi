using BookDetails.Models;
using BookDetails.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookDetails.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly ILogger<BooksController> _logger;
        private readonly IBookService _bookService;

        public BooksController(ILogger<BooksController> logger, IBookService bookService)
        {
            _logger = logger;
            _bookService = bookService;
        }
        [HttpGet("sortedByPublisherAuthorTitle")]
        public async Task<ActionResult<IEnumerable<Books>>> GetSortedBookByPublisherAuthorTitle()
        {
            return Ok(await _bookService.SortedBookByPublisherAuthorTitle());
        }

        [HttpGet("sortedByAuthorTitle")]
        public async Task<ActionResult<IEnumerable<Books>>> GetSortedBookByAuthorTitle()
        {
            return Ok(await _bookService.SortedBookByAuthorTitle());
        }
        [HttpGet("sortedByPublisherAuthorTitle_Procedure")]
        public async Task<ActionResult<IEnumerable<Books>>> GetSortedBookByPublisherAuthorTitle_Procedure()
        {
            return Ok(await _bookService.SortedBookByPublisherAuthorTitle_Procedure());
        }

        [HttpGet("sortedByAuthorTitle_Procedure")]
        public async Task<ActionResult<IEnumerable<Books>>> GetSortedBookByAuthorTitle_Procedure()
        {
            return Ok(await _bookService.SortedBookByAuthorTitle_Procedure());
        }

        [HttpGet("totalPrice")]
        public async Task<ActionResult<decimal>> GetTotalPrice()
        {
            return Ok(await _bookService.TotalPrice());
        }

        [HttpPost]
        public async Task<IActionResult> AddBooks([FromBody] List<Books> books)
        {
            await _bookService.InsertBooks(books);
            return CreatedAtAction(nameof(AddBooks), new { count = books.Count });
        }
    }
}