
using Microsoft.EntityFrameworkCore;
using fractal_back.Data;

var builder = WebApplication.CreateBuilder(args);




var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");


builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend",
        policy => policy
            .WithOrigins("http://localhost:5173")
            .AllowAnyHeader()
            .AllowAnyMethod());
});

builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenAnyIP(8080);
});


var app = builder.Build();

app.UseHttpsRedirection();


app.UseCors("AllowFrontend");


app.UseAuthorization();
app.MapControllers();
app.UseSwagger();
app.UseSwaggerUI();


app.Run();
