using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http;
using Book_API.Models;
using System.Net;
using System.Threading.Tasks;
using System.Text.Json;
using System.Net.Http.Headers;

namespace TestBookAPI
{
    [TestClass]
    public class BookAPI_Test
    {
        private static WebApplicationFactory<Program> _factory;
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _factory = new WebApplicationFactory<Program>();
        }
        [TestMethod]
        public  async Task GetBooks()
        {
            var client = _factory.CreateClient();
            var response = await client.GetAsync("api/Book/getBooks");

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.AreEqual("application/json; charset=utf-8", response.Content.Headers.ContentType?.ToString());

            var json = await response.Content.ReadAsStringAsync();
            Assert.AreEqual("[{\"id\":\"1234-gH6789                                       \",\"name\":\"Math\",\"authorName\":\"arun\"}]", json);
        }
        [TestMethod]
        public async Task AddBook()
        {
            TblBook book = new TblBook();
            book.Id = "3399-gh8976";
            book.Name = "Science";
            book.AuthorName = "Vishwa reddy";
            
            var httpContent = new StringContent(JsonSerializer.Serialize(book));
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            
            var client = _factory.CreateClient();
            
            var response = await client.PostAsync("api/Book", httpContent);
           
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            
            var json = await response.Content.ReadAsStringAsync();
            Assert.AreEqual("3399-gh8976", json);
        }
    }
}