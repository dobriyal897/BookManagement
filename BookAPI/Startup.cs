using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using BookAPI.Context;
namespace BookAPI
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        }
        public void ConfigureServices(IServiceCollection services)
        {
           // services.AddDbContext<BookContext>(options => options.UseSqlServer(Configuration.GetConnectionString("CompanyConnStr")));
        }
    }
}
