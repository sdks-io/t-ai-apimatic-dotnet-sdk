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
using TogetherApIs.Requests.Evaluation;

namespace TogetherApIs.Api;

public sealed class Evaluation
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Evaluation(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Create an evaluation job
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="EvaluationResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CreateEvaluationJobError"/> when the server returns an error response.</exception>
    public Task<EvaluationResponse> CreateEvaluationJob(CreateEvaluationJobRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/evaluation"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<EvaluationResponse>(),
            CreateEvaluationJobError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get all evaluation jobs
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="EvaluationJob"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetAllEvaluationJobsError"/> when the server returns an error response.</exception>
    public Task<IReadOnlyList<EvaluationJob>> GetAllEvaluationJobs(GetAllEvaluationJobsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/evaluation"),
            [],
            [new Param("status", request.Status), new Param("limit", request.Limit)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<EvaluationJob>>(),
            GetAllEvaluationJobsError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get evaluation job details
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="EvaluationJob"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetEvaluationJobDetailsError"/> when the server returns an error response.</exception>
    public Task<EvaluationJob> GetEvaluationJobDetails(GetEvaluationJobDetailsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/evaluation/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<EvaluationJob>(),
            GetEvaluationJobDetailsError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get evaluation job status and results
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="EvaluationStatusResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetEvaluationJobStatusAndResultsError"/> when the server returns an error response.</exception>
    public Task<EvaluationStatusResponse> GetEvaluationJobStatusAndResults(GetEvaluationJobStatusAndResultsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/evaluation/{id}/status"),
            [new TemplateParam("id", request.Id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<EvaluationStatusResponse>(),
            GetEvaluationJobStatusAndResultsError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get model list
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="EvaluationModelListResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetModelListError"/> when the server returns an error response.</exception>
    public Task<EvaluationModelListResponse> GetModelList(GetModelListRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/evaluation/model-list"),
            [],
            [new Param("model_source", request.ModelSource)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<EvaluationModelListResponse>(),
            GetModelListError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);
}
