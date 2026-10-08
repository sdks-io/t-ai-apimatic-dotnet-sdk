<!-- Generated file — do not edit; regenerated with the SDK. -->

# Billing — operations

Accessor: `client.Billing` · Source: `Api/Billing.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetBillingUsage

- **Auth**: `options.BearerAuth`
- **Signature**: `GetBillingUsage(GetBillingUsageRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `month` ← `Month`, `organization_id` ← `OrganizationId`, `granularity` ← `Granularity`, `limit` ← `Limit`, `after` ← `After`
- **Returns**: `BillingUsageReport`
- **Error**: `ApiException<GetBillingUsageError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorData(out ErrorData)` [400, 401, 403, 404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetBillingUsageRequest` | `Requests/Billing/GetBillingUsageRequest.cs` |
| `Granularity` | `Models/Enums/Granularity.cs` |
| `BillingUsageReport` | `Models/BillingUsageReport.cs` |
| `GetBillingUsageError` | `Errors/GetBillingUsageError.cs` |
| `ErrorData` | `Models/ErrorData.cs` |

