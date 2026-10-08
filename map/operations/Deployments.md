<!-- Generated file — do not edit; regenerated with the SDK. -->

# Deployments — operations

Accessor: `client.Deployments` · Source: `Api/Deployments.cs` · 9 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateANewDeployment

- **Auth**: `options.BearerAuth`
- **Signature**: `CreateANewDeployment(CreateANewDeploymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `DeploymentResponseItem`
- **Error**: `ApiException<CreateANewDeploymentError>` — **Case A (typed)**
- **Error accessors**: `TryGetAnonymousObject(out object)` [400, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateANewDeploymentRequest` | `Requests/Deployments/CreateANewDeploymentRequest.cs` |
| `CreateDeploymentRequest` | `Models/CreateDeploymentRequest.cs` |
| `DeploymentResponseItem` | `Models/DeploymentResponseItem.cs` |
| `CreateANewDeploymentError` | `Errors/CreateANewDeploymentError.cs` |

### DeleteADeployment

- **Auth**: `options.BearerAuth`
- **Signature**: `DeleteADeployment(DeleteADeploymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `object`
- **Error**: `ApiException<DeleteADeploymentError>` — **Case A (typed)**
- **Error accessors**: `TryGetAnonymousObject(out object)` [404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteADeploymentRequest` | `Requests/Deployments/DeleteADeploymentRequest.cs` |
| `DeleteADeploymentError` | `Errors/DeleteADeploymentError.cs` |

### GetADeploymentByIdOrName

- **Auth**: `options.BearerAuth`
- **Signature**: `GetADeploymentByIdOrName(GetADeploymentByIdOrNameRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `DeploymentResponseItem`
- **Error**: `ApiException<GetADeploymentByIdOrNameError>` — **Case A (typed)**
- **Error accessors**: `TryGetAnonymousObject(out object)` [404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetADeploymentByIdOrNameRequest` | `Requests/Deployments/GetADeploymentByIdOrNameRequest.cs` |
| `DeploymentResponseItem` | `Models/DeploymentResponseItem.cs` |
| `GetADeploymentByIdOrNameError` | `Errors/GetADeploymentByIdOrNameError.cs` |

### GetLogsForADeployment

- **Auth**: `options.BearerAuth`
- **Signature**: `GetLogsForADeployment(GetLogsForADeploymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `replica_id` ← `ReplicaId`, `version` ← `Version`, `revision` ← `Revision`
- **Returns**: `DeploymentLogs`
- **Error**: `ApiException<GetLogsForADeploymentError>` — **Case A (typed)**
- **Error accessors**: `TryGetAnonymousObject(out object)` [404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetLogsForADeploymentRequest` | `Requests/Deployments/GetLogsForADeploymentRequest.cs` |
| `DeploymentLogs` | `Models/DeploymentLogs.cs` |
| `GetLogsForADeploymentError` | `Errors/GetLogsForADeploymentError.cs` |

### GetTheFullConfigurationOfASpecificRevision

- **Auth**: `options.BearerAuth`
- **Signature**: `GetTheFullConfigurationOfASpecificRevision(GetTheFullConfigurationOfASpecificRevisionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `RevisionIdentifier`
- **Returns**: `RevisionDetailResponse`
- **Error**: `ApiException<GetTheFullConfigurationOfASpecificRevisionError>` — **Case A (typed)**
- **Error accessors**: `TryGetAnonymousObject(out object)` [400, 404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTheFullConfigurationOfASpecificRevisionRequest` | `Requests/Deployments/GetTheFullConfigurationOfASpecificRevisionRequest.cs` |
| `RevisionDetailResponse` | `Models/RevisionDetailResponse.cs` |
| `GetTheFullConfigurationOfASpecificRevisionError` | `Errors/GetTheFullConfigurationOfASpecificRevisionError.cs` |

### GetTheListOfDeployments

- **Auth**: `options.BearerAuth`
- **Signature**: `GetTheListOfDeployments(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `DeploymentListResponse`
- **Error**: `ApiException<GetTheListOfDeploymentsError>` — **Case A (typed)**
- **Error accessors**: `TryGetAnonymousObject(out object)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeploymentListResponse` | `Models/DeploymentListResponse.cs` |
| `GetTheListOfDeploymentsError` | `Errors/GetTheListOfDeploymentsError.cs` |

### ListRevisionHistoryEventsOfADeployment

- **Auth**: `options.BearerAuth`
- **Signature**: `ListRevisionHistoryEventsOfADeployment(ListRevisionHistoryEventsOfADeploymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `limit` ← `Limit`, `before` ← `Before`
- **Returns**: `RevisionEventListResponse`
- **Error**: `ApiException<ListRevisionHistoryEventsOfADeploymentError>` — **Case A (typed)**
- **Error accessors**: `TryGetAnonymousObject(out object)` [400, 404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListRevisionHistoryEventsOfADeploymentRequest` | `Requests/Deployments/ListRevisionHistoryEventsOfADeploymentRequest.cs` |
| `RevisionEventListResponse` | `Models/RevisionEventListResponse.cs` |
| `ListRevisionHistoryEventsOfADeploymentError` | `Errors/ListRevisionHistoryEventsOfADeploymentError.cs` |

### RollBackADeploymentToAPreviousRevision

- **Auth**: `options.BearerAuth`
- **Signature**: `RollBackADeploymentToAPreviousRevision(RollBackADeploymentToAPreviousRevisionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `DeploymentResponseItem`
- **Error**: `ApiException<RollBackADeploymentToAPreviousRevisionError>` — **Case A (typed)**
- **Error accessors**: `TryGetAnonymousObject(out object)` [400, 404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RollBackADeploymentToAPreviousRevisionRequest` | `Requests/Deployments/RollBackADeploymentToAPreviousRevisionRequest.cs` |
| `RollbackDeploymentRequest` | `Models/RollbackDeploymentRequest.cs` |
| `DeploymentResponseItem` | `Models/DeploymentResponseItem.cs` |
| `RollBackADeploymentToAPreviousRevisionError` | `Errors/RollBackADeploymentToAPreviousRevisionError.cs` |

### UpdateADeployment

- **Auth**: `options.BearerAuth`
- **Signature**: `UpdateADeployment(UpdateADeploymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `DeploymentResponseItem`
- **Error**: `ApiException<UpdateADeploymentError>` — **Case A (typed)**
- **Error accessors**: `TryGetAnonymousObject(out object)` [400, 404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateADeploymentRequest` | `Requests/Deployments/UpdateADeploymentRequest.cs` |
| `UpdateDeploymentRequest` | `Models/UpdateDeploymentRequest.cs` |
| `DeploymentResponseItem` | `Models/DeploymentResponseItem.cs` |
| `UpdateADeploymentError` | `Errors/UpdateADeploymentError.cs` |

