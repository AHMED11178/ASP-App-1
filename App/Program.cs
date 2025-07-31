var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World Ahmed, Hope you are doing well, I am doing good");

// Allow anonymous access to health check
app.MapGet("/health", () => Results.Ok(new {
    Status = "Healthy",
    Version = Assembly.GetEntryAssembly()?.GetName().Version?.ToString(),
    Environment = app.Environment.EnvironmentName
})).AllowAnonymous();

app.Run();
