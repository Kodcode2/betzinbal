
using Microsoft.EntityFrameworkCore;
using MosadRest.Data;
using MosadRest.Services;

namespace MosadRest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddHttpClient(); builder.Services.AddDbContext<ApplicationDbContext>(options
                    => options.UseSqlServer(
                    builder.Configuration.GetConnectionString("DefaulCnnetion")
                    )
                );
            builder.Services.AddScoped<IAgentService, AgentService>();
            builder.Services.AddScoped<ITargetService, TargetService>();
            builder.Services.AddScoped<IMissionService, MissionService>();
            builder.Services.AddHttpClient();

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
