using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models.AnyOf;

/// <summary>
/// The result of the execution. If successful, <c>data</c> contains the result and <c>errors</c> is null. If unsuccessful, <c>data</c> is null and <c>errors</c> contains the errors.
/// </summary>
[JsonConverter(typeof(ExecuteResponseConverter))]
public record ExecuteResponse
{
    private readonly Optional<SuccessfulExecution> _successfulExecutionValue;

    private readonly Optional<FailedExecution> _failedExecutionValue;

    private ExecuteResponse(Optional<SuccessfulExecution> successfulExecutionValue,
        Optional<FailedExecution> failedExecutionValue)
    {
        _successfulExecutionValue = successfulExecutionValue;
        _failedExecutionValue = failedExecutionValue;
    }

    public static ExecuteResponse SuccessfulExecution(SuccessfulExecution value) =>
        new(Optional<SuccessfulExecution>.Some(value), default);

    public static ExecuteResponse FailedExecution(FailedExecution value) =>
        new(default, Optional<FailedExecution>.Some(value));

    public bool TryGetSuccessfulExecution(out SuccessfulExecution value) =>
        _successfulExecutionValue.TryGetValue(out value);

    public bool TryGetFailedExecution(out FailedExecution value) => _failedExecutionValue.TryGetValue(out value);

    public static implicit operator ExecuteResponse(SuccessfulExecution value) => SuccessfulExecution(value);

    public static implicit operator ExecuteResponse(FailedExecution value) => FailedExecution(value);
}

file sealed class ExecuteResponseConverter : JsonConverter<ExecuteResponse>
{
    public override ExecuteResponse Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<SuccessfulExecution>(root, options, out var successfulExecutionValue))
        {
            return ExecuteResponse.SuccessfulExecution(successfulExecutionValue);
        }
        if (JsonSerializer.TryDeserialize<FailedExecution>(root, options, out var failedExecutionValue))
        {
            return ExecuteResponse.FailedExecution(failedExecutionValue);
        }
        throw new JsonException(
            $"JSON does not match SuccessfulExecution or FailedExecution schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, ExecuteResponse value, JsonSerializerOptions options)
    {
        if (value.TryGetSuccessfulExecution(out var successfulExecutionValue))
        {
            JsonSerializer.Serialize(writer, successfulExecutionValue, options);
        }
        else if (value.TryGetFailedExecution(out var failedExecutionValue))
        {
            JsonSerializer.Serialize(writer, failedExecutionValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(ExecuteResponse)} contains no valid value to serialize.");
        }
    }
}
