
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SecureApiWithJwtAuth.Helpers;
using SecureApiWithJwtAuth.Models;

namespace SecureApiWithJwtAuth
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var Connection = builder.Configuration.GetConnectionString("DefaultCon");

            // Add services to the container.
            builder.Services.Configure<JWT>(builder.Configuration.GetSection("JWT"));

            builder.Services.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>();

            builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(Connection));

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
