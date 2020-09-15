using luafalcao.api.Persistence.Contexts;
using luafalcao.api.Web;
using luafalcao.api.Web.Controllers;
using luafalcao.api.Web.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;

namespace luafalcao.api.IntegrationTests
{
    public class ArrangeTests : WebApplicationFactory<Startup>
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                services.ConfigureFacades();
                services.ConfigureDomains();
                services.ConfigureMapper();
                services.ConfigureRepositoryManager();

                services.AddDbContext<RepositoryContext>(options =>
                {
                    // options.UseInMemoryDatabase("InMemoryDbForTesting");
                    services.AddEntityFrameworkNpgsql().AddDbContext<RepositoryContext>(opts => opts.UseNpgsql("User ID=postgres;Password=Cobol40!!!;Host=localhost;Port=5432;Database=luafalcaodb;Pooling=true;Integrated Security=true"));
                });


                var serviceProvider = services.BuildServiceProvider();

                using (var scope = serviceProvider.CreateScope())
                {
                    var scopeServices = scope.ServiceProvider;
                    var db = scopeServices.GetRequiredService<RepositoryContext>();

                    db.Database.EnsureCreated();
                }
            });
        }

    }
}