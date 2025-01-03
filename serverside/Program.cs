using Microsoft.EntityFrameworkCore;
using serverside.Data;
using serverside.Mappings;
using serverside.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Inject the dbContext
builder.Services.AddDbContext<projectDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("ProjectConnectionString")));

//Inject the Repository
builder.Services.AddScoped<IUserRepository, SQLUserRepository>();
builder.Services.AddScoped<IPostRepository, SQLPostRepository>();


builder.Services.AddAutoMapper(typeof(AutoMappersProfile));

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
