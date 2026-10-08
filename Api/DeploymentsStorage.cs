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
using TogetherApIs.Requests.DeploymentsStorage;

namespace TogetherApIs.Api;

public sealed class DeploymentsStorage
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal DeploymentsStorage(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Download a file
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DownloadAFileError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Download a file by redirecting to a signed URL
    /// </remarks>
    public Task DownloadAFile(DownloadAFileRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/deployments/storage/{filename}"),
            [new TemplateParam("filename", request.Filename)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DownloadAFileError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a file download URL
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SignedUrlResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetAFileDownloadUrlError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a signed URL for downloading a deployment storage file
    /// </remarks>
    public Task<SignedUrlResponse> GetAFileDownloadUrl(GetAFileDownloadUrlRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/deployments/storage/{filename}/url"),
            [new TemplateParam("filename", request.Filename)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SignedUrlResponse>(),
            GetAFileDownloadUrlError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);
}
