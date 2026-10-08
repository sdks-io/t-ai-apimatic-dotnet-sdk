<!-- Generated file — do not edit; regenerated with the SDK. -->

# Secrets — operations

Accessor: `client.Secrets` · Source: `Api/Secrets.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateANewSecret

- **Auth**: `options.BearerAuth`
- **Signature**: `CreateANewSecret(CreateANewSecretRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SecretResponseItem`
- **Error**: `ApiException<CreateANewSecretError>` — **Case A (typed)**
- **Error accessors**: `TryGetAnonymousObject(out object)` [400, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateANewSecretRequest` | `Requests/Secrets/CreateANewSecretRequest.cs` |
| `CreateSecretRequest` | `Models/CreateSecretRequest.cs` |
| `SecretResponseItem` | `Models/SecretResponseItem.cs` |
| `CreateANewSecretError` | `Errors/CreateANewSecretError.cs` |

### DeleteASecret

- **Auth**: `options.BearerAuth`
- **Signature**: `DeleteASecret(DeleteASecretRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `object`
- **Error**: `ApiException<DeleteASecretError>` — **Case A (typed)**
- **Error accessors**: `TryGetAnonymousObject(out object)` [404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteASecretRequest` | `Requests/Secrets/DeleteASecretRequest.cs` |
| `DeleteASecretError` | `Errors/DeleteASecretError.cs` |

### GetASecretByIdOrName

- **Auth**: `options.BearerAuth`
- **Signature**: `GetASecretByIdOrName(GetASecretByIdOrNameRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `SecretResponseItem`
- **Error**: `ApiException<GetASecretByIdOrNameError>` — **Case A (typed)**
- **Error accessors**: `TryGetAnonymousObject(out object)` [404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetASecretByIdOrNameRequest` | `Requests/Secrets/GetASecretByIdOrNameRequest.cs` |
| `SecretResponseItem` | `Models/SecretResponseItem.cs` |
| `GetASecretByIdOrNameError` | `Errors/GetASecretByIdOrNameError.cs` |

### GetTheListOfProjectSecrets

- **Auth**: `options.BearerAuth`
- **Signature**: `GetTheListOfProjectSecrets(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `ListSecretsResponse`
- **Error**: `ApiException<GetTheListOfProjectSecretsError>` — **Case A (typed)**
- **Error accessors**: `TryGetAnonymousObject(out object)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListSecretsResponse` | `Models/ListSecretsResponse.cs` |
| `GetTheListOfProjectSecretsError` | `Errors/GetTheListOfProjectSecretsError.cs` |

### UpdateASecret

- **Auth**: `options.BearerAuth`
- **Signature**: `UpdateASecret(UpdateASecretRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `SecretResponseItem`
- **Error**: `ApiException<UpdateASecretError>` — **Case A (typed)**
- **Error accessors**: `TryGetAnonymousObject(out object)` [400, 404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateASecretRequest` | `Requests/Secrets/UpdateASecretRequest.cs` |
| `UpdateSecretRequest` | `Models/UpdateSecretRequest.cs` |
| `SecretResponseItem` | `Models/SecretResponseItem.cs` |
| `UpdateASecretError` | `Errors/UpdateASecretError.cs` |

