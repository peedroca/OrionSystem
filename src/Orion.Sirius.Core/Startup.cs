using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Orion.Sirius.Data.Contexts;
using Orion.Sirius.Data.Repositories;
using Orion.Sirius.Domain.Interfaces;
using Orion.Sirius.Domain.Entities;
using AutoMapper;

namespace Orion.Sirius.Core
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<SiriusDbContext>(op => op.UseSqlServer(Configuration["ConnectionString"]
                , b => b.MigrationsAssembly("Orion.Sirius.Core")));

            services.AddScoped<ICostumerRepository, CostumerRepository>();
            services.AddScoped<IContactRepository, ContactRepository>();

            services.AddAutoMapper(typeof(Startup));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
