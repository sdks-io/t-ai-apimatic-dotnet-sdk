using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Capability>))]
public sealed record Capability : OpenStringEnum<Capability>
{
    private Capability(string value) : base(value)
    {
    }

    public static readonly Capability CapabilityChat = new("CAPABILITY_CHAT");

    public static readonly Capability CapabilityEmbedding = new("CAPABILITY_EMBEDDING");

    public static readonly Capability CapabilityReranking = new("CAPABILITY_RERANKING");

    public static readonly Capability CapabilityImageGeneration = new("CAPABILITY_IMAGE_GENERATION");

    public static readonly Capability CapabilityVideoGeneration = new("CAPABILITY_VIDEO_GENERATION");

    public TResult Match<TResult>(Func<TResult> onCapabilityChat,
        Func<TResult> onCapabilityEmbedding,
        Func<TResult> onCapabilityReranking,
        Func<TResult> onCapabilityImageGeneration,
        Func<TResult> onCapabilityVideoGeneration,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == CapabilityChat => onCapabilityChat(),
            _ when this == CapabilityEmbedding => onCapabilityEmbedding(),
            _ when this == CapabilityReranking => onCapabilityReranking(),
            _ when this == CapabilityImageGeneration => onCapabilityImageGeneration(),
            _ when this == CapabilityVideoGeneration => onCapabilityVideoGeneration(),
            _ => otherwise(Value)
        };

    public void Match(Action onCapabilityChat,
        Action onCapabilityEmbedding,
        Action onCapabilityReranking,
        Action onCapabilityImageGeneration,
        Action onCapabilityVideoGeneration,
        Action<string> otherwise)
    {
        if (this == CapabilityChat) onCapabilityChat();
        else if (this == CapabilityEmbedding) onCapabilityEmbedding();
        else if (this == CapabilityReranking) onCapabilityReranking();
        else if (this == CapabilityImageGeneration) onCapabilityImageGeneration();
        else if (this == CapabilityVideoGeneration) onCapabilityVideoGeneration();
        else otherwise(Value);
    }
}
