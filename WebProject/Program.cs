var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//Загрузка конфигурацииъ

var configuration = app.Configuration;
var greetings = configuration["CustomGreetings"];
app.MapGet("/", () => greetings);

app.Run();
