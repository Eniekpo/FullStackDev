using Microsoft.Extensions.Configuration;

public class ApiService
{
    private readonly IConfiguration _configuration;

    // Constructor: Inject IConfiguration to access appsettings
    public ApiService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    // Method: Access the BaseUrl from appsettings.Development.json
    public string GetApiUrl()
    {
        return _configuration["ApiSettings:BaseUrl"]
            ?? throw new InvalidOperationException("ApiSettings:BaseUrl is not configured.");
    }
}