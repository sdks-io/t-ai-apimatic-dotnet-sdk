<!-- Generated file — do not edit; regenerated with the SDK. -->

# PlacementProfileService — operations

Accessor: `client.PlacementProfileService` · Source: `Api/PlacementProfileService.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### PlacementProfileServiceGetPlacementProfile

- **Auth**: `options.BearerAuth`
- **Signature**: `PlacementProfileServiceGetPlacementProfile(PlacementProfileServiceGetPlacementProfileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `Id`
- **Returns**: `DePlacementProfile`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PlacementProfileServiceGetPlacementProfileRequest` | `Requests/PlacementProfileService/PlacementProfileServiceGetPlacementProfileRequest.cs` |
| `DePlacementProfile` | `Models/DePlacementProfile.cs` |

### PlacementProfileServiceListPlacementProfiles

- **Auth**: `options.BearerAuth`
- **Signature**: `PlacementProfileServiceListPlacementProfiles(PlacementProfileServiceListPlacementProfilesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`
- **Query params (wire ← C#)**: `limit` ← `Limit`, `after` ← `After`
- **Returns**: `DeListPlacementProfilesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PlacementProfileServiceListPlacementProfilesRequest` | `Requests/PlacementProfileService/PlacementProfileServiceListPlacementProfilesRequest.cs` |
| `DeListPlacementProfilesResponse` | `Models/DeListPlacementProfilesResponse.cs` |

