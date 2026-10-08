<!-- Generated file — do not edit; regenerated with the SDK. -->

# RolloutService — operations

Accessor: `client.RolloutService` · Source: `Api/RolloutService.cs` · 10 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### RolloutServiceCancelRollout

- **Auth**: `options.BearerAuth`
- **Signature**: `RolloutServiceCancelRollout(RolloutServiceCancelRolloutRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `EndpointId`, `Id`, `Body`
- **Returns**: `DeRollout`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RolloutServiceCancelRolloutRequest` | `Requests/RolloutService/RolloutServiceCancelRolloutRequest.cs` |
| `DeCancelRolloutRequest` | `Models/DeCancelRolloutRequest.cs` |
| `DeRollout` | `Models/DeRollout.cs` |

### RolloutServiceCreateRollout

- **Auth**: `options.BearerAuth`
- **Signature**: `RolloutServiceCreateRollout(RolloutServiceCreateRolloutRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `EndpointId`, `Body`
- **Returns**: `DeRollout`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RolloutServiceCreateRolloutRequest` | `Requests/RolloutService/RolloutServiceCreateRolloutRequest.cs` |
| `DeCreateRolloutRequest3` | `Models/AnyOf/DeCreateRolloutRequest3.cs` |
| `DeRollout` | `Models/DeRollout.cs` |

### RolloutServiceDeleteRollout

- **Auth**: `options.BearerAuth`
- **Signature**: `RolloutServiceDeleteRollout(RolloutServiceDeleteRolloutRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `EndpointId`, `Id`
- **Query params (wire ← C#)**: `etag` ← `Etag`
- **Returns**: `object`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RolloutServiceDeleteRolloutRequest` | `Requests/RolloutService/RolloutServiceDeleteRolloutRequest.cs` |

### RolloutServiceGetRollout

- **Auth**: `options.BearerAuth`
- **Signature**: `RolloutServiceGetRollout(RolloutServiceGetRolloutRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `EndpointId`, `Id`
- **Returns**: `DeRollout`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RolloutServiceGetRolloutRequest` | `Requests/RolloutService/RolloutServiceGetRolloutRequest.cs` |
| `DeRollout` | `Models/DeRollout.cs` |

### RolloutServiceListRollouts

- **Auth**: `options.BearerAuth`
- **Signature**: `RolloutServiceListRollouts(RolloutServiceListRolloutsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `EndpointId`
- **Query params (wire ← C#)**: `limit` ← `Limit`, `after` ← `After`, `filter` ← `Filter`
- **Returns**: `DeListRolloutsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RolloutServiceListRolloutsRequest` | `Requests/RolloutService/RolloutServiceListRolloutsRequest.cs` |
| `Filter` | `Models/Enums/Filter.cs` |
| `DeListRolloutsResponse` | `Models/DeListRolloutsResponse.cs` |

### RolloutServicePauseRollout

- **Auth**: `options.BearerAuth`
- **Signature**: `RolloutServicePauseRollout(RolloutServicePauseRolloutRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `EndpointId`, `Id`, `Body`
- **Returns**: `DeRollout`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RolloutServicePauseRolloutRequest` | `Requests/RolloutService/RolloutServicePauseRolloutRequest.cs` |
| `DePauseRolloutRequest` | `Models/DePauseRolloutRequest.cs` |
| `DeRollout` | `Models/DeRollout.cs` |

### RolloutServicePreviewRolloutDefaults

- **Auth**: `options.BearerAuth`
- **Signature**: `RolloutServicePreviewRolloutDefaults(RolloutServicePreviewRolloutDefaultsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `EndpointId`, `Body`
- **Returns**: `DeRolloutDefaultsPreview`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RolloutServicePreviewRolloutDefaultsRequest` | `Requests/RolloutService/RolloutServicePreviewRolloutDefaultsRequest.cs` |
| `DeCreateRolloutRequest3` | `Models/AnyOf/DeCreateRolloutRequest3.cs` |
| `DeRolloutDefaultsPreview` | `Models/DeRolloutDefaultsPreview.cs` |

### RolloutServicePromoteRollout

- **Auth**: `options.BearerAuth`
- **Signature**: `RolloutServicePromoteRollout(RolloutServicePromoteRolloutRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `EndpointId`, `Id`, `Body`
- **Returns**: `DeRollout`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RolloutServicePromoteRolloutRequest` | `Requests/RolloutService/RolloutServicePromoteRolloutRequest.cs` |
| `DePromoteRolloutRequest` | `Models/DePromoteRolloutRequest.cs` |
| `DeRollout` | `Models/DeRollout.cs` |

### RolloutServiceResumeRollout

- **Auth**: `options.BearerAuth`
- **Signature**: `RolloutServiceResumeRollout(RolloutServiceResumeRolloutRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `EndpointId`, `Id`, `Body`
- **Returns**: `DeRollout`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RolloutServiceResumeRolloutRequest` | `Requests/RolloutService/RolloutServiceResumeRolloutRequest.cs` |
| `DeResumeRolloutRequest` | `Models/DeResumeRolloutRequest.cs` |
| `DeRollout` | `Models/DeRollout.cs` |

### RolloutServiceStartRollout

- **Auth**: `options.BearerAuth`
- **Signature**: `RolloutServiceStartRollout(RolloutServiceStartRolloutRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `EndpointId`, `Id`
- **Returns**: `DeRollout`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RolloutServiceStartRolloutRequest` | `Requests/RolloutService/RolloutServiceStartRolloutRequest.cs` |
| `DeRollout` | `Models/DeRollout.cs` |

