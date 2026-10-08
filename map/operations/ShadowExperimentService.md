<!-- Generated file — do not edit; regenerated with the SDK. -->

# ShadowExperimentService — operations

Accessor: `client.ShadowExperimentService` · Source: `Api/ShadowExperimentService.cs` · 10 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ShadowExperimentServiceCreateShadowExperiment

- **Auth**: `options.BearerAuth`
- **Signature**: `ShadowExperimentServiceCreateShadowExperiment(ShadowExperimentServiceCreateShadowExperimentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `EndpointId`, `Body`
- **Returns**: `DeShadowExperiment`
- **Error**: `ApiException<ShadowExperimentServiceCreateShadowExperimentError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorData(out ErrorData)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ShadowExperimentServiceCreateShadowExperimentRequest` | `Requests/ShadowExperimentService/ShadowExperimentServiceCreateShadowExperimentRequest.cs` |
| `DeCreateShadowExperimentRequest` | `Models/DeCreateShadowExperimentRequest.cs` |
| `DeShadowExperiment` | `Models/DeShadowExperiment.cs` |
| `ShadowExperimentServiceCreateShadowExperimentError` | `Errors/ShadowExperimentServiceCreateShadowExperimentError.cs` |
| `ErrorData` | `Models/ErrorData.cs` |

### ShadowExperimentServiceCreateTarget

- **Auth**: `options.BearerAuth`
- **Signature**: `ShadowExperimentServiceCreateTarget(ShadowExperimentServiceCreateTargetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `EndpointId`, `ExperimentId`, `Body`
- **Returns**: `DeShadowExperimentTarget`
- **Error**: `ApiException<ShadowExperimentServiceCreateTargetError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorData(out ErrorData)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ShadowExperimentServiceCreateTargetRequest` | `Requests/ShadowExperimentService/ShadowExperimentServiceCreateTargetRequest.cs` |
| `DeCreateShadowExperimentTargetRequest` | `Models/DeCreateShadowExperimentTargetRequest.cs` |
| `DeShadowExperimentTarget` | `Models/DeShadowExperimentTarget.cs` |
| `ShadowExperimentServiceCreateTargetError` | `Errors/ShadowExperimentServiceCreateTargetError.cs` |
| `ErrorData` | `Models/ErrorData.cs` |

### ShadowExperimentServiceDeleteShadowExperiment

- **Auth**: `options.BearerAuth`
- **Signature**: `ShadowExperimentServiceDeleteShadowExperiment(ShadowExperimentServiceDeleteShadowExperimentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `EndpointId`, `Id`
- **Query params (wire ← C#)**: `etag` ← `Etag`
- **Returns**: `object`
- **Error**: `ApiException<ShadowExperimentServiceDeleteShadowExperimentError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorData(out ErrorData)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ShadowExperimentServiceDeleteShadowExperimentRequest` | `Requests/ShadowExperimentService/ShadowExperimentServiceDeleteShadowExperimentRequest.cs` |
| `ShadowExperimentServiceDeleteShadowExperimentError` | `Errors/ShadowExperimentServiceDeleteShadowExperimentError.cs` |
| `ErrorData` | `Models/ErrorData.cs` |

### ShadowExperimentServiceDeleteTarget

- **Auth**: `options.BearerAuth`
- **Signature**: `ShadowExperimentServiceDeleteTarget(ShadowExperimentServiceDeleteTargetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `EndpointId`, `ExperimentId`, `Id`
- **Query params (wire ← C#)**: `etag` ← `Etag`
- **Returns**: `object`
- **Error**: `ApiException<ShadowExperimentServiceDeleteTargetError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorData(out ErrorData)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ShadowExperimentServiceDeleteTargetRequest` | `Requests/ShadowExperimentService/ShadowExperimentServiceDeleteTargetRequest.cs` |
| `ShadowExperimentServiceDeleteTargetError` | `Errors/ShadowExperimentServiceDeleteTargetError.cs` |
| `ErrorData` | `Models/ErrorData.cs` |

### ShadowExperimentServiceGetShadowExperiment

- **Auth**: `options.BearerAuth`
- **Signature**: `ShadowExperimentServiceGetShadowExperiment(ShadowExperimentServiceGetShadowExperimentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `EndpointId`, `Id`
- **Returns**: `DeShadowExperiment`
- **Error**: `ApiException<ShadowExperimentServiceGetShadowExperimentError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorData(out ErrorData)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ShadowExperimentServiceGetShadowExperimentRequest` | `Requests/ShadowExperimentService/ShadowExperimentServiceGetShadowExperimentRequest.cs` |
| `DeShadowExperiment` | `Models/DeShadowExperiment.cs` |
| `ShadowExperimentServiceGetShadowExperimentError` | `Errors/ShadowExperimentServiceGetShadowExperimentError.cs` |
| `ErrorData` | `Models/ErrorData.cs` |

### ShadowExperimentServiceGetTarget

- **Auth**: `options.BearerAuth`
- **Signature**: `ShadowExperimentServiceGetTarget(ShadowExperimentServiceGetTargetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `EndpointId`, `ExperimentId`, `Id`
- **Returns**: `DeShadowExperimentTarget`
- **Error**: `ApiException<ShadowExperimentServiceGetTargetError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorData(out ErrorData)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ShadowExperimentServiceGetTargetRequest` | `Requests/ShadowExperimentService/ShadowExperimentServiceGetTargetRequest.cs` |
| `DeShadowExperimentTarget` | `Models/DeShadowExperimentTarget.cs` |
| `ShadowExperimentServiceGetTargetError` | `Errors/ShadowExperimentServiceGetTargetError.cs` |
| `ErrorData` | `Models/ErrorData.cs` |

### ShadowExperimentServiceListShadowExperiments

- **Auth**: `options.BearerAuth`
- **Signature**: `ShadowExperimentServiceListShadowExperiments(ShadowExperimentServiceListShadowExperimentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `EndpointId`
- **Query params (wire ← C#)**: `limit` ← `Limit`, `after` ← `After`, `includeTargets` ← `IncludeTargets`
- **Returns**: `DeListShadowExperimentsResponse`
- **Error**: `ApiException<ShadowExperimentServiceListShadowExperimentsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorData(out ErrorData)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ShadowExperimentServiceListShadowExperimentsRequest` | `Requests/ShadowExperimentService/ShadowExperimentServiceListShadowExperimentsRequest.cs` |
| `DeListShadowExperimentsResponse` | `Models/DeListShadowExperimentsResponse.cs` |
| `ShadowExperimentServiceListShadowExperimentsError` | `Errors/ShadowExperimentServiceListShadowExperimentsError.cs` |
| `ErrorData` | `Models/ErrorData.cs` |

### ShadowExperimentServiceListTargets

- **Auth**: `options.BearerAuth`
- **Signature**: `ShadowExperimentServiceListTargets(ShadowExperimentServiceListTargetsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `EndpointId`, `ExperimentId`
- **Query params (wire ← C#)**: `limit` ← `Limit`, `after` ← `After`
- **Returns**: `DeListShadowExperimentTargetsResponse`
- **Error**: `ApiException<ShadowExperimentServiceListTargetsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorData(out ErrorData)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ShadowExperimentServiceListTargetsRequest` | `Requests/ShadowExperimentService/ShadowExperimentServiceListTargetsRequest.cs` |
| `DeListShadowExperimentTargetsResponse` | `Models/DeListShadowExperimentTargetsResponse.cs` |
| `ShadowExperimentServiceListTargetsError` | `Errors/ShadowExperimentServiceListTargetsError.cs` |
| `ErrorData` | `Models/ErrorData.cs` |

### ShadowExperimentServiceUpdateShadowExperiment

- **Auth**: `options.BearerAuth`
- **Signature**: `ShadowExperimentServiceUpdateShadowExperiment(ShadowExperimentServiceUpdateShadowExperimentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `EndpointId`, `Id`, `UpdateMask`, `Body`
- **Query params (wire ← C#)**: `updateMask` ← `UpdateMask`
- **Returns**: `DeShadowExperiment`
- **Error**: `ApiException<ShadowExperimentServiceUpdateShadowExperimentError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorData(out ErrorData)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ShadowExperimentServiceUpdateShadowExperimentRequest` | `Requests/ShadowExperimentService/ShadowExperimentServiceUpdateShadowExperimentRequest.cs` |
| `DeUpdateShadowExperimentRequest` | `Models/DeUpdateShadowExperimentRequest.cs` |
| `DeShadowExperiment` | `Models/DeShadowExperiment.cs` |
| `ShadowExperimentServiceUpdateShadowExperimentError` | `Errors/ShadowExperimentServiceUpdateShadowExperimentError.cs` |
| `ErrorData` | `Models/ErrorData.cs` |

### ShadowExperimentServiceUpdateTarget

- **Auth**: `options.BearerAuth`
- **Signature**: `ShadowExperimentServiceUpdateTarget(ShadowExperimentServiceUpdateTargetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `EndpointId`, `ExperimentId`, `Id`, `UpdateMask`, `Body`
- **Query params (wire ← C#)**: `updateMask` ← `UpdateMask`
- **Returns**: `DeShadowExperimentTarget`
- **Error**: `ApiException<ShadowExperimentServiceUpdateTargetError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorData(out ErrorData)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ShadowExperimentServiceUpdateTargetRequest` | `Requests/ShadowExperimentService/ShadowExperimentServiceUpdateTargetRequest.cs` |
| `DeUpdateShadowExperimentTargetRequest` | `Models/DeUpdateShadowExperimentTargetRequest.cs` |
| `DeShadowExperimentTarget` | `Models/DeShadowExperimentTarget.cs` |
| `ShadowExperimentServiceUpdateTargetError` | `Errors/ShadowExperimentServiceUpdateTargetError.cs` |
| `ErrorData` | `Models/ErrorData.cs` |

