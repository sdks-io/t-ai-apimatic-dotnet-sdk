using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<SafetyModel>))]
public sealed record SafetyModel : OpenStringEnum<SafetyModel>
{
    private SafetyModel(string value) : base(value)
    {
    }

    public static readonly SafetyModel MetaLlamaLlamaGuard7B = new("Meta-Llama/Llama-Guard-7b");

    public TResult Match<TResult>(Func<TResult> onMetaLlamaLlamaGuard7B, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == MetaLlamaLlamaGuard7B => onMetaLlamaLlamaGuard7B(),
            _ => otherwise(Value)
        };

    public void Match(Action onMetaLlamaLlamaGuard7B, Action<string> otherwise)
    {
        if (this == MetaLlamaLlamaGuard7B) onMetaLlamaLlamaGuard7B();
        else otherwise(Value);
    }
}
