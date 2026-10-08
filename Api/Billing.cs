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
using TogetherApIs.Requests.Billing;

namespace TogetherApIs.Api;

public sealed class Billing
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Billing(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get billing usage
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BillingUsageReport"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetBillingUsageError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns an organization's billing usage for a month as cost-annotated line items grouped into time windows. Finalized windows are returned through the end of yesterday at daily granularity, or the last completed hour at hourly granularity (UTC).
    /// </remarks>
    public Task<BillingUsageReport> GetBillingUsage(GetBillingUsageRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/billing/usage"),
            [],
            [
                new Param("month", request.Month),
                new Param("organization_id", request.OrganizationId),
                new Param("granularity", request.Granularity),
                new Param("limit", request.Limit),
                new Param("after", request.After),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<BillingUsageReport>(),
            GetBillingUsageError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);
}
