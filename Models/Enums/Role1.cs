using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Role1>))]
public sealed record Role1 : OpenStringEnum<Role1>
{
    private Role1(string value) : base(value)
    {
    }

    public static readonly Role1 System = new("system");

    public static readonly Role1 User = new("user");

    public static readonly Role1 Assistant = new("assistant");

    public static readonly Role1 Function = new("function");

    public static readonly Role1 Tool = new("tool");

    public TResult Match<TResult>(Func<TResult> onSystem,
        Func<TResult> onUser,
        Func<TResult> onAssistant,
        Func<TResult> onFunction,
        Func<TResult> onTool,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == System => onSystem(),
            _ when this == User => onUser(),
            _ when this == Assistant => onAssistant(),
            _ when this == Function => onFunction(),
            _ when this == Tool => onTool(),
            _ => otherwise(Value)
        };

    public void Match(Action onSystem,
        Action onUser,
        Action onAssistant,
        Action onFunction,
        Action onTool,
        Action<string> otherwise)
    {
        if (this == System) onSystem();
        else if (this == User) onUser();
        else if (this == Assistant) onAssistant();
        else if (this == Function) onFunction();
        else if (this == Tool) onTool();
        else otherwise(Value);
    }
}
