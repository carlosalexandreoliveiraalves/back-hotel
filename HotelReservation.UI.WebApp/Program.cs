using HotelReservation.Persistence.DataContext;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<HotelReservationEFCoreContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("HotelReservationDatabase"),
        new MySqlServerVersion(new Version(8, 0)) 
    )
);

builder.Services.AddControllers();

var app = builder.Build();
app.UseRouting();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseEndpoints(endpoints => { 
    endpoints.MapControllers(); 
});

app.UseHttpsRedirection();


app.Run();