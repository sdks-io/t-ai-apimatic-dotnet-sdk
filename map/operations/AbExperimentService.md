<!-- Generated file — do not edit; regenerated with the SDK. -->

# AbExperimentService — operations

Accessor: `client.AbExperimentService` · Source: `Api/AbExperimentService.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AbExperimentServiceCreateAbExperiment

- **Auth**: `options.BearerAuth`
- **Signature**: `AbExperimentServiceCreateAbExperiment(AbExperimentServiceCreateAbExperimentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `EndpointId`, `Body`
- **Returns**: `DeAbExperiment`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AbExperimentServiceCreateAbExperimentRequest` | `Requests/AbExperimentService/AbExperimentServiceCreateAbExperimentRequest.cs` |
| `DeCreateAbExperimentRequest` | `Models/DeCreateAbExperimentRequest.cs` |
| `DeAbExperiment` | `Models/DeAbExperiment.cs` |

### AbExperimentServiceDeleteAbExperiment

- **Auth**: `options.BearerAuth`
- **Signature**: `AbExperimentServiceDeleteAbExperiment(AbExperimentServiceDeleteAbExperimentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `EndpointId`, `Id`
- **Query params (wire ← C#)**: `etag` ← `Etag`
- **Returns**: `object`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AbExperimentServiceDeleteAbExperimentRequest` | `Requests/AbExperimentService/AbExperimentServiceDeleteAbExperimentRequest.cs` |

### AbExperimentServiceGetAbExperiment

- **Auth**: `options.BearerAuth`
- **Signature**: `AbExperimentServiceGetAbExperiment(AbExperimentServiceGetAbExperimentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `EndpointId`, `Id`
- **Returns**: `DeAbExperiment`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AbExperimentServiceGetAbExperimentRequest` | `Requests/AbExperimentService/AbExperimentServiceGetAbExperimentRequest.cs` |
| `DeAbExperiment` | `Models/DeAbExperiment.cs` |

### AbExperimentServiceListAbExperiments

- **Auth**: `options.BearerAuth`
- **Signature**: `AbExperimentServiceListAbExperiments(AbExperimentServiceListAbExperimentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `EndpointId`
- **Query params (wire ← C#)**: `limit` ← `Limit`, `after` ← `After`
- **Returns**: `DeListAbExperimentsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AbExperimentServiceListAbExperimentsRequest` | `Requests/AbExperimentService/AbExperimentServiceListAbExperimentsRequest.cs` |
| `DeListAbExperimentsResponse` | `Models/DeListAbExperimentsResponse.cs` |

### AbExperimentServiceUpdateAbExperiment

- **Auth**: `options.BearerAuth`
- **Signature**: `AbExperimentServiceUpdateAbExperiment(AbExperimentServiceUpdateAbExperimentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `EndpointId`, `Id`, `Body`
- **Query params (wire ← C#)**: `updateMask` ← `UpdateMask`
- **Returns**: `DeAbExperiment`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AbExperimentServiceUpdateAbExperimentRequest` | `Requests/AbExperimentService/AbExperimentServiceUpdateAbExperimentRequest.cs` |
| `DeUpdateAbExperimentRequest` | `Models/DeUpdateAbExperimentRequest.cs` |
| `DeAbExperiment` | `Models/DeAbExperiment.cs` |

