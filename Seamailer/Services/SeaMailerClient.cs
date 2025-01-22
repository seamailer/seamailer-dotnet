using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Seamailer.Contracts;
using Seamailer.Models.Request;
using Seamailer.Models.Response;
using Seamailer.Settings;
using Seamailer.Shared;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;

namespace Seamailer.Services;

public sealed class SeaMailerClient : ISeaMailerClient
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly JsonSerializerOptions _options;
    private readonly ILogger<SeaMailerClient> _logger;
    private readonly SeaMailerSetting _seaMailerSetting;

    private static string _baseUrl = "https://api.seamailer.app/";
    public SeaMailerClient(IHttpClientFactory httpClientFactory,
        IOptions<SeaMailerSetting> seaMailerSetting,
        ILogger<SeaMailerClient> logger)
    {
        _httpClientFactory = httpClientFactory;
        _seaMailerSetting = seaMailerSetting.Value;
        _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        _logger = logger;
    }

    public async Task<Result<SeaMailerResponse>> SendEmailAsync(EmailRequest request)
    {
        try
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_baseUrl);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {_seaMailerSetting.PublicKey}");

            HttpResponseMessage responsePost = await client.PostAsJsonAsync("connect/v1.0/email/send ", request);
            if (responsePost.IsSuccessStatusCode)
            {
                var httpResponseResult = await responsePost.Content.ReadAsStreamAsync();
                var content = await JsonSerializer.DeserializeAsync<SeaMailerResponse>(httpResponseResult, _options)!;

                if (content != null && content.Code == 200)
                {
                    return await Result<SeaMailerResponse>.SuccessAsync(content, "Email Sent");
                }
                else
                {
                    return await Result<SeaMailerResponse>.FailureAsync("Unable to send email");
                }
            }
            else
            {
                return await Result<SeaMailerResponse>.FailureAsync("Unable to send email");
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Unable to send email");
            return await Result<SeaMailerResponse>.FailureAsync("Unable to send email - " + ex.Message);
        }
    }
}
