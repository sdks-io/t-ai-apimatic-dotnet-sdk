using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Type9>))]
public sealed record Type9 : OpenStringEnum<Type9>
{
    private Type9(string value) : base(value)
    {
    }

    public static readonly Type9 Stdout = new("stdout");

    public static readonly Type9 Stderr = new("stderr");

    public TResult Match<TResult>(Func<TResult> onStdout, Func<TResult> onStderr, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Stdout => onStdout(),
            _ when this == Stderr => onStderr(),
            _ => otherwise(Value)
        };

    public void Match(Action onStdout, Action onStderr, Action<string> otherwise)
    {
        if (this == Stdout) onStdout();
        else if (this == Stderr) onStderr();
        else otherwise(Value);
    }
}
