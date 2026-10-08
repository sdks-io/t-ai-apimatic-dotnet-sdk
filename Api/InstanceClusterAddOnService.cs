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
using TogetherApIs.Requests.InstanceClusterAddOnService;

namespace TogetherApIs.Api;

public sealed class InstanceClusterAddOnService
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal InstanceClusterAddOnService(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    public Task<AddOnInfo> InstanceClusterAddOnServiceCreate(InstanceClusterAddOnServiceCreateRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/compute/clusters/{cluster_id}/addons"),
            [new TemplateParam("cluster_id", request.ClusterId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<AddOnInfo>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    public Task<object> InstanceClusterAddOnServiceDelete(InstanceClusterAddOnServiceDeleteRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/compute/clusters/{cluster_id}/addons/{addon_id}"),
            [new TemplateParam("cluster_id", request.ClusterId), new TemplateParam("addon_id", request.AddonId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<object>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    public Task<AddOnInfo> InstanceClusterAddOnServiceGet(InstanceClusterAddOnServiceGetRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/compute/clusters/{cluster_id}/addons/{addon_id}"),
            [new TemplateParam("cluster_id", request.ClusterId), new TemplateParam("addon_id", request.AddonId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AddOnInfo>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    public Task<ClusterAddOnsListResponse> InstanceClusterAddOnServiceList(InstanceClusterAddOnServiceListRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/compute/clusters/{cluster_id}/addons"),
            [new TemplateParam("cluster_id", request.ClusterId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ClusterAddOnsListResponse>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    public Task<AddOnInfo> InstanceClusterAddOnServiceUpdate(InstanceClusterAddOnServiceUpdateRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/compute/clusters/{cluster_id}/addons/{addon_id}"),
            [new TemplateParam("cluster_id", request.ClusterId), new TemplateParam("addon_id", request.AddonId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<AddOnInfo>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);
}
