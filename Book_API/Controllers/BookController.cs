using Microsoft.AspNetCore.Mvc;
using Book_API.Models;

namespace Book_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        public ILogger<BookController> logger;
        public BookDbContext context;
        public BookController(ILogger<BookController> _logger, BookDbContext _context)
        {
            this.logger = _logger;
            this.context = _context;

            
        }
        [HttpGet]
        public IQueryable<TblBook> getBook(string bookid)
        {
            var book = from c in context.TblBooks
                       where c.Id == bookid
                       select c;

            return book;
        }
        [HttpPost]
        public string AddBook(TblBook book)
        {
           context.TblBooks.Add(book);
            context.SaveChanges();
            return book.Id;
        }
        [HttpGet]
        [Route("getBooks")]
        public List<TblBook> getBooks()
        {
            var book = context.TblBooks.ToList();

            return book;
        }
    }
    
}
