using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json.Serialization;
using VKCommunity.DAL;
using VKCommunity.DAL.Models;
using VKCommunity.RepositoryStorage.Repository;

namespace VKCommunityWebApi
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
            services.AddDbContext<VKCommunityContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("VKConnectionString"), x => x.MigrationsAssembly("VKCommunity.Migrations"));
            });

            services.AddControllers().AddNewtonsoftJson(s =>
            {
                s.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "VKCommunityWebApi", Version = "v1" });
            });

            services.AddScoped<IRepository<User>, Repository<User>>();
            services.AddScoped<IRepository<Community>, Repository<Community>>();
            services.AddScoped<IRepository<UserCommunity>, Repository<UserCommunity>>();
            services.AddScoped<IRepository<PostMessage>, Repository<PostMessage>>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "VKCommunityWebApi v1"));
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
