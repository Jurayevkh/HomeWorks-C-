using Microsoft.EntityFrameworkCore;
using Services.AutoMapper;
using Services.DataContexts;
using Services.Interfaces;
using Services.Services;

namespace Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddAutoMapper(typeof(MapperProfile));

            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();

            builder.Services.AddDbContext<DataContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("ConnectionString")));

            builder.Services.AddTransient<ICompanyRepository,CompanyRepository>();
            builder.Services.AddTransient<IEmployeeRepository,EmplyeeRepository>();
            builder.Services.AddTransient<IStaffRepository,StaffRepository>();

            builder.Services.AddSwaggerGen();   

            var app = builder.Build();

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