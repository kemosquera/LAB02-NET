var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews(); // This enables MVC and controllers.

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseStaticFiles(); // To serve static files like CSS and JS.
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"); // Default route for MVC

app.Run();
