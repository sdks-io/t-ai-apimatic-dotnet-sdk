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
using TogetherApIs.Requests.Deployments;

namespace TogetherApIs.Api;

public sealed class Deployments
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Deployments(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Create a new deployment
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeploymentResponseItem"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CreateANewDeploymentError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a new deployment with specified configuration
    /// </remarks>
    public Task<DeploymentResponseItem> CreateANewDeployment(CreateANewDeploymentRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/deployments"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DeploymentResponseItem>(),
            CreateANewDeploymentError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Delete a deployment
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="object"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteADeploymentError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete an existing deployment
    /// </remarks>
    public Task<object> DeleteADeployment(DeleteADeploymentRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/deployments/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<object>(),
            DeleteADeploymentError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a deployment by ID or name
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeploymentResponseItem"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetADeploymentByIdOrNameError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieve details of a specific deployment by its ID or name
    /// </remarks>
    public Task<DeploymentResponseItem> GetADeploymentByIdOrName(GetADeploymentByIdOrNameRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/deployments/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DeploymentResponseItem>(),
            GetADeploymentByIdOrNameError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get logs for a deployment
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeploymentLogs"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetLogsForADeploymentError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieve logs from a deployment, optionally filtered by replica ID.
    /// </remarks>
    public Task<DeploymentLogs> GetLogsForADeployment(GetLogsForADeploymentRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/deployments/{id}/logs"),
            [new TemplateParam("id", request.Id)],
            [
                new Param("replica_id", request.ReplicaId),
                new Param("version", request.Version),
                new Param("revision", request.Revision),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DeploymentLogs>(),
            GetLogsForADeploymentError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get the full configuration of a specific revision
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RevisionDetailResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetTheFullConfigurationOfASpecificRevisionError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the deployment configuration defined by the specified revision.
    /// Only the 50 most recent revisions per deployment retain their configuration; older revisions return 404 even while they still appear in the revision history.
    /// The deployment's currently active revision is always available, regardless of age.
    /// </remarks>
    public Task<RevisionDetailResponse> GetTheFullConfigurationOfASpecificRevision(GetTheFullConfigurationOfASpecificRevisionRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/deployments/{id}/revisions/{revisionIdentifier}"),
            [new TemplateParam("id", request.Id), new TemplateParam("revisionIdentifier", request.RevisionIdentifier)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RevisionDetailResponse>(),
            GetTheFullConfigurationOfASpecificRevisionError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get the list of deployments
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeploymentListResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetTheListOfDeploymentsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get a list of all deployments in your project
    /// </remarks>
    public Task<DeploymentListResponse> GetTheListOfDeployments(RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/deployments"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DeploymentListResponse>(),
            GetTheListOfDeploymentsError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// List revision history events of a deployment
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RevisionEventListResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListRevisionHistoryEventsOfADeploymentError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the revision history of the deployment, in descending order. Defaults to the most recent events.
    /// Only the 200 most recent events are retained per deployment; paginating past that returns an empty list.
    /// </remarks>
    public Task<RevisionEventListResponse> ListRevisionHistoryEventsOfADeployment(ListRevisionHistoryEventsOfADeploymentRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/deployments/{id}/revisions"),
            [new TemplateParam("id", request.Id)],
            [new Param("limit", request.Limit), new Param("before", request.Before)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RevisionEventListResponse>(),
            ListRevisionHistoryEventsOfADeploymentError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Roll back a deployment to a previous revision
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeploymentResponseItem"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RollBackADeploymentToAPreviousRevisionError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Re-applies the spec of a previous revision. Pods running the target revision will be retained. Other pods will be drained and restarted with the target revision.
    /// Only the 50 most recent revisions per deployment can be rolled back to; older targets return 404.
    /// </remarks>
    public Task<DeploymentResponseItem> RollBackADeploymentToAPreviousRevision(RollBackADeploymentToAPreviousRevisionRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/deployments/{id}/rollback"),
            [new TemplateParam("id", request.Id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DeploymentResponseItem>(),
            RollBackADeploymentToAPreviousRevisionError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update a deployment
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeploymentResponseItem"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UpdateADeploymentError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update an existing deployment configuration
    /// </remarks>
    public Task<DeploymentResponseItem> UpdateADeployment(UpdateADeploymentRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/deployments/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DeploymentResponseItem>(),
            UpdateADeploymentError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);
}
