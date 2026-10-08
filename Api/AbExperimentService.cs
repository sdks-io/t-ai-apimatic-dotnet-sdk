using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using TogetherApIs.Core;
using TogetherApIs.Core.ErrorResponse;
using TogetherApIs.Core.Exceptions;
using TogetherApIs.Core.Models;
using TogetherApIs.Core.Request;
using TogetherApIs.Core.Response;
using TogetherApIs.Models;
using TogetherApIs.Requests.AbExperimentService;

namespace TogetherApIs.Api;

public sealed class AbExperimentService
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal AbExperimentService(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Create an A/B experiment
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeAbExperiment"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a managed control/variant split across two to 20 deployments under the same endpoint. Exactly one member is the control, member percentages must add up to 100, and the split applies only to traffic that the endpoint would otherwise send to the control.
    /// </remarks>
    public Task<DeAbExperiment> AbExperimentServiceCreateAbExperiment(AbExperimentServiceCreateAbExperimentRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/projects/{projectId}/endpoints/{endpointId}/abExperiments"),
            [new TemplateParam("projectId", request.ProjectId), new TemplateParam("endpointId", request.EndpointId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DeAbExperiment>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Delete an A/B experiment
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="object"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes an A/B experiment and removes its managed traffic split. The deployments themselves are not deleted.
    /// </remarks>
    public Task<object> AbExperimentServiceDeleteAbExperiment(AbExperimentServiceDeleteAbExperimentRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/projects/{projectId}/endpoints/{endpointId}/abExperiments/{id}"),
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
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get an A/B experiment
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeAbExperiment"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves an A/B experiment and its participating deployments, roles, and traffic percentages.
    /// </remarks>
    public Task<DeAbExperiment> AbExperimentServiceGetAbExperiment(AbExperimentServiceGetAbExperimentRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/projects/{projectId}/endpoints/{endpointId}/abExperiments/{id}"),
            [
                new TemplateParam("projectId", request.ProjectId),
                new TemplateParam("endpointId", request.EndpointId),
                new TemplateParam("id", request.Id),
            ],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DeAbExperiment>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// List A/B experiments
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeListAbExperimentsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists the managed live-traffic experiments configured for an endpoint.
    /// </remarks>
    public Task<DeListAbExperimentsResponse> AbExperimentServiceListAbExperiments(AbExperimentServiceListAbExperimentsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/projects/{projectId}/endpoints/{endpointId}/abExperiments"),
            [new TemplateParam("projectId", request.ProjectId), new TemplateParam("endpointId", request.EndpointId)],
            [new Param("limit", request.Limit), new Param("after", request.After)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DeListAbExperimentsResponse>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update an A/B experiment
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeAbExperiment"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates an experiment's description or member traffic percentages. Use the experiment etag for optimistic concurrency.
    /// </remarks>
    public Task<DeAbExperiment> AbExperimentServiceUpdateAbExperiment(AbExperimentServiceUpdateAbExperimentRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/projects/{projectId}/endpoints/{endpointId}/abExperiments/{id}"),
            [
                new TemplateParam("projectId", request.ProjectId),
                new TemplateParam("endpointId", request.EndpointId),
                new TemplateParam("id", request.Id),
            ],
            [new Param("updateMask", request.UpdateMask)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DeAbExperiment>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);
}
