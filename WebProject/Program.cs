var builder = WebApplication.CreateBuilder(args);

#region Настройка создателя приложения
var services = builder.Services;
services.AddControllersWithViews();
#endregion

var app = builder.Build(); //сборка приложения

#region Конфиг конвеера обработки вход соединения


if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}



//app.MapGet("/", () => app.Configuration["CustomGreetings"]);
app.MapGet("/throw", () => {
    throw new ApplicationException("Ошибка!");
});

//app.MapDefaultControllerRoute();
app.MapControllerRoute(
    name: "default",
    //маршрут
    pattern: "{controller=Home}/{action=Index}/{id?}");
#endregion

//Запуск приложения

app.Run();
