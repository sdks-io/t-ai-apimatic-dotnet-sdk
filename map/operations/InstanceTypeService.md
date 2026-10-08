<!-- Generated file — do not edit; regenerated with the SDK. -->

# InstanceTypeService — operations

Accessor: `client.InstanceTypeService` · Source: `Api/InstanceTypeService.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### InstanceTypeServiceGetInferenceInstanceType

- **Auth**: `options.BearerAuth`
- **Signature**: `InstanceTypeServiceGetInferenceInstanceType(InstanceTypeServiceGetInferenceInstanceTypeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `DeInferenceInstanceType`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `InstanceTypeServiceGetInferenceInstanceTypeRequest` | `Requests/InstanceTypeService/InstanceTypeServiceGetInferenceInstanceTypeRequest.cs` |
| `DeInferenceInstanceType` | `Models/DeInferenceInstanceType.cs` |

### InstanceTypeServiceListInferenceInstanceTypes

- **Auth**: `options.BearerAuth`
- **Signature**: `InstanceTypeServiceListInferenceInstanceTypes(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `DeListInferenceInstanceTypesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeListInferenceInstanceTypesResponse` | `Models/DeListInferenceInstanceTypesResponse.cs` |

