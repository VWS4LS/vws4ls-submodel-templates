using AasCore.Aas3_0;

namespace VWS4LS.SubmodelTemplates.AssetInterfacesDescription;

public abstract class SecurityScheme
{
    public static readonly ConceptDescription CD_Proxy = new("https://www.w3.org/2019/wot/security#proxy")
    {
        IdShort = "proxy",
        Description = [new LangStringTextType("en", "Provides address information of the proxy server the security configuration provides access to.")],
    };

    public static readonly ConceptDescription CD_Scheme = new("https://www.w3.org/2019/wot/security#SecurityScheme")
    {
        IdShort = "scheme",
        Description = [new LangStringTextType("en", "Defines the security mechanism that used during access. Supported modes one of nosec, basic, digest, bearer, psk, oauth2, apikey or auto.")],
    };

    public static readonly List<ConceptDescription> ConceptDescriptions = new()
    {
        CD_Proxy,
        CD_Scheme,
    };

    public abstract SubmodelElementCollection SubmodelElementCollection { get; }

    public SecurityScheme(SecuritySchemeType type)
    {
        Proxy = new Property(DataTypeDefXsd.AnyUri)
        {
            IdShort = CD_Proxy.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_Proxy.Id)]),
        };

        Scheme = new Property(DataTypeDefXsd.String)
        {
            IdShort = CD_Scheme.IdShort,
            SemanticId = new Reference(ReferenceTypes.ExternalReference, [new Key(KeyTypes.GlobalReference, CD_Scheme.Id)]),
            Value = type switch
            {
                SecuritySchemeType.NoSecurity => "nosec_sc",
                SecuritySchemeType.Basic => "basic_sc",
                SecuritySchemeType.Digest => "digest_sc",
                SecuritySchemeType.Bearer => "bearer_sc",
                SecuritySchemeType.Psk => "psk_sc",
                SecuritySchemeType.Oauth2 => "oauth2_sc",
                SecuritySchemeType.Apikey => "apikey_sc",
                SecuritySchemeType.Auto => "auto_sc",
                _ => throw new ArgumentOutOfRangeException(nameof(type)),
            },
        };
    }

    public Property Proxy { get; }

    public Property Scheme { get; }
}
