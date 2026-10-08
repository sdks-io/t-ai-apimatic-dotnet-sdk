<!-- Generated file — do not edit; regenerated with the SDK. -->

# SDK map — Together APIs (.NET)

> A generated table of contents for this SDK. Consult this map and its sub-pages to learn signatures, error types, and server/auth wiring **by lookup**. Model shapes and enum values are *not* duplicated here — the map names the file declaring each type; read the shape there. The compiler is the backstop: a wrong name fails to build.

|  |  |
| --- | --- |
| SDK display name | Together APIs |
| Root namespace | `TogetherApIs` |
| Target framework | `netstandard2.0` (C# `LangVersion 14`, `Nullable enable`) |
| API spec version | `2.0.0` |
| Generator | APIMatic |

Staleness check: the API spec version above changes when the SDK is regenerated from a new spec. If a lookup here fails to compile, trust the compiler and re-read the source file named in the row.

All `Source` paths on this map and its sub-pages are relative to the **SDK root** — the directory holding this file and `TogetherApIs.csproj` — never to the page that carries them. Open them as-is from the SDK root, from any page; if the SDK sits under a subdirectory of a larger repo, prefix that subdirectory.

---

## Getting a client

```csharp
var httpClient = new HttpClient();
// TODO: configure more client options here
var options = new TogetherApIsClientOptions
{
    BearerAuth = "YOUR_BEARER_TOKEN",
    Environment = ServerEnvironment.Production,
};
var client = new TogetherApIsClient(httpClient, options);
```

DI alternative (`services.AddTogetherApIsClient`):

```csharp
services.AddTogetherApIsClient(options =>
{
    options.BearerAuth = "YOUR_BEARER_TOKEN";
    options.Environment = ServerEnvironment.Production;
    // TODO: configure more client options here
});
```

Every API group is a property on the client (e.g. `client.AbExperimentService`). Source: `TogetherApIsClient.cs`. The only constructor is `TogetherApIsClient(HttpClient httpClient, TogetherApIsClientOptions options)`.

All `TogetherApIsClientOptions` properties (source: `TogetherApIsClientOptions.cs`):

| Property | Type |
| --- | --- |
| `Environment` | `ServerEnvironment` |
| `Retry` | `RetryOptions` |
| `Logging` | `LoggingOptions` |
| `TimeProvider` | `TimeProvider` |
| `Server` | `ServerOptions` |
| `StreamReadTimeout` | `TimeSpan?` |
| `Hooks` | `IReadOnlyList<SdkHook>` |
| `BearerAuth` | `string?` |

`ServerEnvironment` (source: `Servers/ServerEnvironment.cs`, namespace `TogetherApIs.Servers`)

`RetryOptions` members (namespace `TogetherApIs.Core.Configuration` — add `using TogetherApIs.Core.Configuration;`; source: `Core/Configuration/RetryOptions.cs`; all members are `required`, so build a full instance or start from `RetryOptions.Default()`):

| Member | Type |
| --- | --- |
| `StatusCodesToRetry` | `IReadOnlyList<HttpStatusCode>` |
| `HttpMethodsToRetry` | `IReadOnlyList<HttpMethod>` |
| `MaxRetries` | `int` |
| `Delay` | `TimeSpan` |
| `Timeout` | `TimeSpan?` |
| `BackOffFactor` | `int` |
| `UseExponentialBackoff` | `bool` |
| `MaxJitter` | `TimeSpan` |
| `OnRetry` | `Action<RetryAttempt>?` |

---

## Error-handling model (read once — applies to every operation)

Operations are **throw-based**. On an error status the SDK throws `ApiException<TError>` (`Core/Exceptions/ApiException.cs`, namespace `TogetherApIs.Core.Exceptions`) exposing `.Error` of type `TError` beside the `StatusCode`, `Headers` and `ContentType` of the response. There are two cases:

- **Case A — typed error.** `TError` is a generated `…Error : ApiError` class (namespace `TogetherApIs.Errors`) with status-specific `TryGet…(out …)` accessors (each returns `true` when that shape is present) plus the inherited `TryGetRawError(out RawError)` fallback. The operation blocks name the exact `TryGet…` methods and the HTTP status each maps to.
- **Case B — raw error.** `TError` is `RawError` (`Core/ErrorResponse/RawError.cs`, namespace `TogetherApIs.Core.ErrorResponse`): `StatusCode: HttpStatusCode` · `ReadAsBytes(): ReadOnlyMemory<byte>` · `ReadAsString(): string` · `ReadAsJson<T>(): T?`.

⚠ Each of the three lives in its own namespace. `Core/` holds several namespaces, so a catch block naming `ApiException<T>`, a typed `{Operation}Error` and `RawError` together needs a `using` for each.

`ApiException<TError>` is one leaf of the `SdkException` family (`Core/Exceptions/SdkException.cs`): a request that produced no usable response surfaces as `SdkConnectionException` or `SdkTimeoutException`, a body that does not match its declared type as `ResponseDeserializationException`, and a credential that could not be applied as `AuthSchemeException`. Every one of them names the failed call. The full table is in [README → Error Handling](README.md#error-handling).

Core error types (`Core/ErrorResponse/`) — public members with their **declared types**, verbatim from source:

| Type | Public members | Source |
| --- | --- | --- |
| `ApiError` — abstract base of the 77 typed error classes in `Errors/` | `TryGetRawError(out RawError error): bool` | `Core/ErrorResponse/ApiError.cs` |
| `RawError` | `StatusCode: HttpStatusCode` · `ReadAsBytes(): ReadOnlyMemory<byte>` · `ReadAsString(): string` · `ReadAsJson<T>(): T?` | `Core/ErrorResponse/RawError.cs` |

Typed-error payload shapes (the `out` types in each operation page's error-accessor cells) are ordinary records/unions — no special handling. The operation's **Type sources** table gives the file that declares each one; read field names, declared types, and JSON wire names there, as for any other model.

```csharp
try
{
    var response = await client.Account.Whoami();
}
catch (ApiException<WhoamiError> ex)
{
    // Case A — typed error
    if (ex.Error.TryGetErrorData(out var error))
    {
        // Handle 401, 500
    }
    else if (ex.Error.TryGetRawError(out var raw))
    {
        // Any other error status
    }
}
catch (ApiException<RawError> ex)
{
    // Case B — raw error
    // ex.Error.StatusCode, ex.Error.ReadAsString(), ex.Error.ReadAsJson<T>()
}
```

**No-throw (`…Result`) variants: absent across this SDK** — every operation is throw-only. Of **201 operations**, **77 are Case A (typed)** and **124 are Case B (raw)**.

---

## Operations — by controller (42 groups, 201 operations)

Each links to a sub-page with one row per operation: signature, the request record's required members, query-param wire names, return type, error Case A/B, and Case A's typed accessors with their statuses. Each operation also carries a **Type sources** table — every type it names, with the file that declares it — so resolving a body, return, or error payload to its source is a lookup, never a search. `RawError` is excluded there (its members and path are above); an operation with no table names nothing but primitives and `RawError`.

**Each row states what is specific to its operation. Everything below holds for EVERY operation unless that operation's row says otherwise, so a row silent on one of these points is telling you the default here applies — take it and move on rather than opening the source to confirm it.**

| Applies to every operation | Stated where | A row appears only when |
| --- | --- | --- |
| **Throw-only** — no `…Result`/no-throw variant exists anywhere in this SDK | this page, Error-handling model | a no-throw sibling exists (none do at this SDK version) |
| **No pagination** — the operation returns a single response, not a `Pageable` | here | pagination is offered — the block carries a **Pagination** bullet naming the posture (page-, offset-, cursor- or link-based, or the `page`-without-page-size case) |
| **Case B error accessors are always these four** — `StatusCode: HttpStatusCode` · `ReadAsBytes(): ReadOnlyMemory<byte>` · `ReadAsString(): string` · `ReadAsJson<T>(): T?` | the `RawError` row above | never — a `Case B` label always implies exactly these four; Case A rows list their own typed accessors |
| **Server group `Default`** — base URL per Servers & auth below | here | the operation is on another group — its block carries a **Server group** bullet |
| **Inputs are one request record** — an operation that takes input takes a single request record as its first parameter; build it with an object initializer, using the property names in the record's source (its file is in the operation's **Type sources**). A member the row does not list as required is optional or already carries the spec's default | here | never — it always holds |

**The HTTP verb and route live on the operation itself**, in the source file named at the top of its operations page. This map is method-first: the C# method is the interface you call. When something wire-level needs the route — reproducing a raw request, pointing the client at a mock, reading a provider-side log — read it from that file; do not reconstruct it from memory or infer it from the method name.

**The endpoint's behavioural prose lives there too**, as the XML `<remarks>` on the method. Rows here give you the contract — names, types, shapes, errors. Where an operation's *semantics* decide what you must pass — a parameter whose value changes server-side behaviour, an ordering or exclusivity rule between fields — that is what `<remarks>` settles; read it there rather than filling it in from memory.

| Controller (`client.X`) | Ops | Page |
| --- | --- | --- |
| `AbExperimentService` | 5 | [map/operations/AbExperimentService.md](map/operations/AbExperimentService.md) |
| `Account` | 1 | [map/operations/Account.md](map/operations/Account.md) |
| `AudioApi` | 5 | [map/operations/AudioApi.md](map/operations/AudioApi.md) |
| `Batches` | 4 | [map/operations/Batches.md](map/operations/Batches.md) |
| `Billing` | 1 | [map/operations/Billing.md](map/operations/Billing.md) |
| `Chat` | 1 | [map/operations/Chat.md](map/operations/Chat.md) |
| `CodeInterpreter` | 2 | [map/operations/CodeInterpreter.md](map/operations/CodeInterpreter.md) |
| `Completion` | 1 | [map/operations/Completion.md](map/operations/Completion.md) |
| `ConfigService` | 2 | [map/operations/ConfigService.md](map/operations/ConfigService.md) |
| `DeploymentService` | 10 | [map/operations/DeploymentService.md](map/operations/DeploymentService.md) |
| `Deployments` | 9 | [map/operations/Deployments.md](map/operations/Deployments.md) |
| `DeploymentsStorage` | 2 | [map/operations/DeploymentsStorage.md](map/operations/DeploymentsStorage.md) |
| `DeploymentsVolumes` | 2 | [map/operations/DeploymentsVolumes.md](map/operations/DeploymentsVolumes.md) |
| `Embeddings` | 1 | [map/operations/Embeddings.md](map/operations/Embeddings.md) |
| `EndpointService` | 9 | [map/operations/EndpointService.md](map/operations/EndpointService.md) |
| `Endpoints` | 9 | [map/operations/Endpoints.md](map/operations/Endpoints.md) |
| `Files` | 5 | [map/operations/Files.md](map/operations/Files.md) |
| `FineTuning` | 14 | [map/operations/FineTuning.md](map/operations/FineTuning.md) |
| `GpuClusterService` | 5 | [map/operations/GpuClusterService.md](map/operations/GpuClusterService.md) |
| `Hardware` | 1 | [map/operations/Hardware.md](map/operations/Hardware.md) |
| `HealthCheckService` | 1 | [map/operations/HealthCheckService.md](map/operations/HealthCheckService.md) |
| `Images` | 1 | [map/operations/Images.md](map/operations/Images.md) |
| `InstanceClusterAddOnService` | 5 | [map/operations/InstanceClusterAddOnService.md](map/operations/InstanceClusterAddOnService.md) |
| `InstanceTypeService` | 2 | [map/operations/InstanceTypeService.md](map/operations/InstanceTypeService.md) |
| `Jobs` | 2 | [map/operations/Jobs.md](map/operations/Jobs.md) |
| `ModelsApi` | 2 | [map/operations/ModelsApi.md](map/operations/ModelsApi.md) |
| `PlacementProfileService` | 2 | [map/operations/PlacementProfileService.md](map/operations/PlacementProfileService.md) |
| `QueueApi` | 5 | [map/operations/QueueApi.md](map/operations/QueueApi.md) |
| `Rl` | 28 | [map/operations/Rl.md](map/operations/Rl.md) |
| `RegionService` | 1 | [map/operations/RegionService.md](map/operations/RegionService.md) |
| `RemediationService` | 6 | [map/operations/RemediationService.md](map/operations/RemediationService.md) |
| `Rerank` | 1 | [map/operations/Rerank.md](map/operations/Rerank.md) |
| `RolloutService` | 10 | [map/operations/RolloutService.md](map/operations/RolloutService.md) |
| `Secrets` | 5 | [map/operations/Secrets.md](map/operations/Secrets.md) |
| `ShadowExperimentService` | 10 | [map/operations/ShadowExperimentService.md](map/operations/ShadowExperimentService.md) |
| `SharedVolumeService` | 5 | [map/operations/SharedVolumeService.md](map/operations/SharedVolumeService.md) |
| `SupportedModelsService` | 2 | [map/operations/SupportedModelsService.md](map/operations/SupportedModelsService.md) |
| `VideoApi` | 2 | [map/operations/VideoApi.md](map/operations/VideoApi.md) |
| `Voices` | 1 | [map/operations/Voices.md](map/operations/Voices.md) |
| `VolumeService` | 13 | [map/operations/VolumeService.md](map/operations/VolumeService.md) |
| `Volumes` | 3 | [map/operations/Volumes.md](map/operations/Volumes.md) |
| `Evaluation` | 5 | [map/operations/Evaluation.md](map/operations/Evaluation.md) |

---

## Models — where they live, how to build them

**Shapes live only in the source.** Every file under `Models/`, `Errors/` and `Requests/` declares exactly one public type, named after the file, and no two share a name — so a type name *is* its path. Take it from the operation's **Type sources** table, or build it from the kind's directory below. Never grep for a type.

| Group | Count | Directory (file = `<TypeName>.cs`) |
| --- | --- | --- |
| Records (plain `record` data models) | 567 | `Models/` |
| Unions (`OneOf`) — variant factories + `TryGet…` | 3 | `Models/OneOf/` |
| Unions (`AnyOf`) — variant factories + `TryGet…` | 68 | `Models/AnyOf/` |
| Enums (`OpenStringEnum<T>` / `OpenIntEnum<T>`) — C# member names + wire values | 207 | `Models/Enums/` |
| Typed error classes (`: ApiError`, one per Case A operation) | 77 | `Errors/` |
| Request records (one per operation that takes input; never serialized) | 186 | `Requests/` — a controller's records sit in a folder named after it (an operation with several tags is filed under the first tag it declares) |

Conventions: records are immutable, `init`-only; `required` properties must be set in the object initializer; `T?` is optional. A field's wire name is its `[JsonPropertyName]` and often differs from the C# name (`AmountInCents` ↔ `amount_in_cents`) — read it off the property, don't derive it. `OneOf`/`AnyOf` unions wrap `Optional<T>` variants — build via static factory or implicit conversion, read via `TryGet…(out …)`; `AllOf` compositions are not unions — every constituent is a `required` property, so set them all, and those constituent properties carry no `[JsonPropertyName]` and have no wire name of their own, because the generated converter flattens each constituent's own fields directly into the one parent JSON object. Enums are **not** C# enums — use the static members, whose names are PascalCase even when the wire value isn't (`CollectionMethod.Invoice`, not `.invoice`); there is no public factory, so resolve a raw value with `TryGetKnownValue` and branch with the generated `Match`, whose `otherwise` arm receives any value the SDK does not declare.

Namespaces by content type (add `using` accordingly):

| Contents | Namespace |
| --- | --- |
| Client & options (root) | `TogetherApIs` |
| Operation controllers (`Api/`) | `TogetherApIs.Api` |
| Records (`Models/`) | `TogetherApIs.Models` |
| Enums (`Models/Enums/`) | `TogetherApIs.Models.Enums` |
| OneOf unions (`Models/OneOf/`) | `TogetherApIs.Models.OneOf` |
| AnyOf unions (`Models/AnyOf/`) | `TogetherApIs.Models.AnyOf` |
| Error classes (`Errors/`) | `TogetherApIs.Errors` |
| Request records (`Requests/`) | `TogetherApIs.Requests` — plus `.<Controller>` for a controller's records (an operation with several tags is filed under the first tag it declares) |

---

## Servers & auth

**Bearer token.** Set `options.BearerAuth = "<token>"`.

Operation blocks name their credential in an **Auth** bullet; an operation whose spec declares no scheme carries no such bullet.

- `AND` — every credential listed must be set for the call to be fully authenticated.
- `OR` — the first credential you set that applies successfully is the one sent, in the order listed.

A credential you never set is skipped rather than throwing, and the request is sent anyway — so an authentication failure can mean no credential was sent rather than a bad one. Under `OR`, if every credential you did set fails to apply, `AuthSchemeException` is thrown.

**Environments.** `options.Environment` selects the target environment (`Servers/ServerEnvironment.cs`):

| Environment | Value | Hosting |
| --- | --- | --- |
| `ServerEnvironment.Production` *(default)* | `production` | Default environment for APIs |
| `ServerEnvironment.Environment2` | `environment2` | Optimized environment for inference |
| `ServerEnvironment.Environment3` | `environment3` | — |

**1 server group.** Base-URL templates and override points (`options.Server.…`):

| Group | `Production` base URL | `Environment2` base URL | `Environment3` base URL | Override point |
| --- | --- | --- | --- | --- |
| `Default` | `https://api.together.ai/v1` | `https://api-inference.together.ai/v2` | `https://api.together.ai/v2` | `options.Server.Default.Production.BaseUrl` (and the other environments) |

Retry/resilience is configurable via `options.Retry` (`RetryOptions`, backed by Polly).

