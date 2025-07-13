using BiogenomTechTask.BL.Mapping;
using BiogenomTechTask.BL.Services;
using BiogenomTechTask.BL.Services.Interfaces;
using BiogenomTechTask.Data;
using BiogenomTechTask.Data.Repositories;
using BiogenomTechTask.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BiogenomTechTask
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(cfg =>
            {
                cfg.AddProfile(new MappingConfig());
            });

            services.AddDbContext<AppDbContext>(options =>
                options.UseNpgsql(Configuration.GetConnectionString("PostgresConnection")));

            services.AddScoped<IReportRepository, ReportRepository>();

            services.AddScoped<IReportService, ReportService>();    

            services.AddControllers();

            services.AddEndpointsApiExplorer();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
