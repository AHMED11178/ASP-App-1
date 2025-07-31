using System.Reflection;  

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Health check must come FIRST
app.MapGet("/health", () => Results.Ok("Healthy")).AllowAnonymous();

app.MapGet("/", () => "Hello World Ahmed, Hope you are doing well, I am doing good");

app.Run();
