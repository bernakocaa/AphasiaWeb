var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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

app.UseEndpoints(endpoints => {

    _ = endpoints.MapControllerRoute(
        name: "aboutus",
        pattern: "aboutus",
        defaults: new { controller = "Home", action = "AboutUs" });


    _ = endpoints.MapControllerRoute(
        name: "login",
        pattern: "login",
        defaults: new { controller = "Home", action = "Login" });

    _ = endpoints.MapControllerRoute(
        name: "register",
        pattern: "register",
        defaults: new { controller = "Home", action = "Register" });

    _ = endpoints.MapControllerRoute(
       name: "admin",
       pattern: "/admin/{file}",
       defaults: new { controller = "Admin", action = "FileView", file = "index" });

    _ = endpoints.MapControllerRoute(
        name: "home",
        pattern: "{file}",
        defaults: new { controller = "Home", action = "FileView" , file="index"});

});
app.Run();
