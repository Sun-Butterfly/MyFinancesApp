using finances_db;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDatabase(builder.Configuration);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options => 
    options.SwaggerDoc("finances-v1", new OpenApiInfo()
    {
        Title = "MyFinances",
        Description = "app",
        Version = "v1"
    }));

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(options => options.SwaggerEndpoint("/swagger/finances-v1/swagger.json", "finances-v1"));
app.MapGet("/", () => "Hello Finances пуп!");

app.Run();