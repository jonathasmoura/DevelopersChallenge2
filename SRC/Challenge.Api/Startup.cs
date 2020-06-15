using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Challenge.Domain;
using Challenge.Domain.CommandsHandlers.BankAccountCommandsHandlers;
using Challenge.Domain.CommandsHandlers.BankCommandsHandlers;
using Challenge.Infra.Contexts;
using Challenge.Infra.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Challenge.Api
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
            //here DI of uow
            services.AddControllers().AddNewtonsoftJson(o => { o.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore; });

            services.AddResponseCompression();
            services.AddMvc();

            services.AddDbContext<BaseContext>(opt => opt.UseInMemoryDatabase("Database"));
            //services.AddDbContext<BaseContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("connectionString")));
            services.AddScoped<BaseContext, BaseContext>();
            services.AddTransient<IBankRepository, BankRepository>();
            services.AddTransient<BankCommandHandler, BankCommandHandler>();
            services.AddTransient<IBankAccountRepository, BankAccountRepository>();
            services.AddTransient<BankAccountCommandHandler, BankAccountCommandHandler>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseResponseCompression();
            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors(x => x
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());

            app.UseAuthentication();
            app.UseAuthorization();



            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
