namespace Seamailer.Contracts;

public interface ISeaMailerClient
{
    Task<Result<SeaMailerResponse>> SendEmailAsync(EmailRequest request);
}
