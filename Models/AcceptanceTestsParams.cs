using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// AcceptanceTestsParams groups all GPU acceptance test options when enabled is true.
/// </summary>
public record AcceptanceTestsParams
{
    /// <summary>
    /// Whether to run GPU acceptance tests during cluster bring-up.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; init; }

    /// <summary>
    /// DCGM diagnostic depth. SHORT = readiness; MEDIUM = default; LONG = system validation; EXTENDED = memtest. An omitted value selects MEDIUM when enabled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dcgm_diag_level")]
    public DcgmDiagLevel? DcgmDiagLevel { get; init; }

    /// <summary>
    /// GPU burn duration in seconds; 0 means use the default when enabled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gpu_burn_duration")]
    public int? GpuBurnDuration { get; init; }

    /// <summary>
    /// Skip NCCL single-node acceptance test.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nccl_single_node_skipped")]
    public bool? NcclSingleNodeSkipped { get; init; }

    /// <summary>
    /// Skip GPU burn acceptance test.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gpu_burn_skipped")]
    public bool? GpuBurnSkipped { get; init; }

    /// <summary>
    /// Skip DCGM diagnostics acceptance test.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dcgm_diag_skipped")]
    public bool? DcgmDiagSkipped { get; init; }

    /// <summary>
    /// Skip NCCL multi-node acceptance test.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nccl_multi_node_skipped")]
    public bool? NcclMultiNodeSkipped { get; init; }

    /// <summary>
    /// Skip storage-performance acceptance test.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("storage_skipped")]
    public bool? StorageSkipped { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
