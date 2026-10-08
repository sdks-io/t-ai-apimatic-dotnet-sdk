<!-- Generated file — do not edit; regenerated with the SDK. -->

# Images — operations

Accessor: `client.Images` · Source: `Api/Images.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateImage

- **Auth**: `options.BearerAuth`
- **Signature**: `CreateImage(CreateImageRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ImageResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateImageRequest` | `Requests/Images/CreateImageRequest.cs` |
| `ImagesGenerationsRequest` | `Models/ImagesGenerationsRequest.cs` |
| `ImageResponse` | `Models/ImageResponse.cs` |

