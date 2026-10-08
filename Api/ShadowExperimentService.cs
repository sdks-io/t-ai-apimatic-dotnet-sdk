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
using TogetherApIs.Requests.ShadowExperimentService;

namespace TogetherApIs.Api;

public sealed class ShadowExperimentService
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ShadowExperimentService(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Create a shadow experiment
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeShadowExperiment"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ShadowExperimentServiceCreateShadowExperimentError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates an experiment that mirrors a sampled portion of endpoint traffic to one or more target deployments without returning their responses to clients. Add a description with the update operation after creation.
    /// </remarks>
    public Task<DeShadowExperiment> ShadowExperimentServiceCreateShadowExperiment(ShadowExperimentServiceCreateShadowExperimentRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/projects/{projectId}/endpoints/{endpointId}/shadowExperiments"),
            [new TemplateParam("projectId", request.ProjectId), new TemplateParam("endpointId", request.EndpointId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DeShadowExperiment>(),
            ShadowExperimentServiceCreateShadowExperimentError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Create a shadow experiment target
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeShadowExperimentTarget"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ShadowExperimentServiceCreateTargetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Adds a deployment under the same endpoint as a target for mirrored requests.
    /// </remarks>
    public Task<DeShadowExperimentTarget> ShadowExperimentServiceCreateTarget(ShadowExperimentServiceCreateTargetRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/projects/{projectId}/endpoints/{endpointId}/shadowExperiments/{experimentId}/targets"),
            [
                new TemplateParam("projectId", request.ProjectId),
                new TemplateParam("endpointId", request.EndpointId),
                new TemplateParam("experimentId", request.ExperimentId),
            ],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DeShadowExperimentTarget>(),
            ShadowExperimentServiceCreateTargetError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Delete a shadow experiment
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="object"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ShadowExperimentServiceDeleteShadowExperimentError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a shadow experiment and its target records. The underlying deployments are not deleted.
    /// </remarks>
    public Task<object> ShadowExperimentServiceDeleteShadowExperiment(ShadowExperimentServiceDeleteShadowExperimentRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/projects/{projectId}/endpoints/{endpointId}/shadowExperiments/{id}"),
            [
                new TemplateParam("projectId", request.ProjectId),
                new TemplateParam("endpointId", request.EndpointId),
                new TemplateParam("id", request.Id),
            ],
            [new Param("etag", request.Etag)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<object>(),
            ShadowExperimentServiceDeleteShadowExperimentError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Delete a shadow experiment target
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="object"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ShadowExperimentServiceDeleteTargetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Removes a target from a shadow experiment without deleting the underlying deployment.
    /// </remarks>
    public Task<object> ShadowExperimentServiceDeleteTarget(ShadowExperimentServiceDeleteTargetRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default(
                "/projects/{projectId}/endpoints/{endpointId}/shadowExperiments/{experimentId}/targets/{id}"),
            [
                new TemplateParam("projectId", request.ProjectId),
                new TemplateParam("endpointId", request.EndpointId),
                new TemplateParam("experimentId", request.ExperimentId),
                new TemplateParam("id", request.Id),
            ],
            [new Param("etag", request.Etag)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<object>(),
            ShadowExperimentServiceDeleteTargetError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a shadow experiment
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeShadowExperiment"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ShadowExperimentServiceGetShadowExperimentError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a shadow experiment, including its sampling strategy and target deployments.
    /// </remarks>
    public Task<DeShadowExperiment> ShadowExperimentServiceGetShadowExperiment(ShadowExperimentServiceGetShadowExperimentRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/projects/{projectId}/endpoints/{endpointId}/shadowExperiments/{id}"),
            [
                new TemplateParam("projectId", request.ProjectId),
                new TemplateParam("endpointId", request.EndpointId),
                new TemplateParam("id", request.Id),
            ],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DeShadowExperiment>(),
            ShadowExperimentServiceGetShadowExperimentError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a shadow experiment target
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeShadowExperimentTarget"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ShadowExperimentServiceGetTargetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves one target configured to receive mirrored requests from a shadow experiment.
    /// </remarks>
    public Task<DeShadowExperimentTarget> ShadowExperimentServiceGetTarget(ShadowExperimentServiceGetTargetRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default(
                "/projects/{projectId}/endpoints/{endpointId}/shadowExperiments/{experimentId}/targets/{id}"),
            [
                new TemplateParam("projectId", request.ProjectId),
                new TemplateParam("endpointId", request.EndpointId),
                new TemplateParam("experimentId", request.ExperimentId),
                new TemplateParam("id", request.Id),
            ],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DeShadowExperimentTarget>(),
            ShadowExperimentServiceGetTargetError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// List shadow experiments
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeListShadowExperimentsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ShadowExperimentServiceListShadowExperimentsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists experiments that mirror sampled endpoint traffic to target deployments without affecting client responses. Set <c>includeTargets=true</c> to include target details inline.
    /// </remarks>
    public Task<DeListShadowExperimentsResponse> ShadowExperimentServiceListShadowExperiments(ShadowExperimentServiceListShadowExperimentsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/projects/{projectId}/endpoints/{endpointId}/shadowExperiments"),
            [new TemplateParam("projectId", request.ProjectId), new TemplateParam("endpointId", request.EndpointId)],
            [
                new Param("limit", request.Limit),
                new Param("after", request.After),
                new Param("includeTargets", request.IncludeTargets),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DeListShadowExperimentsResponse>(),
            ShadowExperimentServiceListShadowExperimentsError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// List shadow experiment targets
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeListShadowExperimentTargetsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ShadowExperimentServiceListTargetsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists the deployments that receive mirrored requests from a shadow experiment.
    /// </remarks>
    public Task<DeListShadowExperimentTargetsResponse> ShadowExperimentServiceListTargets(ShadowExperimentServiceListTargetsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/projects/{projectId}/endpoints/{endpointId}/shadowExperiments/{experimentId}/targets"),
            [
                new TemplateParam("projectId", request.ProjectId),
                new TemplateParam("endpointId", request.EndpointId),
                new TemplateParam("experimentId", request.ExperimentId),
            ],
            [new Param("limit", request.Limit), new Param("after", request.After)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DeListShadowExperimentTargetsResponse>(),
            ShadowExperimentServiceListTargetsError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update a shadow experiment
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeShadowExperiment"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ShadowExperimentServiceUpdateShadowExperimentError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates a shadow experiment's description or source sampling strategy. <c>updateMask</c> is required; source changes also require the current <c>etag</c> in the request body.
    /// </remarks>
    public Task<DeShadowExperiment> ShadowExperimentServiceUpdateShadowExperiment(ShadowExperimentServiceUpdateShadowExperimentRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/projects/{projectId}/endpoints/{endpointId}/shadowExperiments/{id}"),
            [
                new TemplateParam("projectId", request.ProjectId),
                new TemplateParam("endpointId", request.EndpointId),
                new TemplateParam("id", request.Id),
            ],
            [new Param("updateMask", request.UpdateMask)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DeShadowExperiment>(),
            ShadowExperimentServiceUpdateShadowExperimentError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update a shadow experiment target
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeShadowExperimentTarget"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ShadowExperimentServiceUpdateTargetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates a shadow target's name, deployment, or description. <c>updateMask</c> is required and must select at least one mutable field.
    /// </remarks>
    public Task<DeShadowExperimentTarget> ShadowExperimentServiceUpdateTarget(ShadowExperimentServiceUpdateTargetRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default(
                "/projects/{projectId}/endpoints/{endpointId}/shadowExperiments/{experimentId}/targets/{id}"),
            [
                new TemplateParam("projectId", request.ProjectId),
                new TemplateParam("endpointId", request.EndpointId),
                new TemplateParam("experimentId", request.ExperimentId),
                new TemplateParam("id", request.Id),
            ],
            [new Param("updateMask", request.UpdateMask)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DeShadowExperimentTarget>(),
            ShadowExperimentServiceUpdateTargetError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);
}
