using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BookAPI.Models;
namespace BookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly ILogger<BookController> logger;
        private readonly BookDbContext context;
        public BookController(ILogger<BookController> _logger, BookDbContext _context)
        {
            this.logger = _logger;
            this.context = _context;
        }

        [HttpGet]

        public IQueryable<TblBook> GetBook(string bookid)
        {
            var book = from c in context.TblBooks
                       where c.Id == bookid
                       select c;


            return book;
        }
    }
}
