using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using OptionsPattern.HostApp;

var builder = Host.CreateDefaultBuilder(args);

builder
    .ConfigureAppConfiguration(cfg => { cfg.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true); })
    .ConfigureServices(services => { services.AddEuropeanBankApiClientConfiguration(); });

var app = builder.Build();

var europeanBankApiClientConfiguration =
    app.Services.GetRequiredService<IOptions<EuropeanBankApiClientConfiguration>>().Value ??
    throw new InvalidOperationException("EuropeanBankApiClientConfiguration is null");

Console.WriteLine($"BaseUrl: {europeanBankApiClientConfiguration.BaseUrl}");
Console.WriteLine($"DefaultCurrency: {europeanBankApiClientConfiguration.DefaultCurrency}");
Console.WriteLine($"MaxRetries: {europeanBankApiClientConfiguration.RetryPolicy.MaxRetries}");
Console.WriteLine($"Timeout: {europeanBankApiClientConfiguration.RetryPolicy.Timeout}");