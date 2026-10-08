<!-- Generated file — do not edit; regenerated with the SDK. -->

# ConfigService — operations

Accessor: `client.ConfigService` · Source: `Api/ConfigService.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ConfigServiceGetProjectConfig

- **Auth**: `options.BearerAuth`
- **Signature**: `ConfigServiceGetProjectConfig(ConfigServiceGetProjectConfigRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `Id`
- **Returns**: `DeModelConfig`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ConfigServiceGetProjectConfigRequest` | `Requests/ConfigService/ConfigServiceGetProjectConfigRequest.cs` |
| `DeModelConfig` | `Models/DeModelConfig.cs` |

### ConfigServiceListProjectConfigs

- **Auth**: `options.BearerAuth`
- **Signature**: `ConfigServiceListProjectConfigs(ConfigServiceListProjectConfigsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`
- **Query params (wire ← C#)**: `referenceModelId` ← `ReferenceModelId`, `referenceModel` ← `ReferenceModel`, `limit` ← `Limit`, `after` ← `After`
- **Returns**: `DeListProjectConfigsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ConfigServiceListProjectConfigsRequest` | `Requests/ConfigService/ConfigServiceListProjectConfigsRequest.cs` |
| `DeListProjectConfigsResponse` | `Models/DeListProjectConfigsResponse.cs` |

