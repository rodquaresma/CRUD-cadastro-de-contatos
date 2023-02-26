using ControleDeContatos.Data;
using ControleDeContatos.Repositorio;
using Microsoft.EntityFrameworkCore;

namespace ControleDeContatos
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddEntityFrameworkSqlServer()
                .AddDbContext<BancoContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Database")));
            services.AddScoped<IContatoRepositorio, ContatoRepositorio>();
        }

        public void Configure(WebApplication app, IWebHostEnvironment environment)
        {
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");

                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        }
    }
}
