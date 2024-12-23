using DotNetCoreRepositorywithEF.Context;
using DotNetCoreRepositorywithEF.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<ITutorialRepository, TutorialRepository>();
builder.Services.AddScoped<IArticleRepository, ArticleRepository>();
var TutorialDBConnection=builder.Configuration.GetConnectionString("TutorialDBConnection");
builder.Services.AddDbContext<TutorialDBContext>(options => options.UseSqlServer(TutorialDBConnection));
var app = builder.Build();

app.UseStaticFiles();

app.MapControllers();
app.UseStaticFiles();
// first way to use Controller routing
app.UseRouting();

app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
