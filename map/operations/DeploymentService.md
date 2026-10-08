<!-- Generated file — do not edit; regenerated with the SDK. -->

# DeploymentService — operations

Accessor: `client.DeploymentService` · Source: `Api/DeploymentService.cs` · 10 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeploymentServiceAddAdapter

- **Auth**: `options.BearerAuth`
- **Signature**: `DeploymentServiceAddAdapter(DeploymentServiceAddAdapterRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `EndpointId`, `DeploymentId`, `Body`
- **Returns**: `DeAdapterEntry`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeploymentServiceAddAdapterRequest` | `Requests/DeploymentService/DeploymentServiceAddAdapterRequest.cs` |
| `DeAddAdapterRequest` | `Models/DeAddAdapterRequest.cs` |
| `DeAdapterEntry` | `Models/DeAdapterEntry.cs` |

### DeploymentServiceCreateDeployment

- **Auth**: `options.BearerAuth`
- **Signature**: `DeploymentServiceCreateDeployment(DeploymentServiceCreateDeploymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `EndpointId`, `Body`
- **Query params (wire ← C#)**: `validateOnly` ← `ValidateOnly`
- **Returns**: `DeDeployment`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeploymentServiceCreateDeploymentRequest` | `Requests/DeploymentService/DeploymentServiceCreateDeploymentRequest.cs` |
| `DeCreateDeploymentRequest` | `Models/DeCreateDeploymentRequest.cs` |
| `DeDeployment` | `Models/DeDeployment.cs` |

### DeploymentServiceDeleteDeployment

- **Auth**: `options.BearerAuth`
- **Signature**: `DeploymentServiceDeleteDeployment(DeploymentServiceDeleteDeploymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `EndpointId`, `Id`
- **Query params (wire ← C#)**: `etag` ← `Etag`
- **Returns**: `object`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeploymentServiceDeleteDeploymentRequest` | `Requests/DeploymentService/DeploymentServiceDeleteDeploymentRequest.cs` |

### DeploymentServiceGetAdapter

- **Auth**: `options.BearerAuth`
- **Signature**: `DeploymentServiceGetAdapter(DeploymentServiceGetAdapterRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `EndpointId`, `DeploymentId`, `Id`
- **Returns**: `DeAdapterEntry`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeploymentServiceGetAdapterRequest` | `Requests/DeploymentService/DeploymentServiceGetAdapterRequest.cs` |
| `DeAdapterEntry` | `Models/DeAdapterEntry.cs` |

### DeploymentServiceGetDeployment

- **Auth**: `options.BearerAuth`
- **Signature**: `DeploymentServiceGetDeployment(DeploymentServiceGetDeploymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `EndpointId`, `Id`
- **Returns**: `DeDeployment`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeploymentServiceGetDeploymentRequest` | `Requests/DeploymentService/DeploymentServiceGetDeploymentRequest.cs` |
| `DeDeployment` | `Models/DeDeployment.cs` |

### DeploymentServiceListAdapters

- **Auth**: `options.BearerAuth`
- **Signature**: `DeploymentServiceListAdapters(DeploymentServiceListAdaptersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `EndpointId`, `DeploymentId`
- **Query params (wire ← C#)**: `limit` ← `Limit`, `after` ← `After`
- **Returns**: `DeListAdaptersResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeploymentServiceListAdaptersRequest` | `Requests/DeploymentService/DeploymentServiceListAdaptersRequest.cs` |
| `DeListAdaptersResponse` | `Models/DeListAdaptersResponse.cs` |

### DeploymentServiceListDeployments

- **Auth**: `options.BearerAuth`
- **Signature**: `DeploymentServiceListDeployments(DeploymentServiceListDeploymentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `EndpointId`
- **Query params (wire ← C#)**: `limit` ← `Limit`, `after` ← `After`, `orderBy` ← `OrderBy`, `filter` ← `Filter`
- **Returns**: `DeListDeploymentsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeploymentServiceListDeploymentsRequest` | `Requests/DeploymentService/DeploymentServiceListDeploymentsRequest.cs` |
| `DeListDeploymentsResponse` | `Models/DeListDeploymentsResponse.cs` |

### DeploymentServiceRemoveAdapter

- **Auth**: `options.BearerAuth`
- **Signature**: `DeploymentServiceRemoveAdapter(DeploymentServiceRemoveAdapterRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `EndpointId`, `DeploymentId`, `Id`, `Etag`
- **Query params (wire ← C#)**: `etag` ← `Etag`
- **Returns**: `object`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeploymentServiceRemoveAdapterRequest` | `Requests/DeploymentService/DeploymentServiceRemoveAdapterRequest.cs` |

### DeploymentServiceUpdateAdapter

- **Auth**: `options.BearerAuth`
- **Signature**: `DeploymentServiceUpdateAdapter(DeploymentServiceUpdateAdapterRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `EndpointId`, `DeploymentId`, `Id`, `Body`
- **Returns**: `DeAdapterEntry`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeploymentServiceUpdateAdapterRequest` | `Requests/DeploymentService/DeploymentServiceUpdateAdapterRequest.cs` |
| `DeUpdateAdapterRequest` | `Models/DeUpdateAdapterRequest.cs` |
| `DeAdapterEntry` | `Models/DeAdapterEntry.cs` |

### DeploymentServiceUpdateDeployment

- **Auth**: `options.BearerAuth`
- **Signature**: `DeploymentServiceUpdateDeployment(DeploymentServiceUpdateDeploymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `EndpointId`, `Id`, `Body`
- **Query params (wire ← C#)**: `updateMask` ← `UpdateMask`
- **Returns**: `DeDeployment`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeploymentServiceUpdateDeploymentRequest` | `Requests/DeploymentService/DeploymentServiceUpdateDeploymentRequest.cs` |
| `DeUpdateDeploymentRequest` | `Models/DeUpdateDeploymentRequest.cs` |
| `DeDeployment` | `Models/DeDeployment.cs` |

