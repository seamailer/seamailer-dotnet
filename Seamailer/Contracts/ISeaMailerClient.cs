using Seamailer.Models.Request;
using Seamailer.Models.Response;
using Seamailer.Shared;

namespace Seamailer.Contracts;

public interface ISeaMailerClient
{
    Task<Result<SeaMailerResponse>> SendEmailAsync(EmailRequest request);
}
