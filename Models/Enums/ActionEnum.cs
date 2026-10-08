using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// How this revision became active.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ActionEnum>))]
public sealed record ActionEnum : OpenStringEnum<ActionEnum>
{
    private ActionEnum(string value) : base(value)
    {
    }

    public static readonly ActionEnum Create = new("create");

    public static readonly ActionEnum Update = new("update");

    public static readonly ActionEnum System = new("system");

    public static readonly ActionEnum Rollback = new("rollback");

    public TResult Match<TResult>(Func<TResult> onCreate,
        Func<TResult> onUpdate,
        Func<TResult> onSystem,
        Func<TResult> onRollback,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Create => onCreate(),
            _ when this == Update => onUpdate(),
            _ when this == System => onSystem(),
            _ when this == Rollback => onRollback(),
            _ => otherwise(Value)
        };

    public void Match(Action onCreate, Action onUpdate, Action onSystem, Action onRollback, Action<string> otherwise)
    {
        if (this == Create) onCreate();
        else if (this == Update) onUpdate();
        else if (this == System) onSystem();
        else if (this == Rollback) onRollback();
        else otherwise(Value);
    }
}
