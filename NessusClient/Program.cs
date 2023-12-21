using NessusClient.Settings;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

GetConfig();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

app.Run();

static void GetConfig()
{
    var settingsFile = "appsettings.json";
#if DEBUG
    settingsFile = "appsettings.Development.json";
#endif

    IConfiguration configuration = new ConfigurationBuilder().AddJsonFile(settingsFile).Build();
    AppSettings.AddressBase = configuration.GetSection("AppSettings:AddressBase").Value;
    AppSettings.User = configuration.GetSection("AppSettings:User").Value;
    AppSettings.Password = configuration.GetSection("AppSettings:Password").Value;
    AppSettings.NetworkScanUuid = configuration.GetSection("AppSettings:NetworkScanUuid").Value;
    AppSettings.DatabaseConnectionString = configuration.GetSection("AppSettings:DatabaseConnectionString").Value;
}