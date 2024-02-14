var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "YO YO It Be Like That Sometimes");
app.MapGet("/", () => "YO YO It Be Like That Sometimes");
app.Run();
