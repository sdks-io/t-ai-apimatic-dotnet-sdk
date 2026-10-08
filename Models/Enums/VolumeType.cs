using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<VolumeType>))]
public sealed record VolumeType : OpenStringEnum<VolumeType>
{
    private VolumeType(string value) : base(value)
    {
    }

    public static readonly VolumeType VolumeTypeReadOnly = new("readOnly");

    public TResult Match<TResult>(Func<TResult> onVolumeTypeReadOnly, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == VolumeTypeReadOnly => onVolumeTypeReadOnly(),
            _ => otherwise(Value)
        };

    public void Match(Action onVolumeTypeReadOnly, Action<string> otherwise)
    {
        if (this == VolumeTypeReadOnly) onVolumeTypeReadOnly();
        else otherwise(Value);
    }
}
