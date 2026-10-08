using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// One NVIDIA Xid code observed during the alert window.
/// </summary>
public record XidEvent
{
    /// <summary>
    /// NVIDIA Xid code, such as <c>79</c>.
    /// </summary>
    [JsonPropertyName("xid_code")]
    public required string XidCode { get; init; }

    /// <summary>
    /// Driver mnemonic for the Xid code when metadata is available.
    /// </summary>
    [JsonPropertyName("mnemonic")]
    public required string Mnemonic { get; init; }

    /// <summary>
    /// Number of times this Xid code appeared in the alert window.
    /// </summary>
    [JsonPropertyName("count")]
    public required int Count { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
