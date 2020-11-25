using LibraryManager.Application.Interfaces;
using LibraryManager.Application.Services;
using LibraryManager.Domain.Core.Interfaces.Repositories;
using LibraryManager.Domain.Core.Interfaces.Services;
using LibraryManager.Domain.Service.Services;
using LibraryManager.Infrastructure.CrossCutting.Adapter.Interfaces;
using LibraryManager.Infrastructure.CrossCutting.Adapter.Maps;
using LibraryManager.Infrastructure.Data;
using LibraryManager.Infrastructure.Data.Interfaces;
using LibraryManager.Infrastructure.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace LibraryManager
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

            services.AddTransient<ILivroApplicationService, LivroApplicationService>();
            services.AddTransient<ILivroService, LivroService>();
            services.AddTransient<ILivroMapper, LivroMapper>();
            services.AddTransient<ILivroRepository, LivroRepository>();

            services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("Default"), b => b.MigrationsAssembly("LibraryManager.API")));

            services.AddTransient<IDataService, DataService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider)
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

            var dataservice = serviceProvider.GetRequiredService<IDataService>();
            dataservice.InitializeDB(serviceProvider);
        }
    }
}
