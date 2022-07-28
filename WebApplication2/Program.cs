using WebApplication2;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/foo", HelloWorldHandler.SayHello);

app.Run();