using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Type6>))]
public sealed record Type6 : OpenStringEnum<Type6>
{
    private Type6(string value) : base(value)
    {
    }

    public static readonly Type6 Chat = new("chat");

    public static readonly Type6 Language = new("language");

    public static readonly Type6 Code = new("code");

    public static readonly Type6 Image = new("image");

    public static readonly Type6 Embedding = new("embedding");

    public static readonly Type6 Moderation = new("moderation");

    public static readonly Type6 Rerank = new("rerank");

    public TResult Match<TResult>(Func<TResult> onChat,
        Func<TResult> onLanguage,
        Func<TResult> onCode,
        Func<TResult> onImage,
        Func<TResult> onEmbedding,
        Func<TResult> onModeration,
        Func<TResult> onRerank,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Chat => onChat(),
            _ when this == Language => onLanguage(),
            _ when this == Code => onCode(),
            _ when this == Image => onImage(),
            _ when this == Embedding => onEmbedding(),
            _ when this == Moderation => onModeration(),
            _ when this == Rerank => onRerank(),
            _ => otherwise(Value)
        };

    public void Match(Action onChat,
        Action onLanguage,
        Action onCode,
        Action onImage,
        Action onEmbedding,
        Action onModeration,
        Action onRerank,
        Action<string> otherwise)
    {
        if (this == Chat) onChat();
        else if (this == Language) onLanguage();
        else if (this == Code) onCode();
        else if (this == Image) onImage();
        else if (this == Embedding) onEmbedding();
        else if (this == Moderation) onModeration();
        else if (this == Rerank) onRerank();
        else otherwise(Value);
    }
}
