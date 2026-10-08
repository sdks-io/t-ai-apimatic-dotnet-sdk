<!-- Generated file — do not edit; regenerated with the SDK. -->

# Account — operations

Accessor: `client.Account` · Source: `Api/Account.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Whoami

- **Auth**: `options.BearerAuth`
- **Signature**: `Whoami(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `WhoamiResponse`
- **Error**: `ApiException<WhoamiError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorData(out ErrorData)` [401, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `WhoamiResponse` | `Models/WhoamiResponse.cs` |
| `WhoamiError` | `Errors/WhoamiError.cs` |
| `ErrorData` | `Models/ErrorData.cs` |

