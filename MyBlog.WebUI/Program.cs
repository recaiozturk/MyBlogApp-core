using Microsoft.EntityFrameworkCore;
using MyBlog.Data.Entity;
using MyBlog.WebUI.DataAccess.Abstract;
using MyBlog.WebUI.DataAccess.Concrate.EfCore;
using MyBlog.WebUI.Util;
using MyBlog.WebUI.Util.Abstract;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbContext>(options => {
    var config = builder.Configuration;
    var connectionString = config.GetConnectionString("database");
    options.UseSqlServer(connectionString);
});

//scoped  score: her http iste�inde 1 nesne
builder.Services.AddScoped<IAboutDal, EfAboutDal>();

builder.Services.AddScoped<IMethods, Methods>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//al�nan hatalar� g�sterir(sunucuda)
app.UseDeveloperExceptionPage();


app.Run();
