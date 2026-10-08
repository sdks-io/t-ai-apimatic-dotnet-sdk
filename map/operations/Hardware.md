<!-- Generated file — do not edit; regenerated with the SDK. -->

# Hardware — operations

Accessor: `client.Hardware` · Source: `Api/Hardware.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ListHardware

- **Auth**: `options.BearerAuth`
- **Signature**: `ListHardware(ListHardwareRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `model` ← `Model`
- **Returns**: `HardwareResponse`
- **Error**: `ApiException<ListHardwareError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorData(out ErrorData)` [403, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListHardwareRequest` | `Requests/Hardware/ListHardwareRequest.cs` |
| `HardwareResponse` | `Models/HardwareResponse.cs` |
| `ListHardwareError` | `Errors/ListHardwareError.cs` |
| `ErrorData` | `Models/ErrorData.cs` |

