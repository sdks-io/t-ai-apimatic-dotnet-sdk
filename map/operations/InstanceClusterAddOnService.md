<!-- Generated file — do not edit; regenerated with the SDK. -->

# InstanceClusterAddOnService — operations

Accessor: `client.InstanceClusterAddOnService` · Source: `Api/InstanceClusterAddOnService.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### InstanceClusterAddOnServiceCreate

- **Auth**: `options.BearerAuth`
- **Signature**: `InstanceClusterAddOnServiceCreate(InstanceClusterAddOnServiceCreateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ClusterId`, `Body`
- **Returns**: `AddOnInfo`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `InstanceClusterAddOnServiceCreateRequest` | `Requests/InstanceClusterAddOnService/InstanceClusterAddOnServiceCreateRequest.cs` |
| `ClusterAddOnCreateRequest` | `Models/ClusterAddOnCreateRequest.cs` |
| `AddOnInfo` | `Models/AddOnInfo.cs` |

### InstanceClusterAddOnServiceDelete

- **Auth**: `options.BearerAuth`
- **Signature**: `InstanceClusterAddOnServiceDelete(InstanceClusterAddOnServiceDeleteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ClusterId`, `AddonId`
- **Returns**: `object`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `InstanceClusterAddOnServiceDeleteRequest` | `Requests/InstanceClusterAddOnService/InstanceClusterAddOnServiceDeleteRequest.cs` |

### InstanceClusterAddOnServiceGet

- **Auth**: `options.BearerAuth`
- **Signature**: `InstanceClusterAddOnServiceGet(InstanceClusterAddOnServiceGetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ClusterId`, `AddonId`
- **Returns**: `AddOnInfo`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `InstanceClusterAddOnServiceGetRequest` | `Requests/InstanceClusterAddOnService/InstanceClusterAddOnServiceGetRequest.cs` |
| `AddOnInfo` | `Models/AddOnInfo.cs` |

### InstanceClusterAddOnServiceList

- **Auth**: `options.BearerAuth`
- **Signature**: `InstanceClusterAddOnServiceList(InstanceClusterAddOnServiceListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ClusterId`
- **Returns**: `ClusterAddOnsListResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `InstanceClusterAddOnServiceListRequest` | `Requests/InstanceClusterAddOnService/InstanceClusterAddOnServiceListRequest.cs` |
| `ClusterAddOnsListResponse` | `Models/ClusterAddOnsListResponse.cs` |

### InstanceClusterAddOnServiceUpdate

- **Auth**: `options.BearerAuth`
- **Signature**: `InstanceClusterAddOnServiceUpdate(InstanceClusterAddOnServiceUpdateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ClusterId`, `AddonId`, `Body`
- **Returns**: `AddOnInfo`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `InstanceClusterAddOnServiceUpdateRequest` | `Requests/InstanceClusterAddOnService/InstanceClusterAddOnServiceUpdateRequest.cs` |
| `ClusterAddOnUpdateRequest` | `Models/ClusterAddOnUpdateRequest.cs` |
| `AddOnInfo` | `Models/AddOnInfo.cs` |

