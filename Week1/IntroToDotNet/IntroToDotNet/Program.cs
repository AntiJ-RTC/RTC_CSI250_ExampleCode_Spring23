//The builder create the web app
WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

//Add services to the container
//this is where we add and configure services
//Services is a ServiceCollection
builder.Services.AddControllersWithViews();

//Create the WebApplication
WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
// This allows us to show a more detailed error message while we are in development
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//This allows us to use https
app.UseHttpsRedirection();
//This lets us serve static files. A static file is one that does not change
app.UseStaticFiles();

//This enables routing
app.UseRouting();
//Enables authorization - 
app.UseAuthorization();
//This specifies the default route
//The default route is /ControllerName/Action
//If you don't specify anything you go the /Home/Index
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//We can retrive values from appsettings.json using the app object
string apikey = app.Configuration["SecretCode"];
Console.WriteLine($"Our api key is {apikey}");
//We run the web application
app.Run();
