using HotelReservation.Persistence.DataContext;
using Microsoft.EntityFrameworkCore;


var  MyAllowSpecificOrigins = "meulocalhost";


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

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy  =>
                      {
                          policy.WithOrigins("http://localhost:4200").WithMethods("PUT", "POST", "DELETE", "GET");;
                      });
});


builder.Services.AddControllers();

var app = builder.Build();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseCors(MyAllowSpecificOrigins);

// Configure the HTTP request pipeline. Sempre
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.UseEndpoints(endpoints => { 
    endpoints.MapControllers(); 
});




app.Run();