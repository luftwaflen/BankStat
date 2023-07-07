using System.Net.Http.Headers;

namespace BankStatAlphaBankIntegration.Services.Implementations;

public class BaseAlphaService
{
    protected readonly HttpClient _client;
    private readonly string _basePath;

    public BaseAlphaService()
    {
        _basePath = "https://developerhub.alfabank.by:8273/partner/1.2.0/accounts/";

        _client = new HttpClient();
        _client.BaseAddress = new Uri(_basePath);
        _client.DefaultRequestHeaders.Accept.Clear();
        _client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
    }
}