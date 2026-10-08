using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using TogetherApIs.Core.Hooks;

namespace TogetherApIs.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }

    public IReadOnlyList<SdkHook>? Hooks { get; init; }
}
