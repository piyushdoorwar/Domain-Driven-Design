using DDD.Application;
using DDD.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace DDD;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        builder.Services.AddMemoryCache();
        builder.Services.AddSwaggerGen();
        builder.Services.AddDbContext<LibraryDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("LibraryDatabase")));

        builder.Services.AddScoped<IBookRepository, EFCoreBookRepository>();
        builder.Services.AddScoped<BorrowBookHandler>();


        var app = builder.Build();

        // Configure the HTTP request pipeline.

        app.UseHttpsRedirection();
        app.UseSwagger();
        app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Books API"));
        app.UseAuthorization();
        app.MapControllers();
        app.Run();
    }
}
