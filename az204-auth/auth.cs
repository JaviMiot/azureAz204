using System.Threading.Tasks;
using Microsoft.Identity.Client;

class Auth
{
    private const string _clientId = "3731f322-dde3-4ba8-bf13-8d73d0f7af0f";
    private const string _tenantId = "e40db083-6d9a-43d1-a78e-cce40b501e39";

    public static async Task taskAuth()
    {
        var app = PublicClientApplicationBuilder
        .Create(_clientId)
        .WithAuthority(AzureCloudInstance.AzurePublic, _tenantId)
        .WithRedirectUri("http://localhost")
        .Build();

        string[] scopes = { "user.read" };
        AuthenticationResult result = await app.AcquireTokenInteractive(scopes).ExecuteAsync();

        Console.WriteLine($"Token:\t{result.AccessToken}");
    }
}