using System.Reflection;  

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Add this health endpoint (must come before any auth middleware)
app.MapGet("/health", () => 
{
    return Results.Ok(new 
    {
        Status = "Healthy",
        Timestamp = DateTime.UtcNow
    });
}).AllowAnonymous(); // This is crucial

app.MapGet("/", () => "Hello World Ahmed, Hope you are doing well, I am doing good");

app.Run();
