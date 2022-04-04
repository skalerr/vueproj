using System.Configuration;
using Microsoft.EntityFrameworkCore;
using rpg2.Data;

var builder = WebApplication.CreateBuilder(args);

// string uri = builder.Configuration.GetValue<string>("MetaAPI"); //Строка для настройки в конфиге 
// builder.Services.AddHttpClient("meta", c =>
// {
//     c.BaseAddress = new Uri(uri); // Обращение к стрингу
// });

// Add services to the container.
builder.Services.AddControllersWithViews();

// builder.Services.AddDbContext<DataContext>(options =>
// {
//     options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
// });
builder.Services.AddDbContext<DataContext1>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient("getter", client => {
    client.BaseAddress = new Uri("http://localhost:5004");
});
// builder.Services.AddHttpClient("meta", c =>
// {
//     c.BaseAddress = new Uri("http://localhost:5004/api"); // Обращение к стрингу
// });
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
