using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<LoadBalancer>))]
public sealed record LoadBalancer : OpenStringEnum<LoadBalancer>
{
    private LoadBalancer(string value) : base(value)
    {
    }

    public static readonly LoadBalancer None = new("NONE");

    public static readonly LoadBalancer Traefik = new("TRAEFIK");

    public static readonly LoadBalancer Nginx = new("NGINX");

    public static readonly LoadBalancer Istio = new("ISTIO");

    public TResult Match<TResult>(Func<TResult> onNone,
        Func<TResult> onTraefik,
        Func<TResult> onNginx,
        Func<TResult> onIstio,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == None => onNone(),
            _ when this == Traefik => onTraefik(),
            _ when this == Nginx => onNginx(),
            _ when this == Istio => onIstio(),
            _ => otherwise(Value)
        };

    public void Match(Action onNone, Action onTraefik, Action onNginx, Action onIstio, Action<string> otherwise)
    {
        if (this == None) onNone();
        else if (this == Traefik) onTraefik();
        else if (this == Nginx) onNginx();
        else if (this == Istio) onIstio();
        else otherwise(Value);
    }
}
