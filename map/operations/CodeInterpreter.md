<!-- Generated file — do not edit; regenerated with the SDK. -->

# CodeInterpreter — operations

Accessor: `client.CodeInterpreter` · Source: `Api/CodeInterpreter.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### SessionsList

- **Auth**: `options.BearerAuth`
- **Signature**: `SessionsList(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `SessionListResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SessionListResponse` | `Models/SessionListResponse.cs` |

### TciExecute

- **Auth**: `options.BearerAuth`
- **Signature**: `TciExecute(TciExecuteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `ExecuteResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TciExecuteRequest` | `Requests/CodeInterpreter/TciExecuteRequest.cs` |
| `ExecuteRequest` | `Models/ExecuteRequest.cs` |
| `ExecuteResponse` | `Models/AnyOf/ExecuteResponse.cs` |

