using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// A tensor encoded as flattened row-major values, with an optional shape.
/// </summary>
public record RlTensorData
{
    /// <summary>
    /// Flattened one-dimensional values encoded as JSON numbers.
    /// </summary>
    [JsonPropertyName("data")]
    public required IReadOnlyList<double> Data { get; init; }

    /// <summary>
    /// Tensor element type, either <c>int64</c> or <c>float32</c>.
    /// </summary>
    [JsonPropertyName("dtype")]
    public required Dtype Dtype { get; init; }

    /// <summary>
    /// Optional tensor shape; training operations accept one-dimensional tensors only, and the dimension must match the data length.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shape")]
    public IReadOnlyList<int>? Shape { get; init; }

    /// <summary>
    /// Unsupported for training operations. Omit this field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sparse_crow_indices")]
    public IReadOnlyList<int>? SparseCrowIndices { get; init; }

    /// <summary>
    /// Unsupported for training operations. Omit this field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sparse_col_indices")]
    public IReadOnlyList<int>? SparseColIndices { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
