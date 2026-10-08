<!-- Generated file — do not edit; regenerated with the SDK. -->

# RemediationService — operations

Accessor: `client.RemediationService` · Source: `Api/RemediationService.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### RemediationServiceApproveRemediation

- **Auth**: `options.BearerAuth`
- **Signature**: `RemediationServiceApproveRemediation(RemediationServiceApproveRemediationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ClusterId`, `InstanceId`, `RemediationId`, `Body`
- **Returns**: `Remediation`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RemediationServiceApproveRemediationRequest` | `Requests/RemediationService/RemediationServiceApproveRemediationRequest.cs` |
| `ApproveRemediationRequest` | `Models/ApproveRemediationRequest.cs` |
| `Remediation` | `Models/Remediation.cs` |

### RemediationServiceCancelRemediation

- **Auth**: `options.BearerAuth`
- **Signature**: `RemediationServiceCancelRemediation(RemediationServiceCancelRemediationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ClusterId`, `InstanceId`, `RemediationId`
- **Returns**: `Remediation`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RemediationServiceCancelRemediationRequest` | `Requests/RemediationService/RemediationServiceCancelRemediationRequest.cs` |
| `Remediation` | `Models/Remediation.cs` |

### RemediationServiceCreateRemediation

- **Auth**: `options.BearerAuth`
- **Signature**: `RemediationServiceCreateRemediation(RemediationServiceCreateRemediationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ClusterId`, `InstanceId`, `Body`
- **Query params (wire ← C#)**: `remediation_id` ← `RemediationId`
- **Returns**: `Remediation`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RemediationServiceCreateRemediationRequest` | `Requests/RemediationService/RemediationServiceCreateRemediationRequest.cs` |
| `Remediation` | `Models/Remediation.cs` |

### RemediationServiceGetRemediation

- **Auth**: `options.BearerAuth`
- **Signature**: `RemediationServiceGetRemediation(RemediationServiceGetRemediationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ClusterId`, `InstanceId`, `RemediationId`
- **Returns**: `Remediation`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RemediationServiceGetRemediationRequest` | `Requests/RemediationService/RemediationServiceGetRemediationRequest.cs` |
| `Remediation` | `Models/Remediation.cs` |

### RemediationServiceListRemediations

- **Auth**: `options.BearerAuth`
- **Signature**: `RemediationServiceListRemediations(RemediationServiceListRemediationsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ClusterId`, `InstanceId`
- **Query params (wire ← C#)**: `page_size` ← `PageSize`, `page_token` ← `PageToken`, `state` ← `State`, `order_by` ← `OrderBy`, `trigger` ← `Trigger`, `mode` ← `Mode`
- **Returns**: `ListRemediationsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RemediationServiceListRemediationsRequest` | `Requests/RemediationService/RemediationServiceListRemediationsRequest.cs` |
| `State11` | `Models/Enums/State11.cs` |
| `Trigger1` | `Models/Enums/Trigger1.cs` |
| `Mode2` | `Models/Enums/Mode2.cs` |
| `ListRemediationsResponse` | `Models/ListRemediationsResponse.cs` |

### RemediationServiceRejectRemediation

- **Auth**: `options.BearerAuth`
- **Signature**: `RemediationServiceRejectRemediation(RemediationServiceRejectRemediationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ClusterId`, `InstanceId`, `RemediationId`, `Body`
- **Returns**: `Remediation`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RemediationServiceRejectRemediationRequest` | `Requests/RemediationService/RemediationServiceRejectRemediationRequest.cs` |
| `CommentBody` | `Models/CommentBody.cs` |
| `Remediation` | `Models/Remediation.cs` |

