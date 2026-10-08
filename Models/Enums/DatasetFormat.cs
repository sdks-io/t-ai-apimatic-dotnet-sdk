using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Detected SFT dataset format for the sampled rows.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DatasetFormat>))]
public sealed record DatasetFormat : OpenStringEnum<DatasetFormat>
{
    private DatasetFormat(string value) : base(value)
    {
    }

    public static readonly DatasetFormat General = new("general");

    public static readonly DatasetFormat Conversation = new("conversation");

    public static readonly DatasetFormat Instruction = new("instruction");

    public TResult Match<TResult>(Func<TResult> onGeneral,
        Func<TResult> onConversation,
        Func<TResult> onInstruction,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == General => onGeneral(),
            _ when this == Conversation => onConversation(),
            _ when this == Instruction => onInstruction(),
            _ => otherwise(Value)
        };

    public void Match(Action onGeneral, Action onConversation, Action onInstruction, Action<string> otherwise)
    {
        if (this == General) onGeneral();
        else if (this == Conversation) onConversation();
        else if (this == Instruction) onInstruction();
        else otherwise(Value);
    }
}
