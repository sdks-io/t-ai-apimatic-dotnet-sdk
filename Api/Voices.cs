using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using TogetherApIs.Core;
using TogetherApIs.Core.ErrorResponse;
using TogetherApIs.Core.Exceptions;
using TogetherApIs.Core.Request;
using TogetherApIs.Core.Response;
using TogetherApIs.Models;

namespace TogetherApIs.Api;

public sealed class Voices
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Voices(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Fetch available voices for each model
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListVoicesResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Fetch available voices for each model
    /// </remarks>
    public Task<ListVoicesResponse> FetchVoices(RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/voices"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListVoicesResponse>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);
}
