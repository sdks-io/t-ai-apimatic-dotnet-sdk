using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Model1>))]
public sealed record Model1 : OpenStringEnum<Model1>
{
    private Model1(string value) : base(value)
    {
    }

    public static readonly Model1 MetaLlamaLlama270BHf = new("meta-llama/Llama-2-70b-hf");

    public static readonly Model1 MistralaiMistral7BV01 = new("mistralai/Mistral-7B-v0.1");

    public static readonly Model1 MistralaiMixtral8X7BV01 = new("mistralai/Mixtral-8x7B-v0.1");

    public static readonly Model1 MetaLlamaLlamaGuard7B = new("Meta-Llama/Llama-Guard-7b");

    public TResult Match<TResult>(Func<TResult> onMetaLlamaLlama270BHf,
        Func<TResult> onMistralaiMistral7BV01,
        Func<TResult> onMistralaiMixtral8X7BV01,
        Func<TResult> onMetaLlamaLlamaGuard7B,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == MetaLlamaLlama270BHf => onMetaLlamaLlama270BHf(),
            _ when this == MistralaiMistral7BV01 => onMistralaiMistral7BV01(),
            _ when this == MistralaiMixtral8X7BV01 => onMistralaiMixtral8X7BV01(),
            _ when this == MetaLlamaLlamaGuard7B => onMetaLlamaLlamaGuard7B(),
            _ => otherwise(Value)
        };

    public void Match(Action onMetaLlamaLlama270BHf,
        Action onMistralaiMistral7BV01,
        Action onMistralaiMixtral8X7BV01,
        Action onMetaLlamaLlamaGuard7B,
        Action<string> otherwise)
    {
        if (this == MetaLlamaLlama270BHf) onMetaLlamaLlama270BHf();
        else if (this == MistralaiMistral7BV01) onMistralaiMistral7BV01();
        else if (this == MistralaiMixtral8X7BV01) onMistralaiMixtral8X7BV01();
        else if (this == MetaLlamaLlamaGuard7B) onMetaLlamaLlamaGuard7B();
        else otherwise(Value);
    }
}
