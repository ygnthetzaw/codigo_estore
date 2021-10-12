using BCryptNet = BCrypt.Net.BCrypt;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using Microsoft.Extensions.Logging;
using eVoucher.Data;
using eVoucher.Authorization;
using eVoucher.Helpers;
using eVoucher.Services;
using eVoucher.Entities;

namespace eVoucher
{
    public class Startup
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfiguration _configuration;
        public Startup(IWebHostEnvironment env, IConfiguration configuration)
        {
            _env = env;
            _configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            string mySqlConnectionStr = _configuration.GetConnectionString("DefaultConnection");
            
            services.AddDbContext<AppDBContext>(options =>
                options.UseMySql(mySqlConnectionStr,
                    ServerVersion.AutoDetect(mySqlConnectionStr)
                )
            );
            services.AddCors();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.IgnoreNullValues = true);
            // services.AddSwaggerGen(c =>
            // {
            //     c.SwaggerDoc("v1", new OpenApiInfo { Title = "eVoucher", Version = "v1" });
            // });
            // get jwt secret key
            services.Configure<AppSettings>(_configuration.GetSection("AppSettings"));

            // call userservice
            services.AddScoped<IJwtUtils, JwtUtils>();
            services.AddScoped<IUserService, UserService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, AppDBContext context)
        {
            // createTestUser(context);
            // if (env.IsDevelopment())
            // {
            //     app.UseDeveloperExceptionPage();
            //     app.UseSwagger();
            //     app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "eVoucher v1"));
            // }

            app.UseRouting();
        
            app.UseCors(x => x
                .SetIsOriginAllowed(origin => true)
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials());

            app.UseMiddleware<ErrorHandlerMiddleware>();

            app.UseMiddleware<JwtMiddleware>();
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private void createTestUser(AppDBContext context)
        {
            // add hardcoded test user to db on startup
            var testUser = new User
            {
                FullName = "Thet Zaw",
                Username = "test",
                Password = BCryptNet.HashPassword("test")
            };
            context.Users.Add(testUser);
            context.SaveChanges();
        }
    }
}
