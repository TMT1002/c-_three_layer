using BUS.IServices;
using BUS.Services;
using DAL;
using DAL.DALServices;
using DAL.IDALServices;
using Microsoft.EntityFrameworkCore;
using Web.Controllers;
using Web.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllers();
builder.Services.AddDbContext<AccountDataContext>(
    o => o.UseNpgsql(builder.Configuration.GetConnectionString("DB1"))
    );
builder.Services.AddScoped<IQLAccountService, QLAccountService>();
builder.Services.AddScoped<IAccountService,AccountService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}




app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseMiddleware<testMiddleware>();

app.MapControllers();

app.MapRazorPages();

app.Run();
