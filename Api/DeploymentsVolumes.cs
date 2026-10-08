using System;
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
using TogetherApIs.Requests.DeploymentsVolumes;

namespace TogetherApIs.Api;

public sealed class DeploymentsVolumes
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal DeploymentsVolumes(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Create a new volume
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="VolumeResponseItem"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CreateANewVolumeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a new volume to preload files in deployments
    /// </remarks>
    public Task<VolumeResponseItem> CreateANewVolume(CreateANewVolumeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/deployments/storage/volumes"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<VolumeResponseItem>(),
            CreateANewVolumeError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get the list of project volumes
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListVolumesResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetTheListOfProjectVolumesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieve all volumes in your project
    /// </remarks>
    public Task<ListVolumesResponse> GetTheListOfProjectVolumes(RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/deployments/storage/volumes"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListVolumesResponse>(),
            GetTheListOfProjectVolumesError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);
}
