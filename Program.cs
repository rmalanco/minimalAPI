var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!"); // <--- este es el endpoint que se va a ejecutar

app.Run();
