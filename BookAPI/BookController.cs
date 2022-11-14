using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Bookentities;
namespace BookAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        [HttpPost]
        public IActionResult Add(Bookscl book)
        {
            string bookid = "";
            //boo bookDal = new Class1();
            try
            {
                //bookid = bookDal.AddBook(book);
            }
            catch (Exception ex)
            {
                return new BadRequestResult();
            }
            return new CreatedResult("api/Book", bookid);
        }
        [HttpGet]
        [Route("getbook")]
        public IActionResult Get(string id)
        {
            return new OkObjectResult(null);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return new OkObjectResult(null);
        }
    }
}