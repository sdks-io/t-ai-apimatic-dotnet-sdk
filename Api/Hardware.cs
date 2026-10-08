using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using TogetherApIs.Core;
using TogetherApIs.Core.Exceptions;
using TogetherApIs.Core.Models;
using TogetherApIs.Core.Request;
using TogetherApIs.Core.Response;
using TogetherApIs.Errors;
using TogetherApIs.Models;
using TogetherApIs.Requests.Hardware;

namespace TogetherApIs.Api;

public sealed class Hardware
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Hardware(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// List available hardware configurations
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="HardwareResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListHardwareError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of available hardware configurations for deploying models. When a model parameter is provided, it returns only hardware configurations compatible with that model, including their current availability status.
    /// </remarks>
    public Task<HardwareResponse> ListHardware(ListHardwareRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/hardware"),
            [],
            [new Param("model", request.Model)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<HardwareResponse>(),
            ListHardwareError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);
}
