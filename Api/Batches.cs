using System;
using System.Collections.Generic;
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
using TogetherApIs.Requests.Batches;

namespace TogetherApIs.Api;

public sealed class Batches
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Batches(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Cancel a batch job
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BatchJob"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CancelABatchJobError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Cancel a batch job by ID
    /// </remarks>
    public Task<BatchJob> CancelABatchJob(CancelABatchJobRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/batches/{id}/cancel"),
            [new TemplateParam("id", request.Id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<BatchJob>(),
            CancelABatchJobError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Create a batch job
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BatchJobWithWarning"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CreateABatchJobError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a new batch job with the given input file and endpoint
    /// </remarks>
    public Task<BatchJobWithWarning> CreateABatchJob(CreateABatchJobRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/batches"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<BatchJobWithWarning>(),
            CreateABatchJobError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a batch job
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BatchJob"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetABatchJobError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get details of a batch job by ID
    /// </remarks>
    public Task<BatchJob> GetABatchJob(GetABatchJobRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/batches/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<BatchJob>(),
            GetABatchJobError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// List batch jobs
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="BatchJob"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListBatchJobsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List all batch jobs for the authenticated user
    /// </remarks>
    public Task<IReadOnlyList<BatchJob>> ListBatchJobs(RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/batches"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<BatchJob>>(),
            ListBatchJobsError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);
}
