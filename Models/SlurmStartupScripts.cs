using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// SlurmStartupScripts carries optional Slurm lifecycle scripts (prolog/epilog, init, extra conf).
/// </summary>
public record SlurmStartupScripts
{
    /// <summary>
    /// Slurm worker node prolog script.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("worker_prolog")]
    public string? WorkerProlog { get; init; }

    /// <summary>
    /// Slurm worker node epilog script.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("worker_epilog")]
    public string? WorkerEpilog { get; init; }

    /// <summary>
    /// Slurm controller prolog script.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("controller_prolog")]
    public string? ControllerProlog { get; init; }

    /// <summary>
    /// Slurm controller epilog script.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("controller_epilog")]
    public string? ControllerEpilog { get; init; }

    /// <summary>
    /// Script run on Slurm login node init.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("login_init_script")]
    public string? LoginInitScript { get; init; }

    /// <summary>
    /// Script run on Slurm nodeset init.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nodeset_init_script")]
    public string? NodesetInitScript { get; init; }

    /// <summary>
    /// Additional slurm.conf fragments.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("extra_slurm_conf")]
    public string? ExtraSlurmConf { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
