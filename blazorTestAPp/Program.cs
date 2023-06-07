using blazorTestAPp;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/hello", () => "Hello but it's mapped to a pattern");

app.Run();