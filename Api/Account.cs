using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using TogetherApIs.Core;
using TogetherApIs.Core.Exceptions;
using TogetherApIs.Core.Request;
using TogetherApIs.Core.Response;
using TogetherApIs.Errors;
using TogetherApIs.Models;

namespace TogetherApIs.Api;

public sealed class Account
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Account(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get API key identity
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="WhoamiResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="WhoamiError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns identity information about the authenticated API key. Useful for confirming which project and organization a key is scoped to, and for obtaining the project slug used to compose the <c>model</c> value (<c>&lt;project_slug&gt;/&lt;endpoint_slug&gt;</c>) in dedicated endpoint inference calls.
    /// Requires a Bearer API key in the <c>Authorization</c> header. Cookie, session, and SLS JWT credentials are not accepted.
    /// </remarks>
    public Task<WhoamiResponse> Whoami(RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/whoami"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<WhoamiResponse>(),
            WhoamiError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);
}
