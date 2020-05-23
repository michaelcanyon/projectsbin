using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using System.Data.Entity.Infrastructure.Design;
using Coursal_IT_2020_spring.Infrastructures;
using MongoDB.Driver;
using MongoDB.Driver.GridFS;

namespace Coursal_IT_2020_spring
{
    public class Startup
    {
        IMongoDatabase db;
        IGridFSBucket gridFS;
        //��������� ����������� � �� � ���� �����
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {

            services.Configure<JournalDBSettings>(
        options =>
        {
            options.ConnectionString = Configuration.GetSection("JournalDBSettings:ConnectionString").Value;
            options.DatabaseName = Configuration.GetSection("JournalDBSettings:DatabaseName").Value;
        });
            services.AddTransient<IBlogContext, BlogContext>();

            //services.Configure<JournalDBSettings>(
            //    Configuration.GetSection(nameof(JournalDBSettings)));

            //services.AddSingleton<JournalDBSettings>(sp =>
            //    sp.GetRequiredService<IOptions<JournalDBSettings>>().Value);
            //services.AddSingleton<BlogRepository>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
