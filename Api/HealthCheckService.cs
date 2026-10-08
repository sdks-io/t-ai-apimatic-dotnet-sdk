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
using TogetherApIs.Requests.HealthCheckService;

namespace TogetherApIs.Api;

public sealed class HealthCheckService
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal HealthCheckService(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// List passive health check alerts
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListPassiveHealthCheckAlertsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists passive health check alerts. Filters combine across axes; empty values skip that axis.
    /// </remarks>
    public Task<ListPassiveHealthCheckAlertsResponse> HealthCheckServiceListPassiveHealthCheckAlerts(HealthCheckServiceListPassiveHealthCheckAlertsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/compute/passive_health_check_alerts"),
            [],
            [
                new Param("intent_id", request.IntentId),
                new Param("instance_id", request.InstanceId),
                new Param("cluster_id", request.ClusterId),
                new Param("page_size", request.PageSize),
                new Param("page_token", request.PageToken),
                new Param("status", request.Status),
                new Param("severity_filter", request.SeverityFilter),
                new Param("order_by", request.OrderBy),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListPassiveHealthCheckAlertsResponse>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);
}
