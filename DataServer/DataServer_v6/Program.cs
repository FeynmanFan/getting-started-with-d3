var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddCors(options =>
{
	options.AddPolicy(name: "Fenix Server",
	builder => builder.WithOrigins("http://localhost:81").AllowAnyMethod().AllowAnyHeader());
});

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseCors("Fenix Server");

app.UseAuthorization();

app.MapControllers();

app.Run();


