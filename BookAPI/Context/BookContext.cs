namespace BookAPI.Context
{
    using Microsoft.EntityFrameworkCore;

    public class BookContext
        : DbContext
    {
        public BookContext(DbContextOptions options)
            : base(options)
        {

        }

       
    }
}
