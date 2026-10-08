<!-- Generated file — do not edit; regenerated with the SDK. -->

# Endpoints — operations

Accessor: `client.Endpoints` · Source: `Api/Endpoints.cs` · 9 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AddAdapter

- **Auth**: `options.BearerAuth`
- **Signature**: `AddAdapter(AddAdapterRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `EndpointId`, `Body`
- **Returns**: `EndpointsAdaptersResponse`
- **Error**: `ApiException<AddAdapterError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorData(out ErrorData)` [400, 403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AddAdapterRequest` | `Requests/Endpoints/AddAdapterRequest.cs` |
| `EndpointsAdaptersRequest` | `Models/EndpointsAdaptersRequest.cs` |
| `EndpointsAdaptersResponse` | `Models/EndpointsAdaptersResponse.cs` |
| `AddAdapterError` | `Errors/AddAdapterError.cs` |
| `ErrorData` | `Models/ErrorData.cs` |

### AvailabilityZones

- **Auth**: `options.BearerAuth`
- **Signature**: `AvailabilityZones(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `ListAvailibilityZonesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListAvailibilityZonesResponse` | `Models/ListAvailibilityZonesResponse.cs` |

### CreateEndpoint

- **Auth**: `options.BearerAuth`
- **Signature**: `CreateEndpoint(CreateEndpointOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `DedicatedEndpoint`
- **Error**: `ApiException<CreateEndpointError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorData(out ErrorData)` [403, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateEndpointOperationRequest` | `Requests/Endpoints/CreateEndpointOperationRequest.cs` |
| `CreateEndpointRequest` | `Models/CreateEndpointRequest.cs` |
| `DedicatedEndpoint` | `Models/DedicatedEndpoint.cs` |
| `CreateEndpointError` | `Errors/CreateEndpointError.cs` |
| `ErrorData` | `Models/ErrorData.cs` |

### DeleteEndpoint

- **Auth**: `options.BearerAuth`
- **Signature**: `DeleteEndpoint(DeleteEndpointRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `EndpointId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeleteEndpointError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorData(out ErrorData)` [403, 404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteEndpointRequest` | `Requests/Endpoints/DeleteEndpointRequest.cs` |
| `DeleteEndpointError` | `Errors/DeleteEndpointError.cs` |
| `ErrorData` | `Models/ErrorData.cs` |

### GetEndpoint

- **Auth**: `options.BearerAuth`
- **Signature**: `GetEndpoint(GetEndpointRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `EndpointId`
- **Returns**: `DedicatedEndpoint`
- **Error**: `ApiException<GetEndpointError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorData(out ErrorData)` [403, 404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetEndpointRequest` | `Requests/Endpoints/GetEndpointRequest.cs` |
| `DedicatedEndpoint` | `Models/DedicatedEndpoint.cs` |
| `GetEndpointError` | `Errors/GetEndpointError.cs` |
| `ErrorData` | `Models/ErrorData.cs` |

### ListAdapters

- **Auth**: `options.BearerAuth`
- **Signature**: `ListAdapters(ListAdaptersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `EndpointId`
- **Returns**: `EndpointsAdaptersResponse1`
- **Error**: `ApiException<ListAdaptersError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorData(out ErrorData)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListAdaptersRequest` | `Requests/Endpoints/ListAdaptersRequest.cs` |
| `EndpointsAdaptersResponse1` | `Models/EndpointsAdaptersResponse1.cs` |
| `ListAdaptersError` | `Errors/ListAdaptersError.cs` |
| `ErrorData` | `Models/ErrorData.cs` |

### ListEndpoints

- **Auth**: `options.BearerAuth`
- **Signature**: `ListEndpoints(ListEndpointsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `type` ← `Type`, `usage_type` ← `UsageType`, `mine` ← `Mine`
- **Returns**: `EndpointsResponse`
- **Error**: `ApiException<ListEndpointsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorData(out ErrorData)` [403, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListEndpointsRequest` | `Requests/Endpoints/ListEndpointsRequest.cs` |
| `Type18` | `Models/Enums/Type18.cs` |
| `UsageType` | `Models/Enums/UsageType.cs` |
| `EndpointsResponse` | `Models/EndpointsResponse.cs` |
| `ListEndpointsError` | `Errors/ListEndpointsError.cs` |
| `ErrorData` | `Models/ErrorData.cs` |

### RemoveAdapter

- **Auth**: `options.BearerAuth`
- **Signature**: `RemoveAdapter(RemoveAdapterRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `EndpointId`, `Body`
- **Returns**: `EndpointsAdaptersResponse2`
- **Error**: `ApiException<RemoveAdapterError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorData(out ErrorData)` [400, 403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RemoveAdapterRequest` | `Requests/Endpoints/RemoveAdapterRequest.cs` |
| `EndpointsAdaptersRequest` | `Models/EndpointsAdaptersRequest.cs` |
| `EndpointsAdaptersResponse2` | `Models/EndpointsAdaptersResponse2.cs` |
| `RemoveAdapterError` | `Errors/RemoveAdapterError.cs` |
| `ErrorData` | `Models/ErrorData.cs` |

### UpdateEndpoint

- **Auth**: `options.BearerAuth`
- **Signature**: `UpdateEndpoint(UpdateEndpointRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `EndpointId`, `Body`
- **Returns**: `DedicatedEndpoint`
- **Error**: `ApiException<UpdateEndpointError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorData(out ErrorData)` [403, 404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateEndpointRequest` | `Requests/Endpoints/UpdateEndpointRequest.cs` |
| `EndpointsRequest` | `Models/EndpointsRequest.cs` |
| `DedicatedEndpoint` | `Models/DedicatedEndpoint.cs` |
| `UpdateEndpointError` | `Errors/UpdateEndpointError.cs` |
| `ErrorData` | `Models/ErrorData.cs` |

