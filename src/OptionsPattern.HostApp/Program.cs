using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateDefaultBuilder(args);

builder.ConfigureAppConfiguration(cfg =>
{
    cfg.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
});

var app = builder.Build();