using Microsoft.EntityFrameworkCore;

namespace ProjPUBG
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services, WebApplicationBuilder builder)
        {
            var connectionString = builder.Configuration.GetConnectionString("Data Source=SQL6030.site4now.net;Initial Catalog=db_a9b162_illiakursnew2;User Id=db_a9b162_illiakursnew2_admin;Password=Qwerty123");
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddControllers();

            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
