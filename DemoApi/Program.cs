var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => $"{DateTime.Now:T} | v2.0.0 | {Environment.MachineName}");

app.Run();