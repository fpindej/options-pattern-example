using System.ComponentModel.DataAnnotations;

namespace OptionsPattern.HostApp;

public sealed class EuropeanBankApiClientConfiguration
{
    public const string SectionName = "EuropeanBankApiClient";

    [Required]
    public Uri BaseUrl { get; init; }

    public string DefaultCurrency { get; init; } = "EUR";

    public RetryPolicy RetryPolicy { get; init; } = new();
}

public sealed class RetryPolicy
{
    public int MaxRetries { get; init; } = 3;

    public TimeSpan Timeout { get; init; } = TimeSpan.FromSeconds(value: 5);
}