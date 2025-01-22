namespace Seamailer.Models.Response;

public class SeaMailerResponse
{
    [JsonPropertyName("code")]
    public int Code { get; set; }

    [JsonPropertyName("message")]
    public string Message { get; set; }

    [JsonPropertyName("devMessage")]
    public string DevMessage { get; set; }

    [JsonPropertyName("success")]
    public bool Success { get; set; }
}
