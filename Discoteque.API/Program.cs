using Microsoft.EntityFrameworkCore;
using Discoteque.Data;
using Discoteque.Business.Service;
using Discoteque.Business.IServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// AddScoped quiere decir que solo se va a instanciar cuando se necesite.
builder.Services.AddScoped<IArtistService ,ArtistService>();

builder.Services.AddDbContext<DiscotequeContext>(
    opt => opt.UseInMemoryDatabase("Discoteque")
);

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
