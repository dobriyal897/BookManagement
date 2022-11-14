using Bookentities;
namespace BookLib
{
   
    public class Bookcls
    {

        public string AddBook(Bookscl bookdetail)
        {
            Guid id = new Guid();
            bookdetail.id = id.ToString();
            using (BookContextDataContext entity = new BookContextDataContext())
            {
                tbl_book book = new tbl_book();
                book.id = bookdetail.id;
                book.name = bookdetail.name;
                book.authorName = bookdetail.authorName;
                entity.tbl_books.InsertOnSubmit(book);

                entity.tbl_books.InsertOnSubmit(book);
            }
            return bookdetail.id;

        }

        //public IQueryable<BookLib.tbl_book> GetBooks()
        //{

        //   using (BookDBEntities entity = new BookDBEntities())
        //    {
        //        var query = from c in entity.tbl_book
        //                    orderby c.name
        //                    select c;
        //        return query;
        //    }

        //}

        //public Bookscl GetBook(string bookid)
        //{
        //    using (BookDBEntities entity = new BookDBEntities())
        //    {
        //        var query = from c in entity.tbl_book
        //                    where c.id == bookid
        //                    select c;
        //        tbl_book book = query.FirstOrDefault();
        //        Bookscl bookrecord = new Bookscl();
        //        bookrecord.id = book.id;
        //        bookrecord.name = book.name;
        //        bookrecord.authorName = book.authorName;
        //        return bookrecord;
        //    }

        //}

    }
}