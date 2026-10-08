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
using TogetherApIs.Requests.Volumes;

namespace TogetherApIs.Api;

public sealed class Volumes
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Volumes(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Delete a volume
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="object"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteAVolumeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete an existing volume
    /// </remarks>
    public Task<object> DeleteAVolume(DeleteAVolumeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/deployments/storage/volumes/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<object>(),
            DeleteAVolumeError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a volume by ID or name
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="VolumeResponseItem"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetAVolumeByIdOrNameError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieve details of a specific volume by its ID or name
    /// </remarks>
    public Task<VolumeResponseItem> GetAVolumeByIdOrName(GetAVolumeByIdOrNameRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/deployments/storage/volumes/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("version", request.Version)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<VolumeResponseItem>(),
            GetAVolumeByIdOrNameError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update a volume
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="VolumeResponseItem"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UpdateAVolumeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update an existing volume's configuration or contents
    /// </remarks>
    public Task<VolumeResponseItem> UpdateAVolume(UpdateAVolumeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/deployments/storage/volumes/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            JsonResponse.Create<VolumeResponseItem>(),
            UpdateAVolumeError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);
}
