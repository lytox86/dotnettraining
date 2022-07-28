using WebApplication2;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSwaggerGen();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/", () => "Hello World!");
app.MapGet("/foo", HelloWorldHandler.SayHello);

app.MapPut("/", () => "Hello World!");
app.MapDelete("/", () => "Hello World!");
app.MapPost("/", () => "Hello World!");

app.Run();