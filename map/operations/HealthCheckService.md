<!-- Generated file — do not edit; regenerated with the SDK. -->

# HealthCheckService — operations

Accessor: `client.HealthCheckService` · Source: `Api/HealthCheckService.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### HealthCheckServiceListPassiveHealthCheckAlerts

- **Auth**: `options.BearerAuth`
- **Signature**: `HealthCheckServiceListPassiveHealthCheckAlerts(HealthCheckServiceListPassiveHealthCheckAlertsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `intent_id` ← `IntentId`, `instance_id` ← `InstanceId`, `cluster_id` ← `ClusterId`, `page_size` ← `PageSize`, `page_token` ← `PageToken`, `status` ← `Status`, `severity_filter` ← `SeverityFilter`, `order_by` ← `OrderBy`
- **Returns**: `ListPassiveHealthCheckAlertsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `HealthCheckServiceListPassiveHealthCheckAlertsRequest` | `Requests/HealthCheckService/HealthCheckServiceListPassiveHealthCheckAlertsRequest.cs` |
| `Status14` | `Models/Enums/Status14.cs` |
| `SeverityFilter` | `Models/Enums/SeverityFilter.cs` |
| `OrderBy` | `Models/Enums/OrderBy.cs` |
| `ListPassiveHealthCheckAlertsResponse` | `Models/ListPassiveHealthCheckAlertsResponse.cs` |

