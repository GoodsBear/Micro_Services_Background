using MicroServices.Application;
using MicroServices.Repository;
using MicroServices.Infrastructure;
using MricoServices.Infrastructure.Data;
using SqlSugar;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(d => {
    var list = Path.Combine("obj\\Debug\\net6.0\\MicroServices.API.xml");
    d.IncludeXmlComments(list, true);
});




// ·Ö²ã×¢²á·þÎñ
builder.Services.AddApplicationLayer();
builder.Services.AddInfrastructureServices(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
