var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers();

var app = builder.Build();

// Configure app
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();