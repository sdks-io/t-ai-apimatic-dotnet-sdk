<!-- Generated file — do not edit; regenerated with the SDK. -->

# SupportedModelsService — operations

Accessor: `client.SupportedModelsService` · Source: `Api/SupportedModelsService.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### SupportedModelsServiceGetSupportedModel

- **Auth**: `options.BearerAuth`
- **Signature**: `SupportedModelsServiceGetSupportedModel(SupportedModelsServiceGetSupportedModelRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `DeSupportedModel`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SupportedModelsServiceGetSupportedModelRequest` | `Requests/SupportedModelsService/SupportedModelsServiceGetSupportedModelRequest.cs` |
| `DeSupportedModel` | `Models/DeSupportedModel.cs` |

### SupportedModelsServiceListSupportedModels

- **Auth**: `options.BearerAuth`
- **Signature**: `SupportedModelsServiceListSupportedModels(SupportedModelsServiceListSupportedModelsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `modality` ← `Modality`, `product` ← `Product`, `search` ← `Search`, `limit` ← `Limit`, `after` ← `After`
- **Returns**: `DeListSupportedModelsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SupportedModelsServiceListSupportedModelsRequest` | `Requests/SupportedModelsService/SupportedModelsServiceListSupportedModelsRequest.cs` |
| `Modality` | `Models/Enums/Modality.cs` |
| `Product1` | `Models/Enums/Product1.cs` |
| `DeListSupportedModelsResponse` | `Models/DeListSupportedModelsResponse.cs` |

