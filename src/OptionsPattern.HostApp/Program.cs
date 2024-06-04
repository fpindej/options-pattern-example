using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using OptionsPattern.HostApp;

var builder = Host.CreateDefaultBuilder(args);

builder.ConfigureAppConfiguration(cfg =>
{
    cfg.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
}).ConfigureServices(services =>
{
    services.AddEuropeanBankApiClientConfiguration();
});

var app = builder.Build();