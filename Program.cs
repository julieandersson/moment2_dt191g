var builder = WebApplication.CreateBuilder(args);

// Lägger till services till DI-container, inklusive session
builder.Services.AddControllersWithViews();
builder.Services.AddSession(); // Lägger till stöd för sessioner

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseSession(); // Aktiverar sessionshantering
app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
