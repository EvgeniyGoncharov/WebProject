var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;
services.AddControllersWithViews();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

//Загрузка конфигурацииъ

//app.MapGet("/", () => app.Configuration["CustomGreetings"]);
app.MapGet("/throw", () => {
    throw new ApplicationException("Ошибка!");
});

//app.MapDefaultControllerRoute();
app.MapControllerRoute(
    name: "default",
    //маршрут
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
