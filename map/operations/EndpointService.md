<!-- Generated file — do not edit; regenerated with the SDK. -->

# EndpointService — operations

Accessor: `client.EndpointService` · Source: `Api/EndpointService.cs` · 9 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### EndpointServiceCreateEndpoint

- **Auth**: `options.BearerAuth`
- **Signature**: `EndpointServiceCreateEndpoint(EndpointServiceCreateEndpointRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `Body`
- **Returns**: `DeEndpoint`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `EndpointServiceCreateEndpointRequest` | `Requests/EndpointService/EndpointServiceCreateEndpointRequest.cs` |
| `DeCreateEndpointRequest` | `Models/DeCreateEndpointRequest.cs` |
| `DeEndpoint` | `Models/DeEndpoint.cs` |

### EndpointServiceDeleteEndpoint

- **Auth**: `options.BearerAuth`
- **Signature**: `EndpointServiceDeleteEndpoint(EndpointServiceDeleteEndpointRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `Id`
- **Query params (wire ← C#)**: `etag` ← `Etag`
- **Returns**: `object`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `EndpointServiceDeleteEndpointRequest` | `Requests/EndpointService/EndpointServiceDeleteEndpointRequest.cs` |

### EndpointServiceGetEndpoint

- **Auth**: `options.BearerAuth`
- **Signature**: `EndpointServiceGetEndpoint(EndpointServiceGetEndpointRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `Id`
- **Returns**: `DeEndpoint`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `EndpointServiceGetEndpointRequest` | `Requests/EndpointService/EndpointServiceGetEndpointRequest.cs` |
| `DeEndpoint` | `Models/DeEndpoint.cs` |

### EndpointServiceGetEndpointAnalytics

- **Auth**: `options.BearerAuth`
- **Signature**: `EndpointServiceGetEndpointAnalytics(EndpointServiceGetEndpointAnalyticsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `Id`
- **Query params (wire ← C#)**: `deploymentId` ← `DeploymentId`, `startTime` ← `StartTime`, `endTime` ← `EndTime`, `includeTimeSeries` ← `IncludeTimeSeries`, `granularity` ← `Granularity`
- **Returns**: `DeAnalyticsData`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `EndpointServiceGetEndpointAnalyticsRequest` | `Requests/EndpointService/EndpointServiceGetEndpointAnalyticsRequest.cs` |
| `DeAnalyticsData` | `Models/DeAnalyticsData.cs` |

### EndpointServiceListEndpointEvents

- **Auth**: `options.BearerAuth`
- **Signature**: `EndpointServiceListEndpointEvents(EndpointServiceListEndpointEventsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `Id`
- **Query params (wire ← C#)**: `limit` ← `Limit`, `after` ← `After`, `types` ← `Types`, `minLevel` ← `MinLevel`, `since` ← `Since`, `until` ← `Until`, `deploymentIds` ← `DeploymentIds`, `sourceKinds` ← `SourceKinds`, `subjectId` ← `SubjectId`
- **Returns**: `DeListEndpointEventsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `EndpointServiceListEndpointEventsRequest` | `Requests/EndpointService/EndpointServiceListEndpointEventsRequest.cs` |
| `MinLevel` | `Models/Enums/MinLevel.cs` |
| `SourceKind1` | `Models/Enums/SourceKind1.cs` |
| `DeListEndpointEventsResponse` | `Models/DeListEndpointEventsResponse.cs` |

### EndpointServiceListEndpoints

- **Auth**: `options.BearerAuth`
- **Signature**: `EndpointServiceListEndpoints(EndpointServiceListEndpointsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`
- **Query params (wire ← C#)**: `limit` ← `Limit`, `after` ← `After`, `orderBy` ← `OrderBy`, `filter` ← `Filter`
- **Returns**: `DeListEndpointsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `EndpointServiceListEndpointsRequest` | `Requests/EndpointService/EndpointServiceListEndpointsRequest.cs` |
| `DeListEndpointsResponse` | `Models/DeListEndpointsResponse.cs` |

### EndpointServiceListOrganizationEndpoints

- **Auth**: `options.BearerAuth`
- **Signature**: `EndpointServiceListOrganizationEndpoints(EndpointServiceListOrganizationEndpointsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `OrganizationId`
- **Query params (wire ← C#)**: `limit` ← `Limit`, `after` ← `After`, `orderBy` ← `OrderBy`, `filter` ← `Filter`
- **Returns**: `DeListEndpointsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `EndpointServiceListOrganizationEndpointsRequest` | `Requests/EndpointService/EndpointServiceListOrganizationEndpointsRequest.cs` |
| `DeListEndpointsResponse` | `Models/DeListEndpointsResponse.cs` |

### EndpointServiceListPublicEndpoints

- **Auth**: `options.BearerAuth`
- **Signature**: `EndpointServiceListPublicEndpoints(EndpointServiceListPublicEndpointsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `limit` ← `Limit`, `after` ← `After`, `orderBy` ← `OrderBy`, `filter` ← `Filter`
- **Returns**: `DeListPublicEndpointsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `EndpointServiceListPublicEndpointsRequest` | `Requests/EndpointService/EndpointServiceListPublicEndpointsRequest.cs` |
| `DeListPublicEndpointsResponse` | `Models/DeListPublicEndpointsResponse.cs` |

### EndpointServiceUpdateEndpoint

- **Auth**: `options.BearerAuth`
- **Signature**: `EndpointServiceUpdateEndpoint(EndpointServiceUpdateEndpointRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `Id`, `Body`
- **Query params (wire ← C#)**: `updateMask` ← `UpdateMask`
- **Returns**: `DeEndpoint`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `EndpointServiceUpdateEndpointRequest` | `Requests/EndpointService/EndpointServiceUpdateEndpointRequest.cs` |
| `DeEndpointUpdate` | `Models/DeEndpointUpdate.cs` |
| `DeEndpoint` | `Models/DeEndpoint.cs` |

