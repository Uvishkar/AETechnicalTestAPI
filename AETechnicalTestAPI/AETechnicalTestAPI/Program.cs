using AETechnicalTestAPI.Models;
using AETechnicalTestAPI.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddCors((options) =>
{
    options.AddPolicy("angularApplication", (builder) =>
    {
        builder.WithOrigins("http://localhost:4200")
        .AllowAnyHeader()
        .WithMethods("GET","POST", "PUT", "DELETE")
        .WithExposedHeaders("*");
    });
}
);
builder.Services.AddControllers();
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<VehicleContext>(options => options.UseSqlServer("server=.;database=AETechnicalTestDb;Trusted_Connection=true"));
builder.Services.AddScoped<IVehiclesRepository, SqlVehicleRepository>();
builder.Services.AddAutoMapper(typeof(Program).Assembly);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddMvc(options =>
//{
//    options.SuppressAsyncSuffixInActionNames = false;
//});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{   
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("angularApplication");
app.UseAuthorization();

app.MapControllers();

app.Run();
