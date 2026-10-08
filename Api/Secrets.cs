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
using TogetherApIs.Requests.Secrets;

namespace TogetherApIs.Api;

public sealed class Secrets
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Secrets(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Create a new secret
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SecretResponseItem"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CreateANewSecretError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a new secret to store sensitive configuration values
    /// </remarks>
    public Task<SecretResponseItem> CreateANewSecret(CreateANewSecretRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/deployments/secrets"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<SecretResponseItem>(),
            CreateANewSecretError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Delete a secret
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="object"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteASecretError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete an existing secret
    /// </remarks>
    public Task<object> DeleteASecret(DeleteASecretRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/deployments/secrets/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<object>(),
            DeleteASecretError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a secret by ID or name
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SecretResponseItem"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetASecretByIdOrNameError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieve details of a specific secret by its ID or name
    /// </remarks>
    public Task<SecretResponseItem> GetASecretByIdOrName(GetASecretByIdOrNameRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/deployments/secrets/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SecretResponseItem>(),
            GetASecretByIdOrNameError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get the list of project secrets
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListSecretsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetTheListOfProjectSecretsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieve all secrets in your project
    /// </remarks>
    public Task<ListSecretsResponse> GetTheListOfProjectSecrets(RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/deployments/secrets"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListSecretsResponse>(),
            GetTheListOfProjectSecretsError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update a secret
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SecretResponseItem"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UpdateASecretError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update an existing secret's value or metadata
    /// </remarks>
    public Task<SecretResponseItem> UpdateASecret(UpdateASecretRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/deployments/secrets/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            JsonResponse.Create<SecretResponseItem>(),
            UpdateASecretError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);
}
